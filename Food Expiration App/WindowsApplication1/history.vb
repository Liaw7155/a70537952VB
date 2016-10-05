Public Class history
    Public id As Integer
    Public name As String
    Public category As String
    Public expirationDate As Date
    Public quantity As Int32
    Public imgURL As String
    Public description As String

    Sub New(ByVal id As Integer, ByVal name As String, ByVal category As String, ByVal expirationDate As Date, ByVal quantity As Int32, ByVal imgURL As String, ByVal description As String)
        Me.id = id
        Me.name = name
        Me.category = category
        Me.expirationDate = expirationDate
        Me.quantity = quantity
        Me.imgURL = imgURL
        Me.description = description
    End Sub

    Sub New(ByVal name As String, ByVal category As String, ByVal expirationDate As Date, ByVal quantity As Int32, ByVal imgURL As String, ByVal description As String)
        Me.name = name
        Me.category = category
        Me.expirationDate = expirationDate
        Me.quantity = quantity
        Me.imgURL = imgURL
        Me.description = description
    End Sub
End Class
