<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AutoAdd
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EndYBox = New System.Windows.Forms.NumericUpDown()
        Me.StartYBox = New System.Windows.Forms.NumericUpDown()
        Me.StartFloorBox = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.OKBTN = New System.Windows.Forms.Button()
        Me.CancelBTN = New System.Windows.Forms.Button()
        Me.ColorComboBox = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SecondYTXB = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.EndYBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StartYBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StartFloorBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SecondYTXB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Start Y Level"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "End Y Level"
        '
        'EndYBox
        '
        Me.EndYBox.Location = New System.Drawing.Point(86, 59)
        Me.EndYBox.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.EndYBox.Name = "EndYBox"
        Me.EndYBox.Size = New System.Drawing.Size(120, 20)
        Me.EndYBox.TabIndex = 3
        '
        'StartYBox
        '
        Me.StartYBox.Location = New System.Drawing.Point(86, 7)
        Me.StartYBox.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.StartYBox.Name = "StartYBox"
        Me.StartYBox.Size = New System.Drawing.Size(120, 20)
        Me.StartYBox.TabIndex = 1
        '
        'StartFloorBox
        '
        Me.StartFloorBox.Location = New System.Drawing.Point(86, 85)
        Me.StartFloorBox.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.StartFloorBox.Name = "StartFloorBox"
        Me.StartFloorBox.Size = New System.Drawing.Size(120, 20)
        Me.StartFloorBox.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Start Floor #"
        '
        'OKBTN
        '
        Me.OKBTN.Location = New System.Drawing.Point(52, 138)
        Me.OKBTN.Name = "OKBTN"
        Me.OKBTN.Size = New System.Drawing.Size(75, 23)
        Me.OKBTN.TabIndex = 6
        Me.OKBTN.Text = "OK"
        Me.OKBTN.UseVisualStyleBackColor = True
        '
        'CancelBTN
        '
        Me.CancelBTN.Location = New System.Drawing.Point(133, 138)
        Me.CancelBTN.Name = "CancelBTN"
        Me.CancelBTN.Size = New System.Drawing.Size(75, 23)
        Me.CancelBTN.TabIndex = 7
        Me.CancelBTN.Text = "Cancel"
        Me.CancelBTN.UseVisualStyleBackColor = True
        '
        'ColorComboBox
        '
        Me.ColorComboBox.FormattingEnabled = True
        Me.ColorComboBox.Location = New System.Drawing.Point(86, 111)
        Me.ColorComboBox.Name = "ColorComboBox"
        Me.ColorComboBox.Size = New System.Drawing.Size(120, 21)
        Me.ColorComboBox.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(49, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Color"
        '
        'SecondYTXB
        '
        Me.SecondYTXB.Location = New System.Drawing.Point(86, 33)
        Me.SecondYTXB.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.SecondYTXB.Name = "SecondYTXB"
        Me.SecondYTXB.Size = New System.Drawing.Size(120, 20)
        Me.SecondYTXB.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "2nd Y Level"
        '
        'AutoAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(218, 172)
        Me.Controls.Add(Me.ColorComboBox)
        Me.Controls.Add(Me.CancelBTN)
        Me.Controls.Add(Me.OKBTN)
        Me.Controls.Add(Me.StartYBox)
        Me.Controls.Add(Me.StartFloorBox)
        Me.Controls.Add(Me.SecondYTXB)
        Me.Controls.Add(Me.EndYBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AutoAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AutoAdd"
        CType(Me.EndYBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StartYBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StartFloorBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SecondYTXB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents EndYBox As NumericUpDown
    Friend WithEvents StartYBox As NumericUpDown
    Friend WithEvents StartFloorBox As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents OKBTN As Button
    Friend WithEvents CancelBTN As Button
    Friend WithEvents ColorComboBox As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents SecondYTXB As NumericUpDown
    Friend WithEvents Label6 As Label
End Class
