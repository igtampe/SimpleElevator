<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Summary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Summary))
        Me.ListView = New System.Windows.Forms.ListView()
        Me.FloorName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FloorCoordinates = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FloorHover = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FloorColor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BuildingNameTXB = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.AddBTN = New System.Windows.Forms.Button()
        Me.ModBTN = New System.Windows.Forms.Button()
        Me.RemoveBTN = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BuildingColorDRPDWN = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ClearBTN = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView
        '
        Me.ListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.FloorName, Me.FloorCoordinates, Me.FloorHover, Me.FloorColor})
        Me.ListView.Location = New System.Drawing.Point(7, 19)
        Me.ListView.Name = "ListView"
        Me.ListView.Size = New System.Drawing.Size(379, 283)
        Me.ListView.TabIndex = 0
        Me.ListView.UseCompatibleStateImageBehavior = False
        Me.ListView.View = System.Windows.Forms.View.Details
        '
        'FloorName
        '
        Me.FloorName.Text = "Floor"
        Me.FloorName.Width = 85
        '
        'FloorCoordinates
        '
        Me.FloorCoordinates.Text = "Coordinates"
        Me.FloorCoordinates.Width = 77
        '
        'FloorHover
        '
        Me.FloorHover.Text = "Hover Text"
        Me.FloorHover.Width = 121
        '
        'FloorColor
        '
        Me.FloorColor.Text = "Color"
        Me.FloorColor.Width = 90
        '
        'BuildingNameTXB
        '
        Me.BuildingNameTXB.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuildingNameTXB.Location = New System.Drawing.Point(6, 19)
        Me.BuildingNameTXB.Name = "BuildingNameTXB"
        Me.BuildingNameTXB.Size = New System.Drawing.Size(379, 38)
        Me.BuildingNameTXB.TabIndex = 1
        Me.BuildingNameTXB.Text = "Building Name"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ClearBTN)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.AddBTN)
        Me.GroupBox1.Controls.Add(Me.ModBTN)
        Me.GroupBox1.Controls.Add(Me.RemoveBTN)
        Me.GroupBox1.Controls.Add(Me.ListView)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 115)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(392, 340)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Floors"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(7, 308)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Auto Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AddBTN
        '
        Me.AddBTN.Location = New System.Drawing.Point(304, 308)
        Me.AddBTN.Name = "AddBTN"
        Me.AddBTN.Size = New System.Drawing.Size(23, 23)
        Me.AddBTN.TabIndex = 3
        Me.AddBTN.Text = "+"
        Me.ToolTip1.SetToolTip(Me.AddBTN, "Add a Floor")
        Me.AddBTN.UseVisualStyleBackColor = True
        '
        'ModBTN
        '
        Me.ModBTN.Location = New System.Drawing.Point(333, 308)
        Me.ModBTN.Name = "ModBTN"
        Me.ModBTN.Size = New System.Drawing.Size(23, 23)
        Me.ModBTN.TabIndex = 2
        Me.ModBTN.Text = "#"
        Me.ToolTip1.SetToolTip(Me.ModBTN, "Modify a Floor")
        Me.ModBTN.UseVisualStyleBackColor = True
        '
        'RemoveBTN
        '
        Me.RemoveBTN.Location = New System.Drawing.Point(362, 308)
        Me.RemoveBTN.Name = "RemoveBTN"
        Me.RemoveBTN.Size = New System.Drawing.Size(23, 23)
        Me.RemoveBTN.TabIndex = 1
        Me.RemoveBTN.Text = "-"
        Me.ToolTip1.SetToolTip(Me.RemoveBTN, "Delete a Floor")
        Me.RemoveBTN.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BuildingColorDRPDWN)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.BuildingNameTXB)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(392, 97)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Header Information"
        '
        'BuildingColorDRPDWN
        '
        Me.BuildingColorDRPDWN.FormattingEnabled = True
        Me.BuildingColorDRPDWN.Location = New System.Drawing.Point(46, 63)
        Me.BuildingColorDRPDWN.Name = "BuildingColorDRPDWN"
        Me.BuildingColorDRPDWN.Size = New System.Drawing.Size(121, 21)
        Me.BuildingColorDRPDWN.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Color:"
        '
        'ClearBTN
        '
        Me.ClearBTN.Location = New System.Drawing.Point(275, 308)
        Me.ClearBTN.Name = "ClearBTN"
        Me.ClearBTN.Size = New System.Drawing.Size(23, 23)
        Me.ClearBTN.TabIndex = 5
        Me.ClearBTN.Text = "*"
        Me.ToolTip1.SetToolTip(Me.ClearBTN, "Clear all floors")
        Me.ClearBTN.UseVisualStyleBackColor = True
        '
        'Summary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 464)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(50, 50)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(429, 502)
        Me.MinimumSize = New System.Drawing.Size(429, 502)
        Me.Name = "Summary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Building Name"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListView As ListView
    Friend WithEvents FloorName As ColumnHeader
    Friend WithEvents FloorCoordinates As ColumnHeader
    Friend WithEvents FloorColor As ColumnHeader
    Friend WithEvents FloorHover As ColumnHeader
    Friend WithEvents BuildingNameTXB As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents AddBTN As Button
    Friend WithEvents ModBTN As Button
    Friend WithEvents RemoveBTN As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BuildingColorDRPDWN As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Button1 As Button
    Friend WithEvents ClearBTN As Button
End Class
