Public Class Card

    Public food As Food
    Public leftDays As Integer
    Public isSelectedDelete As Boolean = False


    Sub New(ByRef food As Food, ByVal row As Integer, ByVal column As Integer, ByVal rowSpace As Integer, ByVal colunmSpace As Integer)

        Me.food = food
        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。

        setCategory()
        setLeftDay()
        lblName.Text = food.name
        lblQuantity.Text = food.quantity
        PBpicture.ImageLocation = "..\..\..\img\" & food.imgURL

        setLocation(row, column, rowSpace, colunmSpace)



    End Sub



    'set card location
    Sub setLocation(ByVal row As Integer, ByVal column As Integer, ByVal rowSpace As Integer, ByVal colunmSpace As Integer)
        '199 W 271 H
        Dim x As Integer = (199 + colunmSpace) * column
        Dim y As Integer = (271 + rowSpace) * row
        Location = New Point(x, y)
    End Sub

    'set category color
    Sub setCategory()
        lblCategory.Text = food.category
        Select Case food.category
            Case "Food"
                lblCategory.BackColor = Color.FromArgb(255, 252, 61, 3)
            Case "Drinks"
                lblCategory.BackColor = Color.FromArgb(255, 2, 137, 255)
            Case "Fruit"
                lblCategory.BackColor = Color.FromArgb(255, 168, 2, 233)
            Case "Vegetable"
                lblCategory.BackColor = Color.FromArgb(255, 1, 162, 39)
            Case "Bread"
                lblCategory.BackColor = Color.FromArgb(255, 255, 168, 82)
            Case "Sauce"
                lblCategory.BackColor = Color.FromArgb(255, 140, 106, 89)
            Case Else
                lblCategory.BackColor = Color.FromArgb(255, 0, 0, 0)
        End Select

    End Sub

    'set left day style
    Sub setLeftDay()
        leftDays = DateDiff(DateInterval.Day, Date.Today, food.expirationDate)
        If leftDays > 0 Then
            lblDays.Text = leftDays & " days"

            Select Case leftDays
                Case <= 3
                    lblDays.BackColor = Color.FromArgb(255, 255, 0, 0)
                    lblLeft.ForeColor = Color.FromArgb(255, 255, 0, 0)

                Case 4 To 7
                    lblDays.BackColor = Color.FromArgb(255, 255, 133, 33)
                    lblLeft.ForeColor = Color.FromArgb(255, 255, 133, 33)
                Case Else
                    lblDays.BackColor = Color.FromArgb(255, 32, 151, 255)
                    lblLeft.ForeColor = Color.FromArgb(255, 32, 151, 255)
            End Select
        Else
            lblDays.Text = "Expired"
            lblDays.ForeColor = Color.FromArgb(255, 255, 0, 0)
            lblDays.BackColor = Color.FromArgb(255, 0, 0, 0)
        End If
    End Sub

    Sub DeleteHandler()
        isSelectedDelete = Not isSelectedDelete
        If isSelectedDelete Then
            PBtick.ImageLocation = "..\..\..\img\default image\tickOn.png"
        Else
            PBtick.ImageLocation = "..\..\..\img\default image\tickOff.png"
        End If
    End Sub

    Private Sub Mouse_Enter(sender As Object, e As EventArgs) Handles PBtick.MouseEnter
        Cursor = Cursors.Hand
    End Sub

    Private Sub Mouse_Leave(sender As Object, e As EventArgs) Handles PBtick.MouseLeave
        Cursor = Cursors.Default
    End Sub


End Class
