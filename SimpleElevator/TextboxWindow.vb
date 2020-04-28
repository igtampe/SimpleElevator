''' <summary>A tiny textbox window</summary>
Public Class TextboxWindow

    '----------------------------------------------------[Initialization]----------------------------------------------------
    Public Sub New(Title As String, MDIParent As Form)
        InitializeComponent()
        Text = Title
        Me.MdiParent = MDIParent
    End Sub

End Class