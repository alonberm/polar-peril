Module Polar_Peril_Stuff
    Structure SpriteType
        Dim Speed As Point
        Dim floatTime As Integer
        Dim picNum As Integer
        Dim facingRight As Boolean
        Dim facingLeft As Boolean
        Dim floating As Boolean
        Dim onLadder As Boolean
        Dim onFloor As Boolean
        Dim floorNumber As Integer
    End Structure

    Structure floorType
        Dim x As Single
        Dim y As Single
        Dim slope As Single
        Dim leftEdge As Integer
        Dim rightEdge As Integer
    End Structure
    Public quit As Boolean
End Module