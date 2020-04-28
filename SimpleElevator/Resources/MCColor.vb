''' <summary>Holds a Minecraft Color code</summary>
Public Class MCColor

    '----------------------------------------------------[Static variables]----------------------------------------------------

    'All Defined colors
    Public Shared ReadOnly WHITE As MCColor = New MCColor("White", "white", Color.White)
    Public Shared ReadOnly GRAY As MCColor = New MCColor("Gray", "gray", Color.Gray)
    Public Shared ReadOnly DARK_GRAY As MCColor = New MCColor("Dark Gray", "dark_gray", Color.DarkGray)
    Public Shared ReadOnly BLACK As MCColor = New MCColor("Black", "black", Color.Black)
    Public Shared ReadOnly DARK_BLUE As MCColor = New MCColor("Dark Blue", "dark_blue", Color.DarkBlue)
    Public Shared ReadOnly DARK_GREEN As MCColor = New MCColor("Dark Green", "dark_green", Color.DarkGreen)
    Public Shared ReadOnly DARK_AQUA As MCColor = New MCColor("Dark Aqua", "dark_aqua", Color.DarkCyan)
    Public Shared ReadOnly DARK_RED As MCColor = New MCColor("Dark Red", "dark_red", Color.DarkRed)
    Public Shared ReadOnly DARK_PURPLE As MCColor = New MCColor("Dark Purple", "dark_purple", Color.DarkMagenta)
    Public Shared ReadOnly GOLD As MCColor = New MCColor("Gold", "gold", Color.Gold)
    Public Shared ReadOnly BLUE As MCColor = New MCColor("Blue", "blue", Color.Blue)
    Public Shared ReadOnly GREEN As MCColor = New MCColor("Green", "green", Color.Green)
    Public Shared ReadOnly AQUA As MCColor = New MCColor("Aqua", "aqua", Color.Cyan)
    Public Shared ReadOnly RED As MCColor = New MCColor("Red", "red", Color.Red)
    Public Shared ReadOnly LIGHT_PURPLE As MCColor = New MCColor("Light Purple", "light_purple", Color.Magenta)
    Public Shared ReadOnly YELLOW As MCColor = New MCColor("Yellow", "yellow", Color.Yellow)

    ''' <summary>Array of all colors</summary>
    Public Shared ReadOnly Dictionary As MCColor() = {
        WHITE,
        GRAY,
        DARK_GRAY,
        BLACK,
        DARK_BLUE,
        DARK_GREEN,
        DARK_AQUA,
        DARK_RED,
        DARK_PURPLE,
        GOLD,
        BLUE,
        GREEN,
        AQUA,
        RED,
        LIGHT_PURPLE,
        YELLOW
    }

    '----------------------------------------------------[Static Functions]----------------------------------------------------

    ''' <summary>Takes a colorString (dark_gray) and translates it to a name (Dark Gray)</summary>
    Public Shared Function ColorStringToName(ColorString As String) As String
        For Each MCColor As MCColor In Dictionary
            If MCColor.ColorString = ColorString Then Return MCColor.Name
        Next
        Return "?"
    End Function

    ''' <summary>Takes a colorName (Dark Gray) and translates it to a ColorString (dark_gray)</summary>
    Public Shared Function ColorNameToColorString(Name As String) As String
        For Each MCColor As MCColor In Dictionary
            If MCColor.Name = Name Then Return MCColor.ColorString
        Next
        Return "white"
    End Function

    ''' <summary>Takes a ColorString (dark_gray) and translates it to an MCColor (MCColor.DARK_GRAY)</summary>
    Public Shared Function ColorStringToMCColor(ColorString As String) As MCColor
        For Each MCColor As MCColor In Dictionary
            If MCColor.ColorString = ColorString Then Return MCColor
        Next
        Return WHITE
    End Function

    '----------------------------------------------------[Variables]----------------------------------------------------
    Public ReadOnly Name As String
    Public ReadOnly ColorString As String
    Public ReadOnly Color As Color

    '----------------------------------------------------[Initialization]----------------------------------------------------
    Public Sub New(Name As String, ColorString As String, Color As Color)
        Me.Name = Name
        Me.ColorString = ColorString
        Me.Color = Color
    End Sub

    '----------------------------------------------------[Overrider]----------------------------------------------------
    Public Overrides Function ToString() As String
        Return ColorString
    End Function

End Class
