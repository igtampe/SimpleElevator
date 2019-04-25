Public Class Summary
    Public Colors(15) As String
    Public AddMode As Boolean
    Public Sub Summary_Load() Handles MyBase.Load
        Colors(0) = "black"
        Colors(1) = "dark_blue"
        Colors(2) = "dark_green"
        Colors(3) = "dark_aqua"
        Colors(4) = "dark_red"
        Colors(5) = "dark_purple"
        Colors(6) = "gold"
        Colors(7) = "gray"
        Colors(8) = "dark_gray"
        Colors(9) = "blue"
        Colors(10) = "green"
        Colors(11) = "aqua"
        Colors(12) = "red"
        Colors(13) = "light_purple"
        Colors(14) = "yellow"
        Colors(15) = "white"

        BuildingColorDRPDWN.Items.Clear()
        For x = 0 To 15
            BuildingColorDRPDWN.Items.Add(Colors(x))
        Next

        ItemDetails.DetailComboBox.Items.Clear()
        For x = 0 To 15
            ItemDetails.DetailComboBox.Items.Add(Colors(x))
        Next


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles BuildingNameTXB.TextChanged
        Text = BuildingNameTXB.Text
        MainWindow.CurrentElevator.Name = BuildingNameTXB.Text
        MainWindow.ExportGenerate()
        MainWindow.PreviewGenerate()
    End Sub

    Private Sub AddBTN_Click(sender As Object, e As EventArgs) Handles AddBTN.Click
        'add
        ItemDetails.Text = "New Item"
        AddMode = True
        ItemDetails.MdiParent = MainWindow
        ItemDetails.Show()

        ItemDetails.FloorNameTXB.Text = ""
        ItemDetails.XTXB.Text = "~"
        ItemDetails.YTXB.Text = ""
        ItemDetails.ZTXB.Text = "~"
        ItemDetails.HoverTXB.Text = ""

        ItemDetails.DetailComboBox.Items.Clear()
        For x = 0 To 15
            ItemDetails.DetailComboBox.Items.Add(Colors(x))
        Next

    End Sub

    Private Sub ModBTN_Click(sender As Object, e As EventArgs) Handles ModBTN.Click
        'Modify
        ItemDetails.Text = "Item #" & (ListView.SelectedIndices(0) + 1).ToString
        AddMode = False
        ItemDetails.MdiParent = MainWindow
        ItemDetails.Show()

        ItemDetails.FloorNameTXB.Text = MainWindow.CurrentElevator.Floor(ListView.SelectedIndices(0)).FloorText
        ItemDetails.XTXB.Text = MainWindow.CurrentElevator.Floor(ListView.SelectedIndices(0)).XCoord
        ItemDetails.YTXB.Text = MainWindow.CurrentElevator.Floor(ListView.SelectedIndices(0)).YCoord
        ItemDetails.ZTXB.Text = MainWindow.CurrentElevator.Floor(ListView.SelectedIndices(0)).ZCoord
        ItemDetails.HoverTXB.Text = MainWindow.CurrentElevator.Floor(ListView.SelectedIndices(0)).HoverText
        ItemDetails.DetailComboBox.Text = MainWindow.CurrentElevator.Floor(ListView.SelectedIndices(0)).Color

        ItemDetails.DetailComboBox.Items.Clear()

        For x = 0 To 15
            ItemDetails.DetailComboBox.Items.Add(Colors(x))
        Next


    End Sub

    Private Sub RemoveBTN_Click(sender As Object, e As EventArgs) Handles RemoveBTN.Click
        MainWindow.RemoveFloorFromElevator(ListView.SelectedIndices(0))
    End Sub



    Private Sub BuildingColorDRPDWN_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BuildingColorDRPDWN.SelectedIndexChanged
        MainWindow.CurrentElevator.NameColor = Colors(BuildingColorDRPDWN.SelectedIndex)
        MainWindow.ExportGenerate()
    End Sub

    Private Sub ListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView.SelectedIndexChanged
        ModBTN.Enabled = True
        RemoveBTN.Enabled = True
    End Sub

    Private Sub ClearBTN_Click(sender As Object, e As EventArgs) Handles ClearBTN.Click
        Select Case MsgBox("Are you sure you want to clear all floors?", 32 + 4, "SimpleElevator")
            Case MsgBoxResult.Yes
                MainWindow.CurrentElevator.Floor = Nothing

                ListView.Clear()
                ListView.View = View.Details
                ListView.Columns.Add("Floor")
                ListView.Columns.Item(0).Width = 85
                ListView.Columns.Add("Command")
                ListView.Columns.Item(1).Width = 77
                ListView.Columns.Add("Hover Text")
                ListView.Columns.Item(2).Width = 121
                ListView.Columns.Add("Color")
                ListView.Columns.Item(3).Width = 90
                ListView.MultiSelect = False
                ListView.FullRowSelect = True
                ListView.HideSelection = False


                MainWindow.ExportGenerate()
                MainWindow.PreviewGenerate()

            Case MsgBoxResult.No
                Exit Sub
            Case Else
                Exit Sub
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        AutoAdd.ColorComboBox.Items.Clear()
        For x = 0 To 15
            AutoAdd.ColorComboBox.Items.Add(Colors(x))
        Next

        AutoAdd.MdiParent = MainWindow
        AutoAdd.Show()
    End Sub
End Class