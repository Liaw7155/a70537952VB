Imports System.IO

Public Class AddFood
    Dim parentForm1 As Form1
    Sub New(ByRef parentForm As Form1)

        ' 此调用是设计器所必需的。
        InitializeComponent()
        ' 在 InitializeComponent() 调用之后添加任何初始化。
        Me.parentForm1 = parentForm
    End Sub
    Private Sub AddFood_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tool.CenterForm(Me)
        setComboBoxCategory()
        DateTimePicker1.Value = Date.Today

    End Sub

    Private Sub Mouse_Enter(sender As Object, e As EventArgs) Handles lblClose.MouseEnter, lblSave.MouseEnter, lblCancel.MouseEnter, lblBrowse.MouseEnter
        Cursor = Cursors.Hand
    End Sub

    Private Sub Mouse_Leave(sender As Object, e As EventArgs) Handles lblClose.MouseLeave, lblSave.MouseLeave, lblCancel.MouseLeave, lblBrowse.MouseLeave
        Cursor = Cursors.Default
    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles lblCancel.Click, lblClose.Click
        Me.Close()
    End Sub

    Private Sub lblBrowse_Click(sender As Object, e As EventArgs) Handles lblBrowse.Click
        Dim dialog As New OpenFileDialog()
        dialog.Filter = "Image Files (*.bmp,*.jpg,*.png,*.jpeg)|*.bmp;*.jpg;*.png;*.jpeg"
        dialog.AddExtension = True
        If DialogResult.OK = dialog.ShowDialog Then
            txtFoodImage.Text = dialog.FileName
            PBimage.ImageLocation = txtFoodImage.Text
        End If
    End Sub

    Private Sub lblSave_Click(sender As Object, e As EventArgs) Handles lblSave.Click
        If checkDataValidation() Then
            Dim ImagefileName As String = getImageUrl()
            Dim food As New Food(txtFoodName.Text, ComboBoxCategory.SelectedItem.ToString(), DateTimePicker1.Value, txtQuantity.Text, ImagefileName, txtDescription.Text)
            Dao.addFood(food)
            parentForm1.refreshCard()
            Me.Close()
        End If


    End Sub
    'check is all data valid
    Private Function checkDataValidation() As Boolean
        Dim isValid As Boolean = True
        lblFoodNameNotice.Visible = False
        lblQuantityNotice.Visible = False
        If txtFoodName.Text = "" Then
            isValid = False
            lblFoodNameNotice.Visible = True
        End If

        If Not IsNumeric(txtQuantity.Text) Then
            isValid = False
            lblQuantityNotice.Visible = True
        End If

        Return isValid
    End Function
    'get image's file url
    'if image is user upload then copy the image into project image file

    Private Function getImageUrl() As String
        Dim filename As String
        Const directoryImage As String = "..\..\..\img\"
        Const directoryDefaultImage As String = "\default image\"
        If txtFoodImage.Text <> "" Then
            filename = txtFoodImage.Text.Split("\").Last
            Tool.copyFile(txtFoodImage.Text, directoryImage & filename)
        Else
            filename = directoryDefaultImage & PBimage.ImageLocation.Split("\").Last
        End If

        Return filename
    End Function
    'set category comboBox's elements
    Sub setComboBoxCategory()
        Dim listCategory As List(Of String) = Dao.queryAllCategoryName()
        For Each category As String In listCategory
            ComboBoxCategory.Items.Add(category)
        Next
        ComboBoxCategory.SelectedIndex = 0
    End Sub

    'when category comboBox's selected item changed, then picture box's image will change at the same time
    Private Sub ComboBoxCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCategory.SelectedIndexChanged
        If txtFoodImage.Text = "" Then
            Dim imgName As String = Dao.queryCategoryImgUrlByName(ComboBoxCategory.SelectedItem.ToString)
            PBimage.ImageLocation = "..\..\..\img\default image\" & imgName
        End If

    End Sub
End Class
