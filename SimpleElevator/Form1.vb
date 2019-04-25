Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Shown

        Threading.Thread.Sleep(3000)
        MainWindow.Show()
        Me.Hide()

    End Sub
End Class
