''' <summary>Handles creation of arraylist of floors to automatically add to a CBElevator</summary>
Public Class AutoAdd

    '----------------------------------------------------[Variables]----------------------------------------------------

    ''' <summary>My Head Summary Window</summary>
    Public MyHead As Summary

    '----------------------------------------------------[Initialization]----------------------------------------------------

    Public Sub New(ByRef MyHead As Summary, ByRef mdiparent As Form)
        InitializeComponent()

        Me.MyHead = MyHead
        Me.MdiParent = mdiparent

        For Each MCColor As MCColor In MCColor.Dictionary
            ColorComboBox.Items.Add(MCColor.Name)
        Next

    End Sub

    '----------------------------------------------------[Buttons]----------------------------------------------------

    Private Sub Nevermind() Handles CancelBTN.Click
        Close()
    End Sub

    Private Sub OKAdd() Handles OKBTN.Click

        'Variables
        Dim MinY As Integer = StartYBox.Value
        Dim MaxY As Integer = EndYBox.Value
        Dim StartFloor As Integer = StartFloorBox.Value
        Dim color As String = MCColor.ColorNameToColorString(ColorComboBox.Text)
        Dim YStep As Integer = SecondYTXB.Value - StartYBox.Value

        Dim FloorCount As Integer = 0

        Dim CurrentFloor As Integer = StartFloor
        Dim CurrentY As Integer = MinY

        If YStep = 0 Then
            MsgBox("haha real funny you want me to step up by 0 real nice do you really want me to spend an ETERNITY CALCULATING THIS STUFF? You're lucky I'm programed to check this stuff before doing anything jesu cristi", MsgBoxStyle.Critical, "really?")
            Exit Sub
        End If

        Do
            If CurrentY = MaxY Then Exit Do
            If CurrentY > MaxY Then
                MsgBox("This isn't adding up: " & vbNewLine & vbNewLine & "CurrentY: " & CurrentY & vbNewLine & "MaxY: " & MaxY & vbNewLine & "Current Floor: " & CurrentFloor & vbNewLine & vbNewLine & "Check your step or your values and try again", MsgBoxStyle.Critical, "oh no")
                Exit Sub
            End If

            CurrentY += YStep
            CurrentFloor += 1
            FloorCount += 1
        Loop

        If MsgBox("Add floors " & StartFloor & " to " & CurrentFloor & " (" & FloorCount & " Floors) to the current elevator?", 32 + 4, "Do?") = MsgBoxResult.Yes Then

            CurrentFloor = StartFloor
            CurrentY = MinY
            FloorCount = 0
            Do

                MyHead.myElevator.AddFloor(New Floor("[" & CurrentFloor & "] ", "", color, "~", CurrentY, "~"))

                If CurrentY = MaxY Then Exit Do
                CurrentY += YStep
                CurrentFloor += 1
                FloorCount += 1

            Loop

            MyHead.PopulateListview()
            MyHead.FlagAsModified()

            Close()
        End If

    End Sub
End Class