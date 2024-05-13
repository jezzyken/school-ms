<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStudent
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
        cboCourses = New ComboBox()
        txtFname = New TextBox()
        txtMname = New TextBox()
        txtLname = New TextBox()
        cboTerm = New ComboBox()
        cboStatus = New ComboBox()
        btnSave = New Button()
        txtLrn = New TextBox()
        cboYearLevel = New ComboBox()
        GroupBox1 = New GroupBox()
        LsvItems = New ListView()
        GroupBox2 = New GroupBox()
        Label9 = New Label()
        txtSchoolYear = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' cboCourses
        ' 
        cboCourses.FormattingEnabled = True
        cboCourses.Items.AddRange(New Object() {"New", "Old"})
        cboCourses.Location = New Point(150, 106)
        cboCourses.Name = "cboCourses"
        cboCourses.Size = New Size(213, 25)
        cboCourses.TabIndex = 0
        ' 
        ' txtFname
        ' 
        txtFname.Location = New Point(9, 167)
        txtFname.Name = "txtFname"
        txtFname.Size = New Size(206, 23)
        txtFname.TabIndex = 1
        ' 
        ' txtMname
        ' 
        txtMname.Location = New Point(225, 167)
        txtMname.Name = "txtMname"
        txtMname.Size = New Size(206, 23)
        txtMname.TabIndex = 2
        ' 
        ' txtLname
        ' 
        txtLname.Location = New Point(441, 167)
        txtLname.Name = "txtLname"
        txtLname.Size = New Size(206, 23)
        txtLname.TabIndex = 3
        ' 
        ' cboTerm
        ' 
        cboTerm.FormattingEnabled = True
        cboTerm.Items.AddRange(New Object() {"New", "Old"})
        cboTerm.Location = New Point(369, 106)
        cboTerm.Name = "cboTerm"
        cboTerm.Size = New Size(136, 25)
        cboTerm.TabIndex = 5
        ' 
        ' cboStatus
        ' 
        cboStatus.FormattingEnabled = True
        cboStatus.Items.AddRange(New Object() {"New", "Old"})
        cboStatus.Location = New Point(9, 106)
        cboStatus.Name = "cboStatus"
        cboStatus.Size = New Size(135, 25)
        cboStatus.TabIndex = 6
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(616, 434)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 23)
        btnSave.TabIndex = 7
        btnSave.Text = "Button1"
        btnSave.UseVisualStyleBackColor = True
        btnSave.Visible = False
        ' 
        ' txtLrn
        ' 
        txtLrn.Location = New Point(9, 51)
        txtLrn.Name = "txtLrn"
        txtLrn.Size = New Size(194, 23)
        txtLrn.TabIndex = 8
        ' 
        ' cboYearLevel
        ' 
        cboYearLevel.FormattingEnabled = True
        cboYearLevel.Items.AddRange(New Object() {"First Year", "Second Year", "Third Year", "Forth Year"})
        cboYearLevel.Location = New Point(511, 106)
        cboYearLevel.Name = "cboYearLevel"
        cboYearLevel.Size = New Size(136, 25)
        cboYearLevel.TabIndex = 9
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(LsvItems)
        GroupBox1.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(12, 252)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(682, 176)
        GroupBox1.TabIndex = 10
        GroupBox1.TabStop = False
        GroupBox1.Text = "Subjects current taken under his/her course"
        ' 
        ' LsvItems
        ' 
        LsvItems.Dock = DockStyle.Fill
        LsvItems.Location = New Point(3, 19)
        LsvItems.Name = "LsvItems"
        LsvItems.Size = New Size(676, 154)
        LsvItems.TabIndex = 0
        LsvItems.UseCompatibleStateImageBehavior = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Controls.Add(txtSchoolYear)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(cboStatus)
        GroupBox2.Controls.Add(cboCourses)
        GroupBox2.Controls.Add(cboYearLevel)
        GroupBox2.Controls.Add(txtLname)
        GroupBox2.Controls.Add(txtMname)
        GroupBox2.Controls.Add(cboTerm)
        GroupBox2.Controls.Add(txtFname)
        GroupBox2.Controls.Add(txtLrn)
        GroupBox2.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(12, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(682, 220)
        GroupBox2.TabIndex = 11
        GroupBox2.TabStop = False
        GroupBox2.Text = "Student Information"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(453, 30)
        Label9.Name = "Label9"
        Label9.Size = New Size(83, 17)
        Label9.TabIndex = 21
        Label9.Text = "School Year"
        ' 
        ' txtSchoolYear
        ' 
        txtSchoolYear.Location = New Point(453, 51)
        txtSchoolYear.Name = "txtSchoolYear"
        txtSchoolYear.Size = New Size(194, 23)
        txtSchoolYear.TabIndex = 20
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(433, 147)
        Label8.Name = "Label8"
        Label8.Size = New Size(118, 17)
        Label8.TabIndex = 19
        Label8.Text = "Middle Lastname"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(221, 147)
        Label7.Name = "Label7"
        Label7.Size = New Size(95, 17)
        Label7.TabIndex = 18
        Label7.Text = "Middle Name"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(9, 147)
        Label5.Name = "Label5"
        Label5.Size = New Size(75, 17)
        Label5.TabIndex = 17
        Label5.Text = "First Name"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(511, 86)
        Label6.Name = "Label6"
        Label6.Size = New Size(73, 17)
        Label6.TabIndex = 16
        Label6.Text = "Year Level"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(369, 87)
        Label4.Name = "Label4"
        Label4.Size = New Size(38, 17)
        Label4.TabIndex = 15
        Label4.Text = "Term"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(150, 86)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 17)
        Label3.TabIndex = 13
        Label3.Text = "Course"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(9, 30)
        Label2.Name = "Label2"
        Label2.Size = New Size(32, 17)
        Label2.TabIndex = 12
        Label2.Text = "LRN"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(9, 86)
        Label1.Name = "Label1"
        Label1.Size = New Size(46, 17)
        Label1.TabIndex = 10
        Label1.Text = "Status"
        ' 
        ' FrmStudent
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(712, 476)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(btnSave)
        Name = "FrmStudent"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FrmStudent"
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents cboCourses As ComboBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents txtFname As TextBox
    Friend WithEvents txtMname As TextBox
    Friend WithEvents txtLname As TextBox
    Friend WithEvents cboTerm As ComboBox
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents btnSave As Button
    Friend WithEvents txtLrn As TextBox
    Friend WithEvents cboYearLevel As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LsvItems As ListView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtSchoolYear As TextBox
End Class
