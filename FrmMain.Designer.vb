<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Panel1 = New Panel()
        btnSubjects = New Button()
        btnStudents = New Button()
        btnDashboard = New Button()
        btnCourses = New Button()
        Button1 = New Button()
        btnDepartments = New Button()
        btnTeachers = New Button()
        btnUsers = New Button()
        pnlMain = New Panel()
        StatusStrip1 = New StatusStrip()
        ToolStripStatusLabel1 = New ToolStripStatusLabel()
        ToolStripStatusLabel2 = New ToolStripStatusLabel()
        ToolStripStatusLabel3 = New ToolStripStatusLabel()
        ToolStripStatusLabel4 = New ToolStripStatusLabel()
        Label1 = New Label()
        Panel2 = New Panel()
        Button3 = New Button()
        Panel3 = New Panel()
        Panel1.SuspendLayout()
        StatusStrip1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.MenuHighlight
        Panel1.Controls.Add(btnSubjects)
        Panel1.Controls.Add(btnStudents)
        Panel1.Controls.Add(btnDashboard)
        Panel1.Controls.Add(btnCourses)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(btnDepartments)
        Panel1.Controls.Add(btnTeachers)
        Panel1.Controls.Add(btnUsers)
        Panel1.Location = New Point(0, 43)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(200, 668)
        Panel1.TabIndex = 0
        ' 
        ' btnSubjects
        ' 
        btnSubjects.FlatStyle = FlatStyle.Flat
        btnSubjects.Font = New Font("Century Gothic", 12F)
        btnSubjects.ForeColor = SystemColors.ButtonFace
        btnSubjects.Location = New Point(12, 518)
        btnSubjects.Name = "btnSubjects"
        btnSubjects.Size = New Size(176, 46)
        btnSubjects.TabIndex = 7
        btnSubjects.Text = "Subjects"
        btnSubjects.UseVisualStyleBackColor = True
        ' 
        ' btnStudents
        ' 
        btnStudents.FlatStyle = FlatStyle.Flat
        btnStudents.Font = New Font("Century Gothic", 12F)
        btnStudents.ForeColor = SystemColors.ButtonFace
        btnStudents.Location = New Point(12, 456)
        btnStudents.Name = "btnStudents"
        btnStudents.Size = New Size(176, 46)
        btnStudents.TabIndex = 6
        btnStudents.Text = "Students"
        btnStudents.UseVisualStyleBackColor = True
        ' 
        ' btnDashboard
        ' 
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.Font = New Font("Century Gothic", 12F)
        btnDashboard.ForeColor = SystemColors.ButtonFace
        btnDashboard.Location = New Point(12, 88)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(176, 46)
        btnDashboard.TabIndex = 5
        btnDashboard.Text = "Dashboard"
        btnDashboard.UseVisualStyleBackColor = True
        ' 
        ' btnCourses
        ' 
        btnCourses.FlatStyle = FlatStyle.Flat
        btnCourses.Font = New Font("Century Gothic", 12F)
        btnCourses.ForeColor = SystemColors.ButtonFace
        btnCourses.Location = New Point(12, 394)
        btnCourses.Name = "btnCourses"
        btnCourses.Size = New Size(176, 46)
        btnCourses.TabIndex = 4
        btnCourses.Text = "Courses"
        btnCourses.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Century Gothic", 12F)
        Button1.ForeColor = SystemColors.ButtonFace
        Button1.Location = New Point(12, 332)
        Button1.Name = "Button1"
        Button1.Size = New Size(176, 46)
        Button1.TabIndex = 3
        Button1.Text = "Programs"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnDepartments
        ' 
        btnDepartments.FlatStyle = FlatStyle.Flat
        btnDepartments.Font = New Font("Century Gothic", 12F)
        btnDepartments.ForeColor = SystemColors.ButtonFace
        btnDepartments.Location = New Point(12, 271)
        btnDepartments.Name = "btnDepartments"
        btnDepartments.Size = New Size(176, 46)
        btnDepartments.TabIndex = 2
        btnDepartments.Text = "Departments"
        btnDepartments.UseVisualStyleBackColor = True
        ' 
        ' btnTeachers
        ' 
        btnTeachers.FlatStyle = FlatStyle.Flat
        btnTeachers.Font = New Font("Century Gothic", 12F)
        btnTeachers.ForeColor = SystemColors.ButtonFace
        btnTeachers.Location = New Point(12, 210)
        btnTeachers.Name = "btnTeachers"
        btnTeachers.Size = New Size(176, 46)
        btnTeachers.TabIndex = 1
        btnTeachers.Text = "Teachers"
        btnTeachers.UseVisualStyleBackColor = True
        ' 
        ' btnUsers
        ' 
        btnUsers.FlatAppearance.BorderColor = Color.White
        btnUsers.FlatStyle = FlatStyle.Flat
        btnUsers.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnUsers.ForeColor = SystemColors.ButtonFace
        btnUsers.ImageAlign = ContentAlignment.MiddleLeft
        btnUsers.Location = New Point(12, 149)
        btnUsers.Name = "btnUsers"
        btnUsers.Size = New Size(176, 46)
        btnUsers.TabIndex = 0
        btnUsers.Text = "Users"
        btnUsers.UseVisualStyleBackColor = True
        ' 
        ' pnlMain
        ' 
        pnlMain.Location = New Point(206, 54)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(968, 631)
        pnlMain.TabIndex = 1
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Dock = DockStyle.None
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel1, ToolStripStatusLabel2, ToolStripStatusLabel3, ToolStripStatusLabel4})
        StatusStrip1.Location = New Point(200, 689)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(904, 22)
        StatusStrip1.TabIndex = 2
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' ToolStripStatusLabel1
        ' 
        ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        ToolStripStatusLabel1.Size = New Size(54, 17)
        ToolStripStatusLabel1.Text = "Login as:"
        ' 
        ' ToolStripStatusLabel2
        ' 
        ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        ToolStripStatusLabel2.Size = New Size(43, 17)
        ToolStripStatusLabel2.Text = "Admin"
        ' 
        ' ToolStripStatusLabel3
        ' 
        ToolStripStatusLabel3.Margin = New Padding(700, 3, 0, 2)
        ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        ToolStripStatusLabel3.Size = New Size(31, 17)
        ToolStripStatusLabel3.Text = "Date"
        ' 
        ' ToolStripStatusLabel4
        ' 
        ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        ToolStripStatusLabel4.Size = New Size(59, 17)
        ToolStripStatusLabel4.Text = "Date Now"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(59, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(301, 22)
        Label1.TabIndex = 3
        Label1.Text = "SCHOOL MANAGEMENT SYSTEM"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(Button3)
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(Label1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1184, 49)
        Panel2.TabIndex = 3
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Red
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.White
        Button3.Location = New Point(1134, 7)
        Button3.Name = "Button3"
        Button3.Size = New Size(40, 28)
        Button3.TabIndex = 4
        Button3.Text = "X"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), Image)
        Panel3.BackgroundImageLayout = ImageLayout.Center
        Panel3.Location = New Point(0, -1)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(62, 49)
        Panel3.TabIndex = 0
        ' 
        ' FrmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(1184, 711)
        Controls.Add(StatusStrip1)
        Controls.Add(pnlMain)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Name = "FrmMain"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel1.ResumeLayout(False)
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Public WithEvents btnDepartments As Button
    Public WithEvents btnTeachers As Button
    Friend WithEvents btnUsers As Button
    Friend WithEvents pnlMain As Panel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Public WithEvents btnCourses As Button
    Public WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button3 As Button
    Public WithEvents btnDashboard As Button
    Public WithEvents btnStudents As Button
    Public WithEvents btnSubjects As Button

End Class
