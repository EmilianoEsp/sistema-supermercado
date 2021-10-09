Public Class Producto
    Public nombre As String
    Public precio As Single
    Public stock As Integer
    Public IdBase As Integer

    Public Sub New(ByVal n As String, ByVal s As Integer, ByVal p As Single, ByVal id As Integer)
        nombre = n
        stock = s
        precio = p
        IdBase = id
    End Sub

End Class
