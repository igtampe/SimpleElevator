Public Class ItemDetails

    Sub MeLoad() Handles Me.Load

    End Sub

    Private Sub OKBTN_Click(sender As Object, e As EventArgs) Handles OKBTN.Click
        If Summary.AddMode Then
            MainWindow.AddFloorToElevator(FloorNameTXB.Text, HoverTXB.Text, DetailComboBox.Text, XTXB.Text, YTXB.Text, ZTXB.Text)
        Else
            MainWindow.ModFloorFromElevator(Summary.ListView.SelectedIndices(0), FloorNameTXB.Text, HoverTXB.Text, DetailComboBox.Text, XTXB.Text, YTXB.Text, ZTXB.Text)
        End If
        Close()
    End Sub

    Private Sub CancelBTN_Click(sender As Object, e As EventArgs) Handles CancelBTN.Click
        Close()
    End Sub
End Class