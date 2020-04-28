''' <summary>Holds a Minecraft Command Block Elevator</summary>
Public Class CBElevator

    '----------------------------------------------------[Variables]----------------------------------------------------

    Public Name As String
    Public NameColor As MCColor
    Private ReadOnly Floors As ArrayList

    '----------------------------------------------------[Initialization]----------------------------------------------------

    ''' <summary>Constructs an empty elevator</summary>
    Public Sub New()
        Floors = New ArrayList
        Name = "Building Name"
        NameColor = MCColor.WHITE
    End Sub

    ''' <summary>Constructs an elevator using the specified file</summary>
    Public Sub New(Filename As String)
        Me.New

        'Open file
        FileOpen(1, Filename, OpenMode.Input)

        'Get name and color
        Dim TempSplit() As String = LineInput(1).Split("`")
        Name = TempSplit(0)
        NameColor = MCColor.ColorStringToMCColor(TempSplit(1))

        'Get the floors
        While Not EOF(1)
            TempSplit = LineInput(1).Split("`")
            If TempSplit.Count = 7 Then
                If String.IsNullOrWhiteSpace(TempSplit(3)) Then
                    'Command Mode Floor
                    AddFloor(New Floor(TempSplit(0), TempSplit(1), TempSplit(2), TempSplit(6)))
                Else
                    'Coordinate Mode Floor
                    AddFloor(New Floor(TempSplit(0), TempSplit(1), TempSplit(2), TempSplit(3), TempSplit(4), TempSplit(5)))
                End If
            ElseIf TempSplit.Count = 6 Then
                'SimpleElevator 1 floor string
                AddFloor(New Floor(TempSplit(0), TempSplit(1), TempSplit(2), TempSplit(3), TempSplit(4), TempSplit(5)))
            End If
        End While

        FileClose(1)

    End Sub

    '----------------------------------------------------[Getters and Setters]----------------------------------------------------

    ''' <summary>Returns the arraylist of all the floors</summary>
    Public Function GetFloors() As ArrayList
        Return Floors
    End Function

    ''' <summary>Clears all floors</summary>
    Public Sub ClearFloors()
        Floors.Clear()
    End Sub

    ''' <summary>Adds the new floor to the arraylist</summary>
    Public Sub AddFloor(NewFloor As Floor)
        Floors.Add(NewFloor)
    End Sub

    ''' <summary>removes the floor at the specified index</summary>
    Public Sub RemoveFloor(Index As Integer)
        Floors.RemoveAt(Index)
    End Sub

    ''' <summary>Updates the specified floor at the specified index</summary>
    Public Sub UpdateFloor(index As Integer, NewFloor As Floor)
        Floors(index) = NewFloor
    End Sub

    '----------------------------------------------------[Other Operations]----------------------------------------------------

    ''' <summary>Gets the string used to export this elevator from this program to Minecraft</summary>
    Public Function GetExport() As String
        Dim ExportText = "/tellraw @p ["""",{""text"":""" & Name & """,""color"":""" & NameColor.ColorString & """}"

        'Add each floor
        For Each Floor As Floor In Floors
            ExportText &= ",{""text"":""" & Floor.FloorText & """,""color"":""" & Floor.Color & """,""clickEvent"":{""action"":""run_command"",""value"":""" & Floor.GetCommand & """},""hoverEvent"":{""action"":""show_text"",""value"":{""text"":"""",""extra"":[{""text"":""" & Floor.HoverText & """}]}}}"
        Next

        ExportText &= "]"
        Return ExportText
    End Function

    ''' <summary>Gets a preview of this elevator, and how it will look like in Minecraft</summary>
    Public Function GetPreview() As String
        Dim PreviewText As String = Name.Replace("\n", vbNewLine)

        'Add each floor
        For Each Floor As Floor In Floors
            PreviewText &= Floor.FloorText.Replace("\n", vbNewLine)
        Next

        Return PreviewText
    End Function

    ''' <summary>Saves this elevator to the specified file</summary>
    Public Sub Save(Filename As String)
        FileOpen(1, Filename, OpenMode.Output)
        PrintLine(1, String.Join("`", {Name, NameColor.ColorString}))

        For Each Floor As Floor In Floors
            PrintLine(1, Floor.GetSaveString)
        Next

        FileClose(1)
    End Sub

End Class
