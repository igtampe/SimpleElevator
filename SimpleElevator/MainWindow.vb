Public Class MainWindow

    Public Structure Floors
        Public FloorText As String
        Public FloorTextBold As Boolean
        Public FloorTextItalic As Boolean
        Public FloorTextUnderline As Boolean
        Public HoverText As String
        Public Color As String
        Public TPCommand As String
    End Structure

    Public Structure Elevator
        Public Name As String
        Public NameColor As String
        Public NameBold As Boolean
        Public NameItalic As Boolean
        Public NameUnderline As Boolean
        Public Floor() As Floors
    End Structure
    Public ExportWindow As TextboxWindow
    Public ExportText As String

    Public PreviewWindow As TextboxWindow
    Public CurrentElevator As Elevator
    Public FileModified As Boolean

    Public WelcomeResult As DialogResult
    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles Me.Closing
        Form1.Close()
    End Sub

    Private Sub MainWindow_Load_1(sender As Object, e As EventArgs) Handles Me.Shown

        WelcomeWindow.ShowDialog()

        Select Case WelcomeResult
            Case DialogResult.Yes
                'open
                MsgBox("OK I will now open")
            Case DialogResult.No
                MsgBox("OK I will not open")
        End Select

    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        About.ShowDialog()
    End Sub

    Sub OpenFile()

    End Sub

    Sub NewFile()
        CurrentElevator = Nothing
        ExportText = ""
        ExportWindow.RichTextBox1.Text = ""
        FileModified = False
    End Sub

    Private Sub ExportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportToolStripMenuItem.Click
        ExportWindow.Show()
        ExportWindow.RichTextBox1.Text = +vbNewLine & vbNewLine & "This text has been copied to the clipboard."
        My.Computer.Clipboard.SetText(ExportText)
    End Sub


End Class