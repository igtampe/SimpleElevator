Public Class AutoAdd
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MinY As Integer
        Dim MaxY As Integer
        Dim StartFloor As Integer
        Dim color As String
        Dim YStep As Integer

        Dim FloorCount As Integer

        Dim CurrentFloor As Integer
        Dim CurrentY As Integer

        MinY = StartYBox.Value
        MaxY = EndYBox.Value
        StartFloor = StartFloorBox.Value
        color = ColorComboBox.Text
        YStep = SecondYTXB.Value - StartYBox.Value





        If YStep = 0 Then
            MsgBox("haha real funny you want me to step up by 0 real nice do you really want me to spend an ETERNITY CALCULATING THIS STUFF? You're lucky I'm programed to check this stuff before doing anything jesu cristi", MsgBoxStyle.Critical, "really?")
            Exit Sub
        End If


        CurrentFloor = StartFloor
        CurrentY = MinY
        FloorCount = 0
        Do
            If CurrentY = MaxY Then Exit Do
            If CurrentY > MaxY Then
                MsgBox("This isn't adding up: " & vbNewLine & vbNewLine & "CurrentY: " & CurrentY & vbNewLine & "MaxY: " & MaxY & vbNewLine & "Current Floor: " & CurrentFloor & vbNewLine & vbNewLine & "Check your step or your values and try again", MsgBoxStyle.Critical, "oh no")
                Exit Sub
            End If

            CurrentY = CurrentY + YStep
            CurrentFloor = CurrentFloor + 1
            FloorCount = FloorCount + 1

        Loop

        Select Case MsgBox("Add floors " & StartFloor & " to " & CurrentFloor & " (" & FloorCount & " Floors) to the current elevator?", 32 + 4, "Do?")
            Case MsgBoxResult.Yes
                CurrentFloor = StartFloor
                CurrentY = MinY
                FloorCount = 0
                Do


                    MainWindow.AddFloorToElevator("[" & CurrentFloor & "] ", "", color, "~", CurrentY, "~")


                    If CurrentY = MaxY Then Exit Do
                    If CurrentY > MaxY Then
                        MsgBox("This isn't adding up: " & vbNewLine & vbNewLine & "CurrentY: " & CurrentY & vbNewLine & "MaxY: " & MaxY & vbNewLine & "Current Floor: " & CurrentFloor & vbNewLine & vbNewLine & "Check your step or your values and try again", MsgBoxStyle.Critical, "oh no")
                        Exit Sub
                    End If


                    CurrentY = CurrentY + YStep
                    CurrentFloor = CurrentFloor + 1
                    FloorCount = FloorCount + 1

                Loop

                MsgBox("Successfully added " & FloorCount & " Floors to the current elevator.", MsgBoxStyle.Information, "o k")
                Close()
            Case MsgBoxResult.No
                Exit Sub
            Case Else
                Exit Sub
        End Select







    End Sub
End Class