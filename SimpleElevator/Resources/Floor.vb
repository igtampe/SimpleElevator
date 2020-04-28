''' <summary>Holds an in an Elevator</summary>
Public Class Floor

    '----------------------------------------------------[Variables]----------------------------------------------------
    Public FloorText As String
    Public HoverText As String
    Public Color As String
    Private XCoord As String
    Private YCoord As String
    Private ZCoord As String
    Private Command As String

    ''' <summary>Constructs a Coordinate Mode floor</summary>
    Public Sub New(FloorText As String, HoverText As String, Color As String, XCoord As String, YCoord As String, ZCoord As String)
        Me.FloorText = FloorText
        Me.HoverText = HoverText
        Me.Color = Color
        Me.XCoord = XCoord
        Me.YCoord = YCoord
        Me.ZCoord = ZCoord

        Command = "/tp @p " & XCoord & " " & YCoord & " " & ZCoord
    End Sub

    ''' <summary>Constructs a Command Mode floor</summary>
    Public Sub New(FloorText As String, HoverText As String, Color As String, Command As String)
        Me.FloorText = FloorText
        Me.HoverText = HoverText
        Me.Color = Color
        Me.Command = Command

        XCoord = ""
        YCoord = ""
        ZCoord = ""

    End Sub

    '----------------------------------------------------[Getters and Setters]----------------------------------------------------

    ''' <summary>Updates coordinates and the tied command</summary>
    Public Sub UpdateCoords(X As String, Y As String, Z As String)
        XCoord = X
        YCoord = Y
        ZCoord = Z

        Command = "/tp @p " & XCoord & " " & YCoord & " " & ZCoord
    End Sub

    ''' <summary>Returns an array with the three coordinates</summary>
    Public Function GetCoords() As String()
        Return {XCoord, YCoord, ZCoord}
    End Function

    ''' <summary>Sets the command, and clears the coordinates, setting this floor to Command Mode</summary>
    Public Sub SetCommand(Command As String)
        Me.Command = Command
        XCoord = ""
        YCoord = ""
        ZCoord = ""
    End Sub

    ''' <summary>Returns the command this floor is tied to</summary>
    Public Function GetCommand() As String
        Return Command
    End Function

    ''' <summary>Gets a command used to save the floor to disk</summary>
    Public Function GetSaveString() As String
        Return String.Join("`", {FloorText, HoverText, Color, XCoord, YCoord, ZCoord, Command})
    End Function

End Class