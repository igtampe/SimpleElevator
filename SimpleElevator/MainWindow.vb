Imports System.IO

Public Class MainWindow

    Public Structure Floors
        Public FloorText As String
        Public HoverText As String
        Public Color As String
        Public XCoord As String
        Public YCoord As String
        Public ZCoord As String
    End Structure

    Public Structure Elevator
        Public Name As String
        Public NameColor As String
        Public Floor() As Floors
    End Structure
    Public ExportWindow As TextboxWindow
    Public ExportText As String
    Public PreviewText As String

    Public PreviewWindow As TextboxWindow
    Public CurrentElevator As Elevator
    Public FileModified As Boolean
    Dim positionwindow As TextboxWindow = New TextboxWindow
    Public FileName As String

    Public WelcomeResult As DialogResult
    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles Me.Closing
        Select Case MsgBox("This file has been modified! Do you wish to save?", 32 + 4, "SimpleElevator")
            Case MsgBoxResult.Yes
                'save
                SaveFile()
                Form1.Close()
            Case MsgBoxResult.No
                'Donot save
                Form1.Close()
        End Select
    End Sub

    Private Sub MainWindow_Load_1(sender As Object, e As EventArgs) Handles Me.Shown

        ExportWindow = New TextboxWindow
        PreviewWindow = New TextboxWindow

        ExportWindow.Text = "Export Window"
        PreviewWindow.Text = "Preview Window"

        ExportWindow.MdiParent = Me
        PreviewWindow.MdiParent = Me

        If My.Application.CommandLineArgs.Count = 1 Then
            OpenCommandlineFile(My.Application.CommandLineArgs(0))
            Exit Sub
        End If

        WelcomeWindow.ShowDialog()

        Select Case WelcomeResult
            Case DialogResult.Yes
                'open
                OpenFile()
            Case DialogResult.No
                NewFile()

        End Select

    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        About.ShowDialog()
    End Sub

    Sub NewFile()


        CurrentElevator = Nothing

        ExportText = ""
        ExportWindow.TextBox1.Text = ""
        FileModified = False

        ExportWindow.Show()
        PreviewWindow.Show()

        Summary.MdiParent = Me
        Summary.Show()

        Me.Text = "Untitled File - SimpleElevator"

        ViewToolStripMenuItem.Enabled = True
        SaveToolStripMenuItem.Enabled = True
        SaveAsToolStripMenuItem.Enabled = True
        ExportToolStripMenuItem.Enabled = True

        Summary.ListView.Clear()
        Summary.ListView.View = View.Details
        Summary.ListView.Columns.Add("Floor")
        Summary.ListView.Columns.Item(0).Width = 85
        Summary.ListView.Columns.Add("Command")
        Summary.ListView.Columns.Item(1).Width = 77
        Summary.ListView.Columns.Add("Hover Text")
        Summary.ListView.Columns.Item(2).Width = 121
        Summary.ListView.Columns.Add("Color")
        Summary.ListView.Columns.Item(3).Width = 90
        Summary.ListView.MultiSelect = False
        Summary.ListView.FullRowSelect = True
        Summary.ListView.HideSelection = False

        Summary.BuildingNameTXB.Text = "Building name"
        Summary.BuildingColorDRPDWN.Text = ""
        Summary.Summary_Load()

        ExportGenerate()
        PreviewGenerate()





        FileModified = False



    End Sub

    Private Sub ExportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportToolStripMenuItem.Click
        My.Computer.Clipboard.SetText(ExportText)
        MsgBox("Command was copied to clipboard", MsgBoxStyle.Information, "o k")
    End Sub

    Public Sub AddFloorToElevator(Text As String, HoverText As String, Color As String, XCoord As String, YCoord As String, ZCoord As String)
        FileModified = True
        Dim NewIndex As Integer
        If IsNothing(CurrentElevator.Floor) Then
            NewIndex = 0
        Else
            NewIndex = CurrentElevator.Floor.Count
        End If

        ReDim Preserve CurrentElevator.Floor(NewIndex)

        CurrentElevator.Floor(NewIndex).FloorText = Text
        CurrentElevator.Floor(NewIndex).HoverText = HoverText
        CurrentElevator.Floor(NewIndex).Color = Color
        CurrentElevator.Floor(NewIndex).XCoord = XCoord
        CurrentElevator.Floor(NewIndex).YCoord = YCoord
        CurrentElevator.Floor(NewIndex).ZCoord = ZCoord
        PopulateListview()



    End Sub

    Public Sub RemoveFloorFromElevator(Index As Integer)
        FileModified = True
        If CurrentElevator.Floor.Count = 1 Then
            CurrentElevator.Floor = Nothing

            Summary.ListView.Clear()
            Summary.ListView.View = View.Details
            Summary.ListView.Columns.Add("Floor")
            Summary.ListView.Columns.Item(0).Width = 85
            Summary.ListView.Columns.Add("Command")
            Summary.ListView.Columns.Item(1).Width = 77
            Summary.ListView.Columns.Add("Hover Text")
            Summary.ListView.Columns.Item(2).Width = 121
            Summary.ListView.Columns.Add("Color")
            Summary.ListView.Columns.Item(3).Width = 90
            Summary.ListView.MultiSelect = False
            Summary.ListView.FullRowSelect = True
            Summary.ListView.HideSelection = False
            ExportGenerate()
            PreviewGenerate()
            Exit Sub
        End If

        For X = Index To CurrentElevator.Floor.Count - 2
            CurrentElevator.Floor(X) = CurrentElevator.Floor(X + 1)
        Next

        ReDim Preserve CurrentElevator.Floor(CurrentElevator.Floor.Count - 2)
        PopulateListview()

    End Sub

    Public Sub ModFloorFromElevator(NewIndex As Integer, Text As String, HoverText As String, Color As String, XCoord As String, YCoord As String, ZCoord As String)
        FileModified = True
        CurrentElevator.Floor(NewIndex).FloorText = Text
        CurrentElevator.Floor(NewIndex).HoverText = HoverText
        CurrentElevator.Floor(NewIndex).Color = Color
        CurrentElevator.Floor(NewIndex).XCoord = XCoord
        CurrentElevator.Floor(NewIndex).YCoord = YCoord
        CurrentElevator.Floor(NewIndex).ZCoord = ZCoord
        PopulateListview()

    End Sub

    Public Sub ExportGenerate()
        ExportText = "/tellraw @p ["""",{""text"":""" & CurrentElevator.Name & """,""color"":""" & CurrentElevator.NameColor & """}"

        Try
            For x = 0 To CurrentElevator.Floor.Count - 1
                ExportText = ExportText & ",{""text"":""" & CurrentElevator.Floor(x).FloorText & """,""color"":""" & CurrentElevator.Floor(x).Color & """,""clickEvent"":{""action"":""run_command"",""value"":""/tp @p " & CurrentElevator.Floor(x).XCoord & " " & CurrentElevator.Floor(x).YCoord & " " & CurrentElevator.Floor(x).ZCoord & """},""hoverEvent"":{""action"":""show_text"",""value"":{""text"":"""",""extra"":[{""text"":""" & CurrentElevator.Floor(x).HoverText & """}]}}}"
            Next
        Catch
        End Try

        ExportText = ExportText & "]"

        ExportWindow.TextBox1.Text = ExportText
        FileModified = True
    End Sub

    Public Sub PreviewGenerate()
        Try
            PreviewText = CurrentElevator.Name.Replace("\n", vbNewLine)
            Try
                For X = 0 To CurrentElevator.Floor.Count - 1
                    PreviewText = PreviewText & CurrentElevator.Floor(X).FloorText.Replace("\n", vbNewLine)
                Next
            Catch
            End Try
            PreviewWindow.TextBox1.Text = PreviewText
        Catch
            PreviewWindow.TextBox1.Text = "Unable to render preview"
        End Try



        '
        FileModified = True
    End Sub

    Sub PopulateListview()
        Dim I As Integer
        Summary.ListView.Clear()
        Summary.ListView.View = View.Details
        Summary.ListView.Columns.Add("Floor")
        Summary.ListView.Columns.Item(0).Width = 85
        Summary.ListView.Columns.Add("Command")
        Summary.ListView.Columns.Item(1).Width = 77
        Summary.ListView.Columns.Add("Hover Text")
        Summary.ListView.Columns.Item(2).Width = 121
        Summary.ListView.Columns.Add("Color")
        Summary.ListView.Columns.Item(3).Width = 90
        Summary.ListView.MultiSelect = False
        Summary.ListView.FullRowSelect = True
        Summary.ListView.HideSelection = False

        For I = 0 To CurrentElevator.Floor.Count - 1

            Dim CLVI As ListViewItem

            CLVI = New ListViewItem With {
            .Text = CurrentElevator.Floor(I).FloorText
        }
            CLVI.SubItems.Add(CurrentElevator.Floor(I).XCoord & " " & CurrentElevator.Floor(I).YCoord & " " & CurrentElevator.Floor(I).ZCoord)
            CLVI.SubItems.Add(CurrentElevator.Floor(I).HoverText)
            CLVI.SubItems.Add(CurrentElevator.Floor(I).Color)
            Summary.ListView.Items.Add(CLVI)

        Next

        ExportGenerate()
        PreviewGenerate()

        Summary.ModBTN.Enabled = False
        Summary.RemoveBTN.Enabled = False

    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        If FileModified = True Then
            Select Case MsgBox("This file has been modified! Do you wish to save?", 32 + 3, "SimpleElevator")
                Case MsgBoxResult.Yes
                    'save
                    SaveFile()
                    NewFile()
                Case MsgBoxResult.No
                    'Donot save
                    NewFile()
                Case MsgBoxResult.Cancel
                    'donot do anything
            End Select

        Else
            NewFile()
        End If

    End Sub

    Sub UpdateFileName()
        Select Case SaveFileDialog1.ShowDialog()
            Case DialogResult.OK
                FileName = SaveFileDialog1.FileName
                Text = FileName & " - SimpleElevator"
            Case DialogResult.Cancel
        End Select

    End Sub

    Sub SaveFile(Optional SpecifyNewFilename As Boolean = False)

        If SpecifyNewFilename Then
            Select Case SaveFileDialog1.ShowDialog()
                Case DialogResult.OK
                    FileName = SaveFileDialog1.FileName
                    Text = FileName & " - SimpleElevator"
                Case DialogResult.Cancel
                    Exit Sub
            End Select
        End If

        If FileName = "" Then
            Select Case SaveFileDialog1.ShowDialog()
                Case DialogResult.OK
                    FileName = SaveFileDialog1.FileName
                    Text = FileName & " - SimpleElevator"
                Case DialogResult.Cancel
                    Exit Sub
            End Select
        End If

        FileOpen(1, FileName, OpenMode.Output)
        PrintLine(1, CurrentElevator.Name & "`" & CurrentElevator.NameColor)
        For X = 0 To CurrentElevator.Floor.Count - 1
            PrintLine(1, CurrentElevator.Floor(X).FloorText & "`" & CurrentElevator.Floor(X).HoverText & "`" & CurrentElevator.Floor(X).Color & "`" & CurrentElevator.Floor(X).XCoord & "`" & CurrentElevator.Floor(X).YCoord & "`" & CurrentElevator.Floor(X).ZCoord)
        Next
        FileClose(1)
        FileModified = False
    End Sub

    Sub OpenCommandlineFile(OpeneFile As String)
        If Not File.Exists(OpeneFile) Then
            MsgBox("hoo hoo ha ha hee hee, the file does not exists.", MsgBoxStyle.Critical, "n o")
            Application.Exit()
        End If
        FileName = OpeneFile
        Text = FileName & " - SimpleElevator"
        CurrentElevator = Nothing
        FileOpen(1, FileName, OpenMode.Input)
        Dim TempSplit() As String
        TempSplit = LineInput(1).Split("`")
        CurrentElevator.Name = TempSplit(0)
        Dim tempname As String = CurrentElevator.Name
        Summary.BuildingNameTXB.Text = CurrentElevator.Name

        CurrentElevator.NameColor = TempSplit(1)
        Summary.BuildingColorDRPDWN.Text = CurrentElevator.NameColor

        While Not EOF(1)
            TempSplit = LineInput(1).Split("`")
            If TempSplit.Count = 6 Then AddFloorToElevator(TempSplit(0), TempSplit(1), TempSplit(2), TempSplit(3), TempSplit(4), TempSplit(5))
        End While

        FileClose(1)

        ViewToolStripMenuItem.Enabled = True
        SaveToolStripMenuItem.Enabled = True
        SaveAsToolStripMenuItem.Enabled = True
        ExportToolStripMenuItem.Enabled = True

        ExportWindow.Show()
        PreviewWindow.Show()

        Summary.MdiParent = Me
        Summary.Show()
        Summary.BuildingNameTXB.Text = tempname


        FileModified = False
    End Sub

    Sub OpenFile()
        'Open a file
        Select Case OpenFileDialog1.ShowDialog()
            Case DialogResult.OK
                FileName = OpenFileDialog1.FileName
                Text = FileName & " - SimpleElevator"
                CurrentElevator = Nothing
                FileOpen(1, FileName, OpenMode.Input)
                Dim TempSplit() As String
                TempSplit = LineInput(1).Split("`")
                CurrentElevator.Name = TempSplit(0)
                Dim tempname As String = CurrentElevator.Name
                Summary.BuildingNameTXB.Text = CurrentElevator.Name

                CurrentElevator.NameColor = TempSplit(1)
                Summary.BuildingColorDRPDWN.Text = CurrentElevator.NameColor

                While Not EOF(1)
                    TempSplit = LineInput(1).Split("`")
                    If TempSplit.Count = 6 Then AddFloorToElevator(TempSplit(0), TempSplit(1), TempSplit(2), TempSplit(3), TempSplit(4), TempSplit(5))
                End While

                FileClose(1)

                ViewToolStripMenuItem.Enabled = True
                SaveToolStripMenuItem.Enabled = True
                SaveAsToolStripMenuItem.Enabled = True
                ExportToolStripMenuItem.Enabled = True

                ExportWindow.Show()
                PreviewWindow.Show()

                Summary.MdiParent = Me
                Summary.Show()
                Summary.BuildingNameTXB.Text = tempname


                FileModified = False
            Case DialogResult.Cancel
                Exit Sub
        End Select


    End Sub

    Private Sub PreviewToolStripMenuItem_Click(sender As Object, e As EventArgs)
        PreviewWindow.Show()
    End Sub

    Private Sub SummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SummaryToolStripMenuItem.Click
        Summary.MdiParent = Me
        Summary.Show()
    End Sub

    Private Sub PreviewToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PreviewToolStripMenuItem1.Click
        PreviewWindow.MdiParent = Me
        PreviewWindow.Show()
    End Sub

    Private Sub ExportToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExportToolStripMenuItem1.Click
        ExportWindow.MdiParent = Me
        ExportWindow.Show()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If FileModified = True Then
            Select Case MsgBox("This file has been modified! Do you wish to save?", 32 + 3, "SimpleElevator")
                Case MsgBoxResult.Yes
                    'save
                    OpenFile()
                    NewFile()
                Case MsgBoxResult.No
                    'Donot save
                    OpenFile()
                Case MsgBoxResult.Cancel
                    'donot do anything
            End Select

        Else
            OpenFile()
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        'save as
        SaveFile(True)
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        'save
        SaveFile()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub MainWindow_Load_2(sender As Object, e As EventArgs) Handles Me.Load
        ViewToolStripMenuItem.Enabled = False
        SaveToolStripMenuItem.Enabled = False
        SaveAsToolStripMenuItem.Enabled = False
        ExportToolStripMenuItem.Enabled = False
    End Sub
End Class