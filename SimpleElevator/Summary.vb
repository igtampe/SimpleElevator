''' <summary>Shows a summary of, and holds a Comand Block Elevator</summary>
Public Class Summary

    '----------------------------------------------------[Variables]----------------------------------------------------

    Public ReadOnly myElevator As CBElevator
    Private HasBeenModified As Boolean = False

    Private Filename As String

    Public ReadOnly ExportWindow As TextboxWindow
    Public ReadOnly PreviewWindow As TextboxWindow

    '----------------------------------------------------[Initialization]----------------------------------------------------

    Public Sub New(MyElevator As CBElevator, MDIParent As Form, Optional Filename As String = "")

        'Initialize my children
        Me.myElevator = MyElevator
        Me.Filename = Filename

        ExportWindow = New TextboxWindow("Export Window", MDIParent)
        PreviewWindow = New TextboxWindow("Preview Window", MDIParent)

        InitializeComponent()

        'Initialize myself
        Me.MdiParent = MDIParent

        ExportWindow.Show()
        PreviewWindow.Show()

        'Add all colors to the dropdown
        For Each MCColor As MCColor In MCColor.Dictionary
            BuildingColorDRPDWN.Items.Add(MCColor.Name)
        Next

        'Put the name in
        Text = MyElevator.Name & " (" & Filename.Split("\")(Filename.Split("\").Count - 1) & ")"
        FileToolStripMenuItem.Text = MyElevator.Name
        BuildingNameTXB.Text = MyElevator.Name
        BuildingColorDRPDWN.Text = MyElevator.NameColor.Name

        ExportWindow.Text = "Export Window - " & MyElevator.Name
        PreviewWindow.Text = "Preview Window - " & MyElevator.Name

        PopulateListview()

        'Mark the file as unchanged because changing the  building name txb will trigger it falsely
        MainWindow.Text = MainWindow.Text.TrimEnd("*")
        HasBeenModified = False


    End Sub

    '----------------------------------------------------[Buttons]----------------------------------------------------

    Private Sub NameChanged() Handles BuildingNameTXB.TextChanged
        'Update myElevator

        myElevator.Name = BuildingNameTXB.Text

        If Not String.IsNullOrEmpty(myElevator.Name) Then
            FileToolStripMenuItem.Text = myElevator.Name
        Else
            FileToolStripMenuItem.Text = "Summary Window"
        End If

        Text = myElevator.Name & " (" & Filename.Split("\")(Filename.Split("\").Count - 1) & ")"

        'Update Export and Preview Window
        UpdateExport()
        UpdatePreview()

        'Mark as modified
        FlagAsModified()
    End Sub

    Private Sub AddNewFloor() Handles AddBTN.Click
        'add
        Dim NewFloorWindow As ItemDetails = New ItemDetails(Me, MdiParent)
        NewFloorWindow.Show()
    End Sub

    Private Sub ModifyFloor() Handles ModBTN.Click
        'Modify
        Dim ItemIndex As Integer

        Try
            ItemIndex = ListView.SelectedIndices(0)
        Catch ex As Exception
            Debug.Print(ex.StackTrace)
            MsgBox("Please have an item selected!", MsgBoxStyle.Critical)
            Exit Sub
        End Try

        Dim ModFloorWindow As ItemDetails = New ItemDetails(Me, MdiParent, myElevator.GetFloors(ItemIndex), ItemIndex) With {.Text = "Item #" & (ItemIndex + 1).ToString}
        ModFloorWindow.Show()
    End Sub

    Private Sub RemoveFloor() Handles RemoveBTN.Click
        myElevator.RemoveFloor(ListView.SelectedIndices(0))
        PopulateListview()

        'Mark as modified
        FlagAsModified()
    End Sub

    Private Sub ChangedBuildingColor() Handles BuildingColorDRPDWN.SelectedIndexChanged
        myElevator.NameColor = MCColor.ColorStringToMCColor(BuildingColorDRPDWN.Text)
        UpdateExport()

        'Mark as modified
        FlagAsModified()
    End Sub

    Private Sub HeDidAClick() Handles ListView.SelectedIndexChanged
        ModBTN.Enabled = True
        RemoveBTN.Enabled = True
    End Sub

    Private Sub HeDidADoubleClick() Handles ListView.DoubleClick
        Try 'Try in case he 
            ModifyFloor()
        Catch
        End Try
    End Sub

    Private Sub ClearFloors() Handles ClearBTN.Click
        If MsgBox("Are you sure you want to clear all floors?", 32 + 4, "SimpleElevator") = MsgBoxResult.Yes Then
            myElevator.ClearFloors()
            PopulateListview()

            'Mark as modified
            FlagAsModified()

        End If
    End Sub

    Private Sub LaunchAutoAdd() Handles AutoAddBTN.Click
        Dim AutoAdder As AutoAdd = New AutoAdd(Me, MdiParent)
        AutoAdder.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub ExportTime() Handles ExportMenuItem.Click
        My.Computer.Clipboard.SetText(ExportWindow.TextBox1.Text)
        MsgBox("Command was copied to clipboard", MsgBoxStyle.Information, "o k")
    End Sub

    Public Function Save() As Boolean Handles SaveToolStripMenuItem.Click

        If String.IsNullOrWhiteSpace(Filename) Then
            Select Case MainWindow.SaveFileDialog1.ShowDialog()
                Case DialogResult.OK
                    Filename = MainWindow.SaveFileDialog1.FileName
                    Text = myElevator.Name & " (" & Filename.Split("\")(Filename.Split("\").Count - 1) & ")"
                Case DialogResult.Cancel
                    Return False
            End Select

        End If

        myElevator.Save(Filename)
        HasBeenModified = False
        MainWindow.Text = MainWindow.Text.TrimEnd("*")

        Return True
    End Function

    Public Sub SaveAs() Handles SaveAsToolStripMenuItem.Click
        If MainWindow.SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Filename = MainWindow.SaveFileDialog1.FileName
            Text = myElevator.Name & " (" & Filename.Split("\")(Filename.Split("\").Count - 1) & ")"
            Save()
        End If
    End Sub

    '----------------------------------------------------[Other Operations]----------------------------------------------------

    Public Sub PopulateListview()
        ListView.Items.Clear()

        For Each Floor As Floor In myElevator.GetFloors
            Dim CLVI As ListViewItem = New ListViewItem With {.Text = Floor.FloorText}
            CLVI.SubItems.Add(String.Join(" ", Floor.GetCoords))
            CLVI.SubItems.Add(Floor.HoverText)
            CLVI.SubItems.Add(MCColor.ColorStringToName(Floor.Color))
            ListView.Items.Add(CLVI)
        Next

        UpdateExport()
        UpdatePreview()

        ModBTN.Enabled = False
        RemoveBTN.Enabled = False
    End Sub

    Private Sub UpdateExport()
        ExportWindow.Text = "Export Window - " & myElevator.Name
        ExportWindow.TextBox1.Text = myElevator.GetExport()
    End Sub

    Private Sub UpdatePreview()
        PreviewWindow.Text = "Preview Window - " & myElevator.Name
        PreviewWindow.TextBox1.Text = myElevator.GetPreview()
    End Sub

    Public Function Modified()
        Return HasBeenModified
    End Function

    Public Sub FlagAsModified()
        HasBeenModified = True
        If Not MainWindow.Text.EndsWith("*") Then MainWindow.Text &= "*"
    End Sub

    Private Sub ClosingTime() Handles Me.Closing
        If Modified() Then
            If MsgBox(myElevator.Name & " has been modified! Do you wish to save?", 32 + 4, "SimpleElevator") = MsgBoxResult.Yes Then
                Save()
            End If
        End If

        ExportWindow.Close()
        PreviewWindow.Close()

    End Sub

End Class