<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ItemDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ItemDetails))
        Me.FloorNameTXB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.XTXB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.HoverTXB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.YTXB = New System.Windows.Forms.TextBox()
        Me.ZTXB = New System.Windows.Forms.TextBox()
        Me.ColorCMBBox = New System.Windows.Forms.ComboBox()
        Me.OKBTN = New System.Windows.Forms.Button()
        Me.CancelBTN = New System.Windows.Forms.Button()
        Me.CoordModeRbutton = New System.Windows.Forms.RadioButton()
        Me.CommandModeRButton = New System.Windows.Forms.RadioButton()
        Me.CommandTXB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'FloorNameTXB
        '
        Me.FloorNameTXB.Font = New System.Drawing.Font("Arial Narrow", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FloorNameTXB.Location = New System.Drawing.Point(12, 12)
        Me.FloorNameTXB.Name = "FloorNameTXB"
        Me.FloorNameTXB.Size = New System.Drawing.Size(315, 118)
        Me.FloorNameTXB.TabIndex = 1
        Me.FloorNameTXB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Coords:"
        '
        'XTXB
        '
        Me.XTXB.Location = New System.Drawing.Point(57, 164)
        Me.XTXB.Name = "XTXB"
        Me.XTXB.Size = New System.Drawing.Size(31, 20)
        Me.XTXB.TabIndex = 2
        Me.XTXB.Text = "~"
        Me.XTXB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 220)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Tooltip:"
        '
        'HoverTXB
        '
        Me.HoverTXB.Location = New System.Drawing.Point(57, 217)
        Me.HoverTXB.Name = "HoverTXB"
        Me.HoverTXB.Size = New System.Drawing.Size(270, 20)
        Me.HoverTXB.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(168, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Color:"
        '
        'YTXB
        '
        Me.YTXB.Location = New System.Drawing.Point(94, 164)
        Me.YTXB.Name = "YTXB"
        Me.YTXB.Size = New System.Drawing.Size(31, 20)
        Me.YTXB.TabIndex = 3
        Me.YTXB.Text = "~"
        Me.YTXB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ZTXB
        '
        Me.ZTXB.Location = New System.Drawing.Point(131, 164)
        Me.ZTXB.Name = "ZTXB"
        Me.ZTXB.Size = New System.Drawing.Size(31, 20)
        Me.ZTXB.TabIndex = 4
        Me.ZTXB.Text = "~"
        Me.ZTXB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColorCMBBox
        '
        Me.ColorCMBBox.FormattingEnabled = True
        Me.ColorCMBBox.Location = New System.Drawing.Point(208, 164)
        Me.ColorCMBBox.Name = "ColorCMBBox"
        Me.ColorCMBBox.Size = New System.Drawing.Size(118, 21)
        Me.ColorCMBBox.TabIndex = 5
        '
        'OKBTN
        '
        Me.OKBTN.Location = New System.Drawing.Point(171, 245)
        Me.OKBTN.Name = "OKBTN"
        Me.OKBTN.Size = New System.Drawing.Size(75, 23)
        Me.OKBTN.TabIndex = 8
        Me.OKBTN.Text = "OK"
        Me.OKBTN.UseVisualStyleBackColor = True
        '
        'CancelBTN
        '
        Me.CancelBTN.Location = New System.Drawing.Point(252, 245)
        Me.CancelBTN.Name = "CancelBTN"
        Me.CancelBTN.Size = New System.Drawing.Size(75, 23)
        Me.CancelBTN.TabIndex = 9
        Me.CancelBTN.Text = "Cancel"
        Me.CancelBTN.UseVisualStyleBackColor = True
        '
        'CoordModeRbutton
        '
        Me.CoordModeRbutton.AutoSize = True
        Me.CoordModeRbutton.Location = New System.Drawing.Point(15, 136)
        Me.CoordModeRbutton.Name = "CoordModeRbutton"
        Me.CoordModeRbutton.Size = New System.Drawing.Size(73, 17)
        Me.CoordModeRbutton.TabIndex = 10
        Me.CoordModeRbutton.TabStop = True
        Me.CoordModeRbutton.Text = "By Coords"
        Me.CoordModeRbutton.UseVisualStyleBackColor = True
        '
        'CommandModeRButton
        '
        Me.CommandModeRButton.AutoSize = True
        Me.CommandModeRButton.Location = New System.Drawing.Point(95, 136)
        Me.CommandModeRButton.Name = "CommandModeRButton"
        Me.CommandModeRButton.Size = New System.Drawing.Size(87, 17)
        Me.CommandModeRButton.TabIndex = 11
        Me.CommandModeRButton.TabStop = True
        Me.CommandModeRButton.Text = "By Command"
        Me.CommandModeRButton.UseVisualStyleBackColor = True
        '
        'CommandTXB
        '
        Me.CommandTXB.Enabled = False
        Me.CommandTXB.Location = New System.Drawing.Point(74, 191)
        Me.CommandTXB.Name = "CommandTXB"
        Me.CommandTXB.Size = New System.Drawing.Size(253, 20)
        Me.CommandTXB.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 194)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Command: "
        '
        'ItemDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 280)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CommandTXB)
        Me.Controls.Add(Me.CommandModeRButton)
        Me.Controls.Add(Me.CoordModeRbutton)
        Me.Controls.Add(Me.CancelBTN)
        Me.Controls.Add(Me.OKBTN)
        Me.Controls.Add(Me.ColorCMBBox)
        Me.Controls.Add(Me.HoverTXB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ZTXB)
        Me.Controls.Add(Me.YTXB)
        Me.Controls.Add(Me.XTXB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.FloorNameTXB)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ItemDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FloorNameTXB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents XTXB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents HoverTXB As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents YTXB As TextBox
    Friend WithEvents ZTXB As TextBox
    Friend WithEvents ColorCMBBox As ComboBox
    Friend WithEvents OKBTN As Button
    Friend WithEvents CancelBTN As Button
    Friend WithEvents CoordModeRbutton As RadioButton
    Friend WithEvents CommandModeRButton As RadioButton
    Friend WithEvents CommandTXB As TextBox
    Friend WithEvents Label1 As Label
End Class
