<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Card
    Inherits System.Windows.Forms.UserControl

    'UserControl 重写释放以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Card))
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblLeft = New System.Windows.Forms.Label()
        Me.lblDays = New System.Windows.Forms.Label()
        Me.PBtick = New System.Windows.Forms.PictureBox()
        Me.PBquantity = New System.Windows.Forms.PictureBox()
        Me.PBpicture = New System.Windows.Forms.PictureBox()
        CType(Me.PBtick, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBquantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBpicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.lblName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblName.Location = New System.Drawing.Point(7, 29)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(61, 24)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Name"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCategory
        '
        Me.lblCategory.BackColor = System.Drawing.Color.Red
        Me.lblCategory.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.lblCategory.ForeColor = System.Drawing.Color.White
        Me.lblCategory.Location = New System.Drawing.Point(4, 2)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(90, 24)
        Me.lblCategory.TabIndex = 2
        Me.lblCategory.Text = "Category"
        Me.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(9, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 247)
        Me.Label1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(6, 28)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(187, 236)
        Me.Label2.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(4, 26)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(192, 241)
        Me.Label3.TabIndex = 7
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.lblQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.lblQuantity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblQuantity.Location = New System.Drawing.Point(34, 213)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(24, 17)
        Me.lblQuantity.TabIndex = 9
        Me.lblQuantity.Text = "30"
        Me.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLeft
        '
        Me.lblLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.lblLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.lblLeft.ForeColor = System.Drawing.Color.Red
        Me.lblLeft.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblLeft.Location = New System.Drawing.Point(42, 231)
        Me.lblLeft.Name = "lblLeft"
        Me.lblLeft.Size = New System.Drawing.Size(48, 25)
        Me.lblLeft.TabIndex = 10
        Me.lblLeft.Text = "Left"
        Me.lblLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDays
        '
        Me.lblDays.BackColor = System.Drawing.Color.Red
        Me.lblDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.lblDays.ForeColor = System.Drawing.Color.White
        Me.lblDays.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDays.Location = New System.Drawing.Point(96, 231)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(88, 27)
        Me.lblDays.TabIndex = 11
        Me.lblDays.Text = "3 Days"
        Me.lblDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PBtick
        '
        Me.PBtick.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.PBtick.Image = Global.WindowsApplication1.My.Resources.Resources.tickOff
        Me.PBtick.Location = New System.Drawing.Point(140, 3)
        Me.PBtick.Name = "PBtick"
        Me.PBtick.Size = New System.Drawing.Size(50, 50)
        Me.PBtick.TabIndex = 12
        Me.PBtick.TabStop = False
        Me.PBtick.Visible = False
        '
        'PBquantity
        '
        Me.PBquantity.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.PBquantity.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.PBquantity.Image = Global.WindowsApplication1.My.Resources.Resources.quantityLogo
        Me.PBquantity.InitialImage = CType(resources.GetObject("PBquantity.InitialImage"), System.Drawing.Image)
        Me.PBquantity.Location = New System.Drawing.Point(16, 216)
        Me.PBquantity.Name = "PBquantity"
        Me.PBquantity.Size = New System.Drawing.Size(17, 15)
        Me.PBquantity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBquantity.TabIndex = 8
        Me.PBquantity.TabStop = False
        '
        'PBpicture
        '
        Me.PBpicture.Image = Global.WindowsApplication1.My.Resources.Resources.garlic_bread
        Me.PBpicture.Location = New System.Drawing.Point(13, 55)
        Me.PBpicture.Name = "PBpicture"
        Me.PBpicture.Size = New System.Drawing.Size(171, 155)
        Me.PBpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBpicture.TabIndex = 4
        Me.PBpicture.TabStop = False
        '
        'Card
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PBtick)
        Me.Controls.Add(Me.lblCategory)
        Me.Controls.Add(Me.lblDays)
        Me.Controls.Add(Me.lblLeft)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.PBquantity)
        Me.Controls.Add(Me.PBpicture)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Card"
        Me.Size = New System.Drawing.Size(207, 279)
        CType(Me.PBtick, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBquantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBpicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCategory As Label
    Friend WithEvents lblName As Label
    Friend WithEvents PBpicture As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PBquantity As PictureBox
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblLeft As Label
    Friend WithEvents lblDays As Label
    Friend WithEvents PBtick As PictureBox
End Class
