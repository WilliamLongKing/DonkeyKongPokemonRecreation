Module mariostuff
    Structure mariotype
        Dim speed As Point
        Dim floattime As Integer
        Dim picnum As Integer
        Dim facingright As Boolean
        Dim floating As Boolean
        Dim onladder As Boolean
        Dim onfloor As Boolean
    End Structure
    Structure Floortype
        Dim x As Single
        Dim y As Single
        Dim slope As Single
        Dim leftedge As Integer
        Dim rightedge As Integer
    End Structure
    Public Declare Sub play Lib "winmm.dll" Alias "mciExecute" (ByVal command As String)
End Module
