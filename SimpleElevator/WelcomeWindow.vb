Public Class WelcomeWindow

    '----------------------------------------------------[Variables]----------------------------------------------------

    Public MyResult As DialogResult

    '----------------------------------------------------[Initialization]----------------------------------------------------

    Public Sub New()
        InitializeComponent()
    End Sub

    '----------------------------------------------------[Buttons]----------------------------------------------------

    Private Sub Nevermind() Handles QuitTime.Click
        Splash.Close()
    End Sub

    Private Sub NewFile() Handles NewElevator.Click
        MyResult = DialogResult.No
        Close()
    End Sub

    Private Sub OpenFile() Handles OpenElevator.Click
        MyResult = DialogResult.Yes
        Close()
    End Sub

End Class