<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainFont
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
        panelMenu = New Panel()
        Label2 = New Label()
        IconPictureBox2 = New FontAwesome.Sharp.IconPictureBox()
        IconButton1 = New FontAwesome.Sharp.IconButton()
        btnUpdate = New FontAwesome.Sharp.IconButton()
        btnCalculate = New FontAwesome.Sharp.IconButton()
        btnCreate = New FontAwesome.Sharp.IconButton()
        panelLogo = New Panel()
        IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Label1 = New Label()
        PageSetupDialog1 = New PageSetupDialog()
        Panel1 = New Panel()
        panelDesktop = New Panel()
        panelMenu.SuspendLayout()
        CType(IconPictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        panelLogo.SuspendLayout()
        CType(IconPictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' panelMenu
        ' 
        panelMenu.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        panelMenu.Controls.Add(Label2)
        panelMenu.Controls.Add(IconPictureBox2)
        panelMenu.Controls.Add(IconButton1)
        panelMenu.Controls.Add(btnUpdate)
        panelMenu.Controls.Add(btnCalculate)
        panelMenu.Controls.Add(btnCreate)
        panelMenu.Controls.Add(panelLogo)
        panelMenu.Dock = DockStyle.Left
        panelMenu.Location = New Point(0, 0)
        panelMenu.Name = "panelMenu"
        panelMenu.Size = New Size(214, 450)
        panelMenu.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.GradientInactiveCaption
        Label2.Location = New Point(55, 295)
        Label2.Name = "Label2"
        Label2.Size = New Size(123, 22)
        Label2.TabIndex = 6
        Label2.Text = "Root Directory"' 
        ' IconPictureBox2
        ' 
        IconPictureBox2.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        IconPictureBox2.ForeColor = SystemColors.GradientInactiveCaption
        IconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.FolderBlank
        IconPictureBox2.IconColor = SystemColors.GradientInactiveCaption
        IconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconPictureBox2.IconSize = 45
        IconPictureBox2.Location = New Point(12, 284)
        IconPictureBox2.Name = "IconPictureBox2"
        IconPictureBox2.Size = New Size(55, 45)
        IconPictureBox2.TabIndex = 5
        IconPictureBox2.TabStop = False
        ' 
        ' IconButton1
        ' 
        IconButton1.IconChar = FontAwesome.Sharp.IconChar.None
        IconButton1.IconColor = Color.Black
        IconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton1.Location = New Point(55, 389)
        IconButton1.Name = "IconButton1"
        IconButton1.Size = New Size(75, 23)
        IconButton1.TabIndex = 4
        IconButton1.Text = "Change"
        IconButton1.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Dock = DockStyle.Top
        btnUpdate.FlatAppearance.BorderSize = 0
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.Font = New Font("Sylfaen", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnUpdate.ForeColor = SystemColors.GradientActiveCaption
        btnUpdate.IconChar = FontAwesome.Sharp.IconChar.Calendar
        btnUpdate.IconColor = Color.LightYellow
        btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnUpdate.IconSize = 32
        btnUpdate.ImageAlign = ContentAlignment.MiddleLeft
        btnUpdate.Location = New Point(0, 197)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(214, 60)
        btnUpdate.TabIndex = 3
        btnUpdate.Text = "Update Using Template"
        btnUpdate.TextImageRelation = TextImageRelation.ImageBeforeText
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Dock = DockStyle.Top
        btnCalculate.FlatAppearance.BorderSize = 0
        btnCalculate.FlatStyle = FlatStyle.Flat
        btnCalculate.Font = New Font("Sylfaen", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnCalculate.ForeColor = SystemColors.GradientActiveCaption
        btnCalculate.IconChar = FontAwesome.Sharp.IconChar.Calculator
        btnCalculate.IconColor = Color.PapayaWhip
        btnCalculate.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnCalculate.IconSize = 32
        btnCalculate.ImageAlign = ContentAlignment.MiddleLeft
        btnCalculate.Location = New Point(0, 137)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(214, 60)
        btnCalculate.TabIndex = 2
        btnCalculate.Text = "Calculate Salary"
        btnCalculate.TextImageRelation = TextImageRelation.ImageBeforeText
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' btnCreate
        ' 
        btnCreate.Dock = DockStyle.Top
        btnCreate.FlatAppearance.BorderSize = 0
        btnCreate.FlatStyle = FlatStyle.Flat
        btnCreate.Font = New Font("Sylfaen", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnCreate.ForeColor = SystemColors.GradientActiveCaption
        btnCreate.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck
        btnCreate.IconColor = Color.PapayaWhip
        btnCreate.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnCreate.IconSize = 32
        btnCreate.ImageAlign = ContentAlignment.MiddleLeft
        btnCreate.Location = New Point(0, 77)
        btnCreate.Name = "btnCreate"
        btnCreate.Size = New Size(214, 60)
        btnCreate.TabIndex = 1
        btnCreate.Text = "Create Daily Earning"
        btnCreate.TextImageRelation = TextImageRelation.ImageBeforeText
        btnCreate.UseVisualStyleBackColor = True
        ' 
        ' panelLogo
        ' 
        panelLogo.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        panelLogo.Controls.Add(IconPictureBox1)
        panelLogo.Controls.Add(Label1)
        panelLogo.Dock = DockStyle.Top
        panelLogo.Font = New Font("Sylfaen", 9F, FontStyle.Bold, GraphicsUnit.Point)
        panelLogo.ForeColor = SystemColors.GradientInactiveCaption
        panelLogo.Location = New Point(0, 0)
        panelLogo.Name = "panelLogo"
        panelLogo.Size = New Size(214, 77)
        panelLogo.TabIndex = 0
        ' 
        ' IconPictureBox1
        ' 
        IconPictureBox1.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        IconPictureBox1.ForeColor = SystemColors.GradientInactiveCaption
        IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.CalendarWeek
        IconPictureBox1.IconColor = SystemColors.GradientInactiveCaption
        IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconPictureBox1.IconSize = 45
        IconPictureBox1.Location = New Point(4, 12)
        IconPictureBox1.Name = "IconPictureBox1"
        IconPictureBox1.Size = New Size(45, 47)
        IconPictureBox1.TabIndex = 1
        IconPictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(55, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(159, 16)
        Label1.TabIndex = 0
        Label1.Text = "SALARY MANAGEMENT"' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(214, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(586, 46)
        Panel1.TabIndex = 0
        ' 
        ' panelDesktop
        ' 
        panelDesktop.Dock = DockStyle.Fill
        panelDesktop.Location = New Point(214, 46)
        panelDesktop.Name = "panelDesktop"
        panelDesktop.Size = New Size(586, 404)
        panelDesktop.TabIndex = 1
        ' 
        ' mainFont
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(panelDesktop)
        Controls.Add(Panel1)
        Controls.Add(panelMenu)
        Name = "mainFont"
        Text = "mainFont"
        panelMenu.ResumeLayout(False)
        panelMenu.PerformLayout()
        CType(IconPictureBox2, ComponentModel.ISupportInitialize).EndInit()
        panelLogo.ResumeLayout(False)
        panelLogo.PerformLayout()
        CType(IconPictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents panelMenu As Panel
    Friend WithEvents panelLogo As Panel
    Friend WithEvents btnUpdate As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCalculate As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCreate As FontAwesome.Sharp.IconButton
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents panelDesktop As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents IconPictureBox2 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
End Class
