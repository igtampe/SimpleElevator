Public Class Summary
    Public Colors(15) As String
    Public AddMode As Boolean
    Private Sub Summary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        For x = 0 To 15
            BuildingColorDRPDWN.Items(x) = Colors(x)
        Next

        For x = 0 To 15
            ItemDetails.DetailComboBox.Items(x) = Colors(x)
        Next


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles BuildingNameTXB.TextChanged
        Text = BuildingNameTXB.Text
        MainWindow.CurrentElevator.Name = BuildingNameTXB.Text
    End Sub

    Private Sub AddBTN_Click(sender As Object, e As EventArgs) Handles AddBTN.Click
        'add
        AddMode = True
    End Sub

    Private Sub ModBTN_Click(sender As Object, e As EventArgs) Handles ModBTN.Click
        'Modify
        AddMode = False

    End Sub

    Private Sub RemoveBTN_Click(sender As Object, e As EventArgs) Handles RemoveBTN.Click
        'delete
    End Sub

    Private Sub BoldBox_CheckedChanged(sender As Object, e As EventArgs) Handles BoldBox.CheckedChanged
        MainWindow.CurrentElevator.NameBold = BoldBox.Checked
    End Sub

    Private Sub ItalicBox_CheckedChanged(sender As Object, e As EventArgs) Handles ItalicBox.CheckedChanged
        MainWindow.CurrentElevator.NameItalic = ItalicBox.Checked
    End Sub

    Private Sub UnderlineBox_CheckedChanged(sender As Object, e As EventArgs) Handles UnderlineBox.CheckedChanged
        MainWindow.CurrentElevator.NameUnderline = UnderlineBox.Checked
    End Sub

    Private Sub BuildingColorDRPDWN_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BuildingColorDRPDWN.SelectedIndexChanged
        MainWindow.CurrentElevator.NameColor = Colors(BuildingColorDRPDWN.SelectedIndex)
    End Sub



End Class