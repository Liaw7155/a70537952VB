<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.lblMinimize = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.PBused = New System.Windows.Forms.PictureBox()
        Me.PBExpired = New System.Windows.Forms.PictureBox()
        Me.PBhistory = New System.Windows.Forms.PictureBox()
        Me.PBsearch = New System.Windows.Forms.PictureBox()
        Me.PBdelete = New System.Windows.Forms.PictureBox()
        Me.PBadd = New System.Windows.Forms.PictureBox()
        CType(Me.PBused, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBExpired, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBhistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBsearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBdelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBadd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Location = New System.Drawing.Point(224, 112)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1057, 609)
        Me.Panel1.TabIndex = 0
        '
        'lblClose
        '
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.Color.Transparent
        Me.lblClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblClose.Location = New System.Drawing.Point(1237, 10)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(26, 25)
        Me.lblClose.TabIndex = 1
        Me.lblClose.Text = "X"
        Me.lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMinimize
        '
        Me.lblMinimize.AutoSize = True
        Me.lblMinimize.BackColor = System.Drawing.Color.Transparent
        Me.lblMinimize.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblMinimize.Location = New System.Drawing.Point(1185, 5)
        Me.lblMinimize.Name = "lblMinimize"
        Me.lblMinimize.Size = New System.Drawing.Size(23, 25)
        Me.lblMinimize.TabIndex = 2
        Me.lblMinimize.Text = "_"
        Me.lblMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(166, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(4852, 76)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "———————————————————————————————————————————————————————————————————————————————--" &
    "-----------------------------------------------------------------------------" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(224, 83)
        Me.txtSearch.MaxLength = 50
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(162, 22)
        Me.txtSearch.TabIndex = 6
        Me.txtSearch.Text = "Search food by name..."
        '
        'PBused
        '
        Me.PBused.BackColor = System.Drawing.Color.Transparent
        Me.PBused.Image = Global.WindowsApplication1.My.Resources.Resources.used_2
        Me.PBused.Location = New System.Drawing.Point(44, 203)
        Me.PBused.Name = "PBused"
        Me.PBused.Size = New System.Drawing.Size(99, 31)
        Me.PBused.TabIndex = 10
        Me.PBused.TabStop = False
        Me.PBused.Visible = False
        '
        'PBExpired
        '
        Me.PBExpired.BackColor = System.Drawing.Color.Transparent
        Me.PBExpired.Image = Global.WindowsApplication1.My.Resources.Resources.Expired
        Me.PBExpired.Location = New System.Drawing.Point(44, 137)
        Me.PBExpired.Name = "PBExpired"
        Me.PBExpired.Size = New System.Drawing.Size(99, 31)
        Me.PBExpired.TabIndex = 9
        Me.PBExpired.TabStop = False
        Me.PBExpired.Visible = False
        '
        'PBhistory
        '
        Me.PBhistory.BackColor = System.Drawing.Color.Transparent
        Me.PBhistory.Image = Global.WindowsApplication1.My.Resources.Resources.history
        Me.PBhistory.Location = New System.Drawing.Point(772, 44)
        Me.PBhistory.Name = "PBhistory"
        Me.PBhistory.Size = New System.Drawing.Size(99, 31)
        Me.PBhistory.TabIndex = 8
        Me.PBhistory.TabStop = False
        '
        'PBsearch
        '
        Me.PBsearch.BackColor = System.Drawing.Color.Transparent
        Me.PBsearch.Image = Global.WindowsApplication1.My.Resources.Resources.searchLogo
        Me.PBsearch.Location = New System.Drawing.Point(392, 83)
        Me.PBsearch.Name = "PBsearch"
        Me.PBsearch.Size = New System.Drawing.Size(24, 20)
        Me.PBsearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBsearch.TabIndex = 7
        Me.PBsearch.TabStop = False
        '
        'PBdelete
        '
        Me.PBdelete.BackColor = System.Drawing.Color.Transparent
        Me.PBdelete.Image = Global.WindowsApplication1.My.Resources.Resources.deleteOff
        Me.PBdelete.Location = New System.Drawing.Point(892, 44)
        Me.PBdelete.Name = "PBdelete"
        Me.PBdelete.Size = New System.Drawing.Size(99, 31)
        Me.PBdelete.TabIndex = 5
        Me.PBdelete.TabStop = False
        '
        'PBadd
        '
        Me.PBadd.BackColor = System.Drawing.Color.Transparent
        Me.PBadd.Image = CType(resources.GetObject("PBadd.Image"), System.Drawing.Image)
        Me.PBadd.InitialImage = CType(resources.GetObject("PBadd.InitialImage"), System.Drawing.Image)
        Me.PBadd.Location = New System.Drawing.Point(1069, 37)
        Me.PBadd.Name = "PBadd"
        Me.PBadd.Size = New System.Drawing.Size(38, 38)
        Me.PBadd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PBadd.TabIndex = 3
        Me.PBadd.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.PBused)
        Me.Controls.Add(Me.PBExpired)
        Me.Controls.Add(Me.PBhistory)
        Me.Controls.Add(Me.PBsearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.PBdelete)
        Me.Controls.Add(Me.PBadd)
        Me.Controls.Add(Me.lblMinimize)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PBused, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBExpired, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBhistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBsearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBdelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBadd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblClose As Label
    Friend WithEvents lblMinimize As Label
    Friend WithEvents PBadd As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PBdelete As PictureBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents PBsearch As PictureBox
    Friend WithEvents PBhistory As PictureBox
    Friend WithEvents PBExpired As PictureBox
    Friend WithEvents PBused As PictureBox
End Class
