Public Class Date_Box
    Public history As history
    Public isSelectedDelete As Boolean = False
    Shared listMiniCard As New List(Of MiniCard) 'Record current display MiniCards

    Sub New(ByRef history As history, ByVal row As Integer, ByVal column As Integer, ByVal rowSpace As Integer, ByVal colunmSpace As Integer)

        InitializeComponent()
        lblDate.Text = CType(history.expirationDate, String)
        setLocation(row, column, rowSpace, colunmSpace)
    End Sub

    Sub setLocation(ByVal row As Integer, ByVal column As Integer, ByVal rowSpace As Integer, ByVal colunmSpace As Integer)

        Dim x As Integer = 0
        Dim y As Integer = (160 + rowSpace) * row
        Location = New Point(x, y)
    End Sub

End Class
