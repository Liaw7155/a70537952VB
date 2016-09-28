<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddFood
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblBackground = New System.Windows.Forms.Label()
        Me.lblAddFood = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PBimage = New System.Windows.Forms.PictureBox()
        Me.txtFoodName = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBoxCategory = New System.Windows.Forms.ComboBox()
        Me.txtFoodImage = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.lblCancel = New System.Windows.Forms.Label()
        Me.lblSave = New System.Windows.Forms.Label()
        Me.lblBrowse = New System.Windows.Forms.Label()
        Me.lblFoodNameNotice = New System.Windows.Forms.Label()
        Me.lblQuantityNotice = New System.Windows.Forms.Label()
        CType(Me.PBimage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBackground
        '
        Me.lblBackground.BackColor = System.Drawing.Color.White
        Me.lblBackground.Location = New System.Drawing.Point(2, 2)
        Me.lblBackground.Name = "lblBackground"
        Me.lblBackground.Size = New System.Drawing.Size(492, 505)
        Me.lblBackground.TabIndex = 0
        '
        'lblAddFood
        '
        Me.lblAddFood.AutoSize = True
        Me.lblAddFood.BackColor = System.Drawing.Color.White
        Me.lblAddFood.Font = New System.Drawing.Font("微软雅黑 Light", 30.0!)
        Me.lblAddFood.Location = New System.Drawing.Point(5, 12)
        Me.lblAddFood.Name = "lblAddFood"
        Me.lblAddFood.Size = New System.Drawing.Size(202, 52)
        Me.lblAddFood.TabIndex = 1
        Me.lblAddFood.Text = "Add Food"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("微软雅黑 Light", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(254, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(119, 27)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Food Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("微软雅黑 Light", 15.0!)
        Me.Label2.Location = New System.Drawing.Point(224, 208)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(149, 27)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Expiration Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("微软雅黑 Light", 15.0!)
        Me.Label3.Location = New System.Drawing.Point(279, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(94, 27)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Category"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("微软雅黑 Light", 15.0!)
        Me.Label4.Location = New System.Drawing.Point(279, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(89, 27)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Quantity"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("微软雅黑 Light", 15.0!)
        Me.Label5.Location = New System.Drawing.Point(9, 275)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 27)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Food Image"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("微软雅黑 Light", 15.0!, System.Drawing.FontStyle.Underline)
        Me.Label6.Location = New System.Drawing.Point(9, 315)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 27)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Description"
        '
        'PBimage
        '
        Me.PBimage.Location = New System.Drawing.Point(14, 77)
        Me.PBimage.Name = "PBimage"
        Me.PBimage.Size = New System.Drawing.Size(210, 181)
        Me.PBimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBimage.TabIndex = 2
        Me.PBimage.TabStop = False
        '
        'txtFoodName
        '
        Me.txtFoodName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFoodName.Location = New System.Drawing.Point(384, 82)
        Me.txtFoodName.MaxLength = 30
        Me.txtFoodName.Name = "txtFoodName"
        Me.txtFoodName.Size = New System.Drawing.Size(100, 20)
        Me.txtFoodName.TabIndex = 9
        '
        'txtQuantity
        '
        Me.txtQuantity.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtQuantity.Location = New System.Drawing.Point(384, 127)
        Me.txtQuantity.MaxLength = 30
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantity.TabIndex = 10
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.DateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DateTimePicker1.Location = New System.Drawing.Point(288, 239)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(196, 20)
        Me.DateTimePicker1.TabIndex = 11
        '
        'ComboBoxCategory
        '
        Me.ComboBoxCategory.BackColor = System.Drawing.SystemColors.Window
        Me.ComboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ComboBoxCategory.FormattingEnabled = True
        Me.ComboBoxCategory.Location = New System.Drawing.Point(384, 170)
        Me.ComboBoxCategory.Name = "ComboBoxCategory"
        Me.ComboBoxCategory.Size = New System.Drawing.Size(100, 24)
        Me.ComboBoxCategory.TabIndex = 12
        '
        'txtFoodImage
        '
        Me.txtFoodImage.Enabled = False
        Me.txtFoodImage.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFoodImage.Location = New System.Drawing.Point(136, 274)
        Me.txtFoodImage.MaxLength = 10000
        Me.txtFoodImage.Multiline = True
        Me.txtFoodImage.Name = "txtFoodImage"
        Me.txtFoodImage.Size = New System.Drawing.Size(277, 32)
        Me.txtFoodImage.TabIndex = 13
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtDescription.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDescription.Location = New System.Drawing.Point(14, 345)
        Me.txtDescription.MaxLength = 1000
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(456, 105)
        Me.txtDescription.TabIndex = 14
        '
        'lblClose
        '
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.Color.White
        Me.lblClose.Font = New System.Drawing.Font("微软雅黑 Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblClose.Location = New System.Drawing.Point(460, 9)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(24, 27)
        Me.lblClose.TabIndex = 15
        Me.lblClose.Text = "X"
        Me.lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCancel
        '
        Me.lblCancel.AutoSize = True
        Me.lblCancel.BackColor = System.Drawing.Color.White
        Me.lblCancel.Font = New System.Drawing.Font("微软雅黑 Light", 22.0!)
        Me.lblCancel.Location = New System.Drawing.Point(100, 461)
        Me.lblCancel.Name = "lblCancel"
        Me.lblCancel.Size = New System.Drawing.Size(107, 39)
        Me.lblCancel.TabIndex = 16
        Me.lblCancel.Text = "Cancel"
        '
        'lblSave
        '
        Me.lblSave.AutoSize = True
        Me.lblSave.BackColor = System.Drawing.Color.White
        Me.lblSave.Font = New System.Drawing.Font("微软雅黑 Light", 22.0!)
        Me.lblSave.Location = New System.Drawing.Point(322, 461)
        Me.lblSave.Name = "lblSave"
        Me.lblSave.Size = New System.Drawing.Size(80, 39)
        Me.lblSave.TabIndex = 17
        Me.lblSave.Text = "Save"
        '
        'lblBrowse
        '
        Me.lblBrowse.AutoSize = True
        Me.lblBrowse.BackColor = System.Drawing.Color.White
        Me.lblBrowse.Font = New System.Drawing.Font("微软雅黑 Light", 12.0!)
        Me.lblBrowse.Location = New System.Drawing.Point(419, 281)
        Me.lblBrowse.Name = "lblBrowse"
        Me.lblBrowse.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBrowse.Size = New System.Drawing.Size(63, 21)
        Me.lblBrowse.TabIndex = 18
        Me.lblBrowse.Text = "Browse"
        '
        'lblFoodNameNotice
        '
        Me.lblFoodNameNotice.AutoSize = True
        Me.lblFoodNameNotice.BackColor = System.Drawing.Color.White
        Me.lblFoodNameNotice.Font = New System.Drawing.Font("微软雅黑 Light", 9.0!)
        Me.lblFoodNameNotice.ForeColor = System.Drawing.Color.Red
        Me.lblFoodNameNotice.Location = New System.Drawing.Point(320, 104)
        Me.lblFoodNameNotice.Name = "lblFoodNameNotice"
        Me.lblFoodNameNotice.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFoodNameNotice.Size = New System.Drawing.Size(170, 17)
        Me.lblFoodNameNotice.TabIndex = 19
        Me.lblFoodNameNotice.Text = "*Food name cannot be blank"
        Me.lblFoodNameNotice.Visible = False
        '
        'lblQuantityNotice
        '
        Me.lblQuantityNotice.AutoSize = True
        Me.lblQuantityNotice.BackColor = System.Drawing.Color.White
        Me.lblQuantityNotice.Font = New System.Drawing.Font("微软雅黑 Light", 9.0!)
        Me.lblQuantityNotice.ForeColor = System.Drawing.Color.Red
        Me.lblQuantityNotice.Location = New System.Drawing.Point(338, 148)
        Me.lblQuantityNotice.Name = "lblQuantityNotice"
        Me.lblQuantityNotice.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblQuantityNotice.Size = New System.Drawing.Size(152, 17)
        Me.lblQuantityNotice.TabIndex = 20
        Me.lblQuantityNotice.Text = "*Quantity is not a number"
        Me.lblQuantityNotice.Visible = False
        '
        'AddFood
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(496, 509)
        Me.Controls.Add(Me.lblQuantityNotice)
        Me.Controls.Add(Me.lblFoodNameNotice)
        Me.Controls.Add(Me.lblBrowse)
        Me.Controls.Add(Me.lblSave)
        Me.Controls.Add(Me.lblCancel)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtFoodImage)
        Me.Controls.Add(Me.ComboBoxCategory)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.txtFoodName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PBimage)
        Me.Controls.Add(Me.lblAddFood)
        Me.Controls.Add(Me.lblBackground)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddFood"
        Me.Text = "AddFood"
        CType(Me.PBimage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblBackground As Label
    Friend WithEvents lblAddFood As Label
    Friend WithEvents PBimage As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFoodName As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComboBoxCategory As ComboBox
    Friend WithEvents txtFoodImage As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents lblClose As Label
    Friend WithEvents lblCancel As Label
    Friend WithEvents lblSave As Label
    Friend WithEvents lblBrowse As Label
    Friend WithEvents lblFoodNameNotice As Label
    Friend WithEvents lblQuantityNotice As Label
End Class
