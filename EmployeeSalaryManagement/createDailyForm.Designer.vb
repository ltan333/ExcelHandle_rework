<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class createDailyForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(createDailyForm))
        Panel1 = New Panel()
        Label1 = New Label()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        txtYear = New TextBox()
        btnRefresh = New FontAwesome.Sharp.IconButton()
        btnOpenFolder = New FontAwesome.Sharp.IconButton()
        Label2 = New Label()
        Panel2 = New Panel()
        CheckBox1 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox4 = New CheckBox()
        CheckBox5 = New CheckBox()
        CheckBox6 = New CheckBox()
        CheckBox7 = New CheckBox()
        CheckBox8 = New CheckBox()
        CheckBox9 = New CheckBox()
        CheckBox10 = New CheckBox()
        CheckBox11 = New CheckBox()
        CheckBox12 = New CheckBox()
        IconButton1 = New FontAwesome.Sharp.IconButton()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(794, 54)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Pristina", 20.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 35)
        Label1.TabIndex = 0
        Label1.Text = "Year"' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' txtYear
        ' 
        txtYear.Location = New Point(12, 72)
        txtYear.Multiline = True
        txtYear.Name = "txtYear"
        txtYear.Size = New Size(125, 34)
        txtYear.TabIndex = 2
        ' 
        ' btnRefresh
        ' 
        btnRefresh.IconChar = FontAwesome.Sharp.IconChar.ArrowRightRotate
        btnRefresh.IconColor = Color.Black
        btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnRefresh.IconSize = 25
        btnRefresh.Location = New Point(157, 72)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(112, 34)
        btnRefresh.TabIndex = 3
        btnRefresh.Text = "Refesh"
        btnRefresh.TextAlign = ContentAlignment.MiddleRight
        btnRefresh.TextImageRelation = TextImageRelation.ImageBeforeText
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' btnOpenFolder
        ' 
        btnOpenFolder.IconChar = FontAwesome.Sharp.IconChar.FolderOpen
        btnOpenFolder.IconColor = Color.Black
        btnOpenFolder.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnOpenFolder.IconSize = 25
        btnOpenFolder.Location = New Point(295, 72)
        btnOpenFolder.Name = "btnOpenFolder"
        btnOpenFolder.Size = New Size(141, 34)
        btnOpenFolder.TabIndex = 4
        btnOpenFolder.Text = "Open Folder"
        btnOpenFolder.TextAlign = ContentAlignment.MiddleLeft
        btnOpenFolder.TextImageRelation = TextImageRelation.ImageBeforeText
        btnOpenFolder.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Pristina", 20.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label2.Location = New Point(12, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(84, 35)
        Label2.TabIndex = 0
        Label2.Text = "Month"' 
        ' Panel2
        ' 
        Panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Panel2.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(0, 131)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(913, 54)
        Panel2.TabIndex = 5
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.CheckAlign = ContentAlignment.BottomCenter
        CheckBox1.Image = My.Resources.Resources.icons8_january_96px_2
        CheckBox1.Location = New Point(15, 207)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(96, 110)
        CheckBox1.TabIndex = 6
        CheckBox1.TextImageRelation = TextImageRelation.TextAboveImage
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.CheckAlign = ContentAlignment.BottomCenter
        CheckBox2.Image = My.Resources.Resources.icons8_february_96px
        CheckBox2.Location = New Point(117, 207)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(96, 110)
        CheckBox2.TabIndex = 7
        CheckBox2.TextImageRelation = TextImageRelation.TextAboveImage
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.CheckAlign = ContentAlignment.BottomCenter
        CheckBox3.Image = My.Resources.Resources.icons8_march_96px
        CheckBox3.Location = New Point(219, 207)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(96, 110)
        CheckBox3.TabIndex = 8
        CheckBox3.TextImageRelation = TextImageRelation.TextAboveImage
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.CheckAlign = ContentAlignment.BottomCenter
        CheckBox4.Image = My.Resources.Resources.icons8_april_96px
        CheckBox4.Location = New Point(321, 207)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(96, 110)
        CheckBox4.TabIndex = 9
        CheckBox4.TextImageRelation = TextImageRelation.TextAboveImage
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.CheckAlign = ContentAlignment.BottomCenter
        CheckBox5.Image = My.Resources.Resources.icons8_may_96px
        CheckBox5.Location = New Point(423, 207)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(96, 110)
        CheckBox5.TabIndex = 10
        CheckBox5.TextImageRelation = TextImageRelation.TextAboveImage
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' CheckBox6
        ' 
        CheckBox6.AutoSize = True
        CheckBox6.CheckAlign = ContentAlignment.BottomCenter
        CheckBox6.Image = My.Resources.Resources.icons8_june_96px
        CheckBox6.Location = New Point(525, 207)
        CheckBox6.Name = "CheckBox6"
        CheckBox6.Size = New Size(96, 110)
        CheckBox6.TabIndex = 11
        CheckBox6.TextImageRelation = TextImageRelation.TextAboveImage
        CheckBox6.UseVisualStyleBackColor = True
        ' 
        ' CheckBox7
        ' 
        CheckBox7.AutoSize = True
        CheckBox7.CheckAlign = ContentAlignment.BottomCenter
        CheckBox7.Image = My.Resources.Resources.icons8_december_96px
        CheckBox7.Location = New Point(525, 348)
        CheckBox7.Name = "CheckBox7"
        CheckBox7.Size = New Size(96, 110)
        CheckBox7.TabIndex = 17
        CheckBox7.TextImageRelation = TextImageRelation.TextAboveImage
        CheckBox7.UseVisualStyleBackColor = True
        ' 
        ' CheckBox8
        ' 
        CheckBox8.AutoSize = True
        CheckBox8.CheckAlign = ContentAlignment.BottomCenter
        CheckBox8.Image = My.Resources.Resources.icons8_november_96px
        CheckBox8.Location = New Point(423, 348)
        CheckBox8.Name = "CheckBox8"
        CheckBox8.Size = New Size(96, 110)
        CheckBox8.TabIndex = 16
        CheckBox8.TextImageRelation = TextImageRelation.TextAboveImage
        CheckBox8.UseVisualStyleBackColor = True
        ' 
        ' CheckBox9
        ' 
        CheckBox9.AutoSize = True
        CheckBox9.CheckAlign = ContentAlignment.BottomCenter
        CheckBox9.Image = My.Resources.Resources.icons8_october_96px
        CheckBox9.Location = New Point(321, 348)
        CheckBox9.Name = "CheckBox9"
        CheckBox9.Size = New Size(96, 110)
        CheckBox9.TabIndex = 15
        CheckBox9.TextImageRelation = TextImageRelation.TextAboveImage
        CheckBox9.UseVisualStyleBackColor = True
        ' 
        ' CheckBox10
        ' 
        CheckBox10.AutoSize = True
        CheckBox10.CheckAlign = ContentAlignment.BottomCenter
        CheckBox10.Image = CType(resources.GetObject("CheckBox10.Image"), Image)
        CheckBox10.Location = New Point(219, 348)
        CheckBox10.Name = "CheckBox10"
        CheckBox10.Size = New Size(96, 110)
        CheckBox10.TabIndex = 14
        CheckBox10.TextImageRelation = TextImageRelation.TextAboveImage
        CheckBox10.UseVisualStyleBackColor = True
        ' 
        ' CheckBox11
        ' 
        CheckBox11.AutoSize = True
        CheckBox11.CheckAlign = ContentAlignment.BottomCenter
        CheckBox11.Image = My.Resources.Resources.icons8_august_96px
        CheckBox11.Location = New Point(117, 348)
        CheckBox11.Name = "CheckBox11"
        CheckBox11.Size = New Size(96, 110)
        CheckBox11.TabIndex = 13
        CheckBox11.TextImageRelation = TextImageRelation.TextAboveImage
        CheckBox11.UseVisualStyleBackColor = True
        ' 
        ' CheckBox12
        ' 
        CheckBox12.AutoSize = True
        CheckBox12.CheckAlign = ContentAlignment.BottomCenter
        CheckBox12.Image = My.Resources.Resources.icons8_july_96px
        CheckBox12.Location = New Point(15, 348)
        CheckBox12.Name = "CheckBox12"
        CheckBox12.Size = New Size(96, 110)
        CheckBox12.TabIndex = 12
        CheckBox12.TextImageRelation = TextImageRelation.TextAboveImage
        CheckBox12.UseVisualStyleBackColor = True
        ' 
        ' IconButton1
        ' 
        IconButton1.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        IconButton1.IconChar = FontAwesome.Sharp.IconChar.None
        IconButton1.IconColor = Color.Black
        IconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton1.Location = New Point(257, 464)
        IconButton1.Name = "IconButton1"
        IconButton1.Size = New Size(119, 57)
        IconButton1.TabIndex = 18
        IconButton1.Text = "CREATE"
        IconButton1.UseVisualStyleBackColor = False
        ' 
        ' createDailyForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(794, 564)
        Controls.Add(IconButton1)
        Controls.Add(CheckBox7)
        Controls.Add(CheckBox8)
        Controls.Add(CheckBox9)
        Controls.Add(CheckBox10)
        Controls.Add(CheckBox11)
        Controls.Add(CheckBox12)
        Controls.Add(CheckBox6)
        Controls.Add(CheckBox5)
        Controls.Add(CheckBox4)
        Controls.Add(CheckBox3)
        Controls.Add(CheckBox2)
        Controls.Add(CheckBox1)
        Controls.Add(Panel2)
        Controls.Add(btnOpenFolder)
        Controls.Add(btnRefresh)
        Controls.Add(txtYear)
        Controls.Add(Panel1)
        Name = "createDailyForm"
        Text = "createDailyForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents txtYear As TextBox
    Friend WithEvents btnRefresh As FontAwesome.Sharp.IconButton
    Friend WithEvents btnOpenFolder As FontAwesome.Sharp.IconButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox9 As CheckBox
    Friend WithEvents CheckBox10 As CheckBox
    Friend WithEvents CheckBox11 As CheckBox
    Friend WithEvents CheckBox12 As CheckBox
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
End Class
