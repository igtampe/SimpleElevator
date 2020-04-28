Public Class ItemDetails

    Public MyHead As Summary
    Public myFloor As Floor
    Public myIndex As Integer

    'For new
    Public Sub New(ByRef HeadForm As Summary, ByRef MDIParent As Form)
        InitializeComponent()

        MyHead = HeadForm
        myIndex = -1

        Me.MdiParent = MDIParent
        Text = "New Floor"

        ColorCMBBox.Items.Clear()
        For Each MCColor As MCColor In MCColor.Dictionary
            ColorCMBBox.Items.Add(MCColor.Name)
        Next

        CoordModeRbutton.Checked = True

    End Sub

    'For details
    Public Sub New(ByRef HeadForm As Summary, ByRef MDIParent As Form, MyFloor As Floor, Index As Integer)
        Me.New(HeadForm, MDIParent)

        FloorNameTXB.Text = MyFloor.FloorText
        HoverTXB.Text = MyFloor.HoverText
        ColorCMBBox.Text = MCColor.ColorStringToName(MyFloor.Color)
        myIndex = Index

        Dim Coords As String() = MyFloor.GetCoords
        If String.IsNullOrWhiteSpace(Coords(0)) Then
            'OK Command mode
            CoordModeRbutton.Checked = False
            CommandModeRButton.Checked = True
            CommandTXB.Text = MyFloor.GetCommand
        Else
            'ok we're good
            XTXB.Text = Coords(0)
            YTXB.Text = Coords(1)
            ZTXB.Text = Coords(2)
        End If

    End Sub

    Private Sub OKDoIt() Handles OKBTN.Click

        If CoordModeRbutton.Checked Then
            'Coord Mode
            myFloor = New Floor(FloorNameTXB.Text, HoverTXB.Text, MCColor.ColorNameToColorString(ColorCMBBox.Text), XTXB.Text, YTXB.Text, ZTXB.Text)
        Else
            'Command mode
            myFloor = New Floor(FloorNameTXB.Text, HoverTXB.Text, MCColor.ColorNameToColorString(ColorCMBBox.Text), CommandTXB.Text)
        End If

        If myIndex = -1 Then
            'add
            MyHead.myElevator.AddFloor(myFloor)
        Else
            'modify
            MyHead.myElevator.UpdateFloor(myIndex, myFloor)
        End If

        MyHead.PopulateListview()
        MyHead.FlagAsModified()
        Close()
    End Sub

    Private Sub Nevermind() Handles CancelBTN.Click
        Close()
    End Sub

    Private Sub CoordModeEnabled() Handles CoordModeRbutton.CheckedChanged
        If CoordModeRbutton.Checked Then
            SwitchToCoordMode()
        End If
    End Sub

    Private Sub CommandModeEnabled() Handles CommandModeRButton.CheckedChanged
        If CommandModeRButton.Checked Then
            SwitchToCommandMode()
        End If
    End Sub

    ''' <summary>Switches the form to Coords mode</summary>
    Private Sub SwitchToCoordMode()
        CommandTXB.Enabled = False
        CommandTXB.TabStop = False

        XTXB.Enabled = True
        XTXB.TabStop = True
        YTXB.Enabled = True
        YTXB.TabStop = True
        ZTXB.Enabled = True
        ZTXB.TabStop = True

        XTXB.Text = "~"
        YTXB.Text = "~"
        ZTXB.Text = "~"

        CommandTXB.Text = ""
    End Sub

    ''' <summary>Switches the form to CommandsMode</summary>
    Private Sub SwitchToCommandMode()
        CommandTXB.Enabled = True
        CommandTXB.TabStop = True

        XTXB.Enabled = False
        XTXB.TabStop = False
        YTXB.Enabled = False
        YTXB.TabStop = False
        ZTXB.Enabled = False
        ZTXB.TabStop = False

        XTXB.Text = ""
        YTXB.Text = ""
        ZTXB.Text = ""

        CommandTXB.Text = ""
    End Sub

End Class