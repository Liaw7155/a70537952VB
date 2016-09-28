Public Class Date_Box

    Sub New(ByRef date1 As Date, ByVal row As Integer, ByVal column As Integer, ByVal rowSpace As Integer, ByVal colunmSpace As Integer)

        InitializeComponent()
        setLocation(row, column, rowSpace, colunmSpace)
    End Sub

    Sub setLocation(ByVal row As Integer, ByVal column As Integer, ByVal rowSpace As Integer, ByVal colunmSpace As Integer)

        Dim x As Integer = (1000 + colunmSpace) * column
        Dim y As Integer = (153 + rowSpace) * row
        Location = New Point(x, y)
    End Sub
End Class
