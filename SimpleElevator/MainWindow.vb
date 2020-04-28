Imports System.IO

''' <summary>Main window class</summary>
Public Class MainWindow

    '----------------------------------------------------[Variables]----------------------------------------------------

    Public WelcomeResult As DialogResult
    Public MySummaryWindows As ArrayList = New ArrayList

    '----------------------------------------------------[Initialization]----------------------------------------------------

    Private Sub ShowTime() Handles Me.Shown

        If My.Application.CommandLineArgs.Count = 1 Then
            OpenCommandlineFile(My.Application.CommandLineArgs(0))
            Exit Sub
        End If

        Dim MyWelcomeWindow As WelcomeWindow = New WelcomeWindow()
        MyWelcomeWindow.ShowDialog()

        Select Case MyWelcomeWindow.MyResult
            Case DialogResult.Yes
                OpenFile()
            Case DialogResult.No
                NewFile()
        End Select

    End Sub

    '----------------------------------------------------[Buttons]----------------------------------------------------

    Private Sub NewFile() Handles NewToolStripMenuItem.Click

        Dim NewSummaryWindow = New Summary(New CBElevator(), Me)
        NewSummaryWindow.Show()
        MySummaryWindows.Add(NewSummaryWindow)

    End Sub

    Private Sub SaveAll() Handles SaveAllToolStripMenuItem.Click
        For Each SummaryWindow As Summary In MySummaryWindows
            SummaryWindow.Save()
        Next
    End Sub

    Sub OpenCommandlineFile(OpeneFile As String)

        If Not File.Exists(OpeneFile) Then
            MsgBox("hoo hoo ha ha hee hee, the file does not exists.", MsgBoxStyle.Critical, "n o")
            Application.Exit()
        End If

        Dim NewSummaryWindow = New Summary(New CBElevator(OpeneFile), Me, OpeneFile)
        NewSummaryWindow.Show()
        MySummaryWindows.Add(NewSummaryWindow)

    End Sub

    Sub OpenFile() Handles OpenToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then OpenCommandlineFile(OpenFileDialog1.FileName)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub ShowAbout() Handles AboutToolStripMenuItem.Click
        About.ShowDialog()
    End Sub

    '----------------------------------------------------[Other Operations]----------------------------------------------------

    Private Sub ClosingTime() Handles Me.Closing
        Splash.Close()
    End Sub

End Class