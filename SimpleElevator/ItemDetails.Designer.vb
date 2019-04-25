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
        Me.DetailComboBox = New System.Windows.Forms.ComboBox()
        Me.OKBTN = New System.Windows.Forms.Button()
        Me.CancelBTN = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'FloorNameTXB
        '
        Me.FloorNameTXB.Font = New System.Drawing.Font("Arial Narrow", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FloorNameTXB.Location = New System.Drawing.Point(12, 12)
        Me.FloorNameTXB.Name = "FloorNameTXB"
        Me.FloorNameTXB.Size = New System.Drawing.Size(315, 118)
        Me.FloorNameTXB.TabIndex = 1
        Me.FloorNameTXB.Text = "[25]"
        Me.FloorNameTXB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Coords:"
        '
        'XTXB
        '
        Me.XTXB.Location = New System.Drawing.Point(58, 140)
        Me.XTXB.Name = "XTXB"
        Me.XTXB.Size = New System.Drawing.Size(31, 20)
        Me.XTXB.TabIndex = 1
        Me.XTXB.Text = "~"
        Me.XTXB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Tooltip:"
        '
        'HoverTXB
        '
        Me.HoverTXB.Location = New System.Drawing.Point(58, 169)
        Me.HoverTXB.Name = "HoverTXB"
        Me.HoverTXB.Size = New System.Drawing.Size(269, 20)
        Me.HoverTXB.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(169, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Color:"
        '
        'YTXB
        '
        Me.YTXB.Location = New System.Drawing.Point(95, 140)
        Me.YTXB.Name = "YTXB"
        Me.YTXB.Size = New System.Drawing.Size(31, 20)
        Me.YTXB.TabIndex = 1
        Me.YTXB.Text = "~"
        Me.YTXB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ZTXB
        '
        Me.ZTXB.Location = New System.Drawing.Point(132, 140)
        Me.ZTXB.Name = "ZTXB"
        Me.ZTXB.Size = New System.Drawing.Size(31, 20)
        Me.ZTXB.TabIndex = 1
        Me.ZTXB.Text = "~"
        Me.ZTXB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DetailComboBox
        '
        Me.DetailComboBox.FormattingEnabled = True
        Me.DetailComboBox.Location = New System.Drawing.Point(209, 139)
        Me.DetailComboBox.Name = "DetailComboBox"
        Me.DetailComboBox.Size = New System.Drawing.Size(118, 21)
        Me.DetailComboBox.TabIndex = 2
        '
        'OKBTN
        '
        Me.OKBTN.Location = New System.Drawing.Point(171, 195)
        Me.OKBTN.Name = "OKBTN"
        Me.OKBTN.Size = New System.Drawing.Size(75, 23)
        Me.OKBTN.TabIndex = 3
        Me.OKBTN.Text = "OK"
        Me.OKBTN.UseVisualStyleBackColor = True
        '
        'CancelBTN
        '
        Me.CancelBTN.Location = New System.Drawing.Point(252, 195)
        Me.CancelBTN.Name = "CancelBTN"
        Me.CancelBTN.Size = New System.Drawing.Size(75, 23)
        Me.CancelBTN.TabIndex = 4
        Me.CancelBTN.Text = "Cancel"
        Me.CancelBTN.UseVisualStyleBackColor = True
        '
        'ItemDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 229)
        Me.Controls.Add(Me.CancelBTN)
        Me.Controls.Add(Me.OKBTN)
        Me.Controls.Add(Me.DetailComboBox)
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
    Friend WithEvents DetailComboBox As ComboBox
    Friend WithEvents OKBTN As Button
    Friend WithEvents CancelBTN As Button
End Class
