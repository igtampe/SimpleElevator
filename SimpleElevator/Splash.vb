''' <summary>Starts the app and shows the splash.</summary>
Public Class Splash
    Private Sub ItsSplashTime() Handles Me.Shown
        Threading.Thread.Sleep(2000)
        MainWindow.Show()
        Hide()
    End Sub
End Class
