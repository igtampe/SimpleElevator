<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WelcomeWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WelcomeWindow))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NewElevator = New System.Windows.Forms.Button()
        Me.OpenElevator = New System.Windows.Forms.Button()
        Me.QuitTime = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(315, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome to SimpleElevator!"
        '
        'NewElevator
        '
        Me.NewElevator.BackColor = System.Drawing.Color.White
        Me.NewElevator.BackgroundImage = Global.SimpleElevator.My.Resources.Resources.File
        Me.NewElevator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.NewElevator.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewElevator.Location = New System.Drawing.Point(24, 59)
        Me.NewElevator.Name = "NewElevator"
        Me.NewElevator.Size = New System.Drawing.Size(120, 120)
        Me.NewElevator.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.NewElevator, "Create a new elevator")
        Me.NewElevator.UseVisualStyleBackColor = False
        '
        'OpenElevator
        '
        Me.OpenElevator.BackColor = System.Drawing.Color.White
        Me.OpenElevator.BackgroundImage = Global.SimpleElevator.My.Resources.Resources.OpenedFolder
        Me.OpenElevator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.OpenElevator.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.OpenElevator.Location = New System.Drawing.Point(177, 59)
        Me.OpenElevator.Name = "OpenElevator"
        Me.OpenElevator.Size = New System.Drawing.Size(120, 120)
        Me.OpenElevator.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.OpenElevator, "Open a previously saved elevator")
        Me.OpenElevator.UseVisualStyleBackColor = False
        '
        'QuitTime
        '
        Me.QuitTime.BackColor = System.Drawing.Color.White
        Me.QuitTime.BackgroundImage = Global.SimpleElevator.My.Resources.Resources.door_opened
        Me.QuitTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.QuitTime.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.QuitTime.Location = New System.Drawing.Point(328, 59)
        Me.QuitTime.Name = "QuitTime"
        Me.QuitTime.Size = New System.Drawing.Size(120, 120)
        Me.QuitTime.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.QuitTime, "Exit")
        Me.QuitTime.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(24, 182)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "New Elevator"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(174, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Open Elevator"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(325, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 23)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Quit SimpleElevator"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'WelcomeWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SimpleElevator.My.Resources.Resources.WelcomeBack
        Me.ClientSize = New System.Drawing.Size(473, 221)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.QuitTime)
        Me.Controls.Add(Me.OpenElevator)
        Me.Controls.Add(Me.NewElevator)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "WelcomeWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quick Start"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents NewElevator As Button
    Friend WithEvents OpenElevator As Button
    Friend WithEvents QuitTime As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
