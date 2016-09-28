Imports System.Data.OleDb
Imports System.Text

Public Class Form1
    Shared listFood As List(Of Food) 'Record current display foods
    Shared listCard As New List(Of Card) 'Record current display cards
    Shared isDeleteState As Boolean = False 'Record is currently in delete mode or not

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dao.testConnect()
        Tool.CenterForm(Me)

        refreshCard()


    End Sub

    'remove food that is displaying and display all food again
    Public Sub refreshCard()
        listFood = Dao.queryAllFood()
        generateCard(listFood)
    End Sub

    'display food by giving a food's list
    Sub generateCard(ByRef listFood As List(Of Food))
        listCard.Clear()
        Panel1.Controls.Clear()
        Dim count As Integer = 0
        Dim row As Integer 'record currently is in which row
        Dim column As Integer = 0 'record currently is in which column
        Dim rowSpace As Integer = 35 'space between row and row
        Dim colunmSpace As Integer = 65 'space between column and column

        While count < listFood.Count
            row = count \ 4 'to calculate currently in which row
            Dim card As New Card(listFood(count), row, column, rowSpace, colunmSpace)
            listCard.Add(card)
            Panel1.Controls.Add(card)
            column += 1
            If column >= 4 Then 'is column is greater than 4 then set column = 0
                column = 0
            End If
            count += 1
        End While
    End Sub

    Private Sub Mouse_Enter(sender As Object, e As EventArgs) Handles lblClose.MouseEnter, lblMinimize.MouseEnter, PBadd.MouseEnter, PBdelete.MouseEnter,
        PBsearch.MouseEnter
        Cursor = Cursors.Hand
    End Sub

    Private Sub Mouse_Leave(sender As Object, e As EventArgs) Handles lblClose.MouseLeave, lblMinimize.MouseLeave, PBadd.MouseLeave, PBdelete.MouseLeave,
        PBsearch.MouseLeave
        Cursor = Cursors.Default
    End Sub

    Private Sub lblMinimize_Click(sender As Object, e As EventArgs) Handles lblMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Close()
    End Sub

    'show add food form
    Private Sub PBadd_Click(sender As Object, e As EventArgs) Handles PBadd.Click
        Dim f As New AddFood(Me)
        f.ShowDialog()
    End Sub

    Private Sub PBdelete_Click(sender As Object, e As EventArgs) Handles PBdelete.Click
        isDeleteState = Not isDeleteState
        setDeleteState(isDeleteState)


    End Sub

    'set delete state by a boolean value
    Sub setDeleteState(ByVal state As Boolean)
        If state Then
            PBdelete.ImageLocation = "..\..\..\img\default image\deleteOn.png"
            For Each card As Card In listCard
                card.PBtick.Visible = True

                For Each component As Control In card.Controls
                    AddHandler component.Click, AddressOf card.DeleteHandler

                Next
            Next

                Else
            Dim deleteCardNum As Integer
            Dim idList As New List(Of String)

            For Each card As Card In listCard
                If card.isSelectedDelete Then
                    deleteCardNum += 1
                    idList.Add(card.food.id.ToString)
                End If
            Next


            If Not idList.Count = 0 Then
                Dim result As MsgBoxResult = MsgBox(deleteCardNum & " food will be delete?", MsgBoxStyle.OkCancel)
                If result = 1 Then


                    Dao.deleteFoodsByIdArray(idList)
                End If
            End If



            PBdelete.ImageLocation = "..\..\..\img\default image\deleteOff.png"
            refreshCard()


        End If
    End Sub

    Private Sub txtSearch_gotFocus(sender As Object, e As EventArgs) Handles txtSearch.GotFocus
        txtSearch.Text = ""
    End Sub

    Private Sub txtSearch_lostFocus(sender As Object, e As EventArgs) Handles txtSearch.LostFocus
        txtSearch.Text = "Search food by name..."
    End Sub

    Private Sub PBsearch_Click(sender As Object, e As EventArgs) Handles PBsearch.Click
        Dim tempListFood As List(Of Food) = Dao.queryFoodByName(txtSearch.Text)
        If tempListFood.Count = 0 Then
            MsgBox("No food was found")
        Else
            listFood = tempListFood
            generateCard(listFood)
        End If

    End Sub

    Private Sub History_Click(sender As Object, e As EventArgs) Handles History.Click

    End Sub
End Class