Public Class WelcomeWindow
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'new
        MainWindow.WelcomeResult = DialogResult.No
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'OpenDialog
        MainWindow.welcomeresult = DialogResult.Yes
        Close()
    End Sub
End Class