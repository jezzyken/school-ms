﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UctrlEnrollments
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Panel1 = New Panel()
        UctrlStudentList = New UctrlStudentList()
        Panel2 = New Panel()
        TextBox1 = New TextBox()
        Button1 = New Button()
        txtLRN = New TextBox()
        GroupBox1 = New GroupBox()
        Label1 = New Label()
        Label2 = New Label()
        cboStatus = New ComboBox()
        GroupBox2 = New GroupBox()
        Label3 = New Label()
        Label5 = New Label()
        txtMname = New TextBox()
        Label4 = New Label()
        txtLname = New TextBox()
        txtFname = New TextBox()
        cboYearLevel = New ComboBox()
        cboCourses = New ComboBox()
        Label6 = New Label()
        Panel3 = New Panel()
        LsvSelectedSubjects = New ListView()
        GroupBox3 = New GroupBox()
        LsvSubjectItems = New ListView()
        Y = New Label()
        Label8 = New Label()
        cboSchoolYear = New ComboBox()
        Label9 = New Label()
        cboSemester = New ComboBox()
        btnQuerySubject = New Button()
        btnSave = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        Panel3.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(UctrlStudentList)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(3, 23)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(941, 187)
        Panel1.TabIndex = 0
        ' 
        ' UctrlStudentList
        ' 
        UctrlStudentList.Dock = DockStyle.Fill
        UctrlStudentList.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        UctrlStudentList.Location = New Point(0, 51)
        UctrlStudentList.Name = "UctrlStudentList"
        UctrlStudentList.Size = New Size(941, 136)
        UctrlStudentList.TabIndex = 2
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(Button1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(941, 51)
        Panel2.TabIndex = 1
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Century Gothic", 9.75F)
        TextBox1.Location = New Point(646, 14)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(210, 23)
        TextBox1.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Century Gothic", 9.75F)
        Button1.Location = New Point(855, 14)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 0
        Button1.Text = "Search"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' txtLRN
        ' 
        txtLRN.Font = New Font("Century Gothic", 9.75F)
        txtLRN.Location = New Point(6, 106)
        txtLRN.Name = "txtLRN"
        txtLRN.Size = New Size(199, 23)
        txtLRN.TabIndex = 1
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Panel1)
        GroupBox1.Font = New Font("Century Gothic", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(9, 14)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(947, 213)
        GroupBox1.TabIndex = 6
        GroupBox1.TabStop = False
        GroupBox1.Text = "Student List"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 9.75F)
        Label1.Location = New Point(6, 86)
        Label1.Name = "Label1"
        Label1.Size = New Size(32, 17)
        Label1.TabIndex = 7
        Label1.Text = "LRN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 9.75F)
        Label2.Location = New Point(6, 27)
        Label2.Name = "Label2"
        Label2.Size = New Size(46, 17)
        Label2.TabIndex = 9
        Label2.Text = "Status"
        ' 
        ' cboStatus
        ' 
        cboStatus.Font = New Font("Century Gothic", 9.75F)
        cboStatus.FormattingEnabled = True
        cboStatus.Items.AddRange(New Object() {"New", "Old"})
        cboStatus.Location = New Point(6, 51)
        cboStatus.Name = "cboStatus"
        cboStatus.Size = New Size(199, 25)
        cboStatus.TabIndex = 10
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = SystemColors.Control
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(txtMname)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(txtLname)
        GroupBox2.Controls.Add(txtFname)
        GroupBox2.Controls.Add(cboStatus)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(txtLRN)
        GroupBox2.Font = New Font("Century Gothic", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(3, 245)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(227, 343)
        GroupBox2.TabIndex = 11
        GroupBox2.TabStop = False
        GroupBox2.Text = "Student Information"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 9.75F)
        Label3.Location = New Point(6, 142)
        Label3.Name = "Label3"
        Label3.Size = New Size(75, 17)
        Label3.TabIndex = 21
        Label3.Text = "First Name"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 9.75F)
        Label5.Location = New Point(6, 199)
        Label5.Name = "Label5"
        Label5.Size = New Size(95, 17)
        Label5.TabIndex = 16
        Label5.Text = "Middle Name"
        ' 
        ' txtMname
        ' 
        txtMname.Font = New Font("Century Gothic", 9.75F)
        txtMname.Location = New Point(6, 219)
        txtMname.Name = "txtMname"
        txtMname.Size = New Size(199, 23)
        txtMname.TabIndex = 15
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 9.75F)
        Label4.Location = New Point(6, 252)
        Label4.Name = "Label4"
        Label4.Size = New Size(77, 17)
        Label4.TabIndex = 14
        Label4.Text = "Last Name"
        ' 
        ' txtLname
        ' 
        txtLname.Font = New Font("Century Gothic", 9.75F)
        txtLname.Location = New Point(6, 272)
        txtLname.Name = "txtLname"
        txtLname.Size = New Size(199, 23)
        txtLname.TabIndex = 13
        ' 
        ' txtFname
        ' 
        txtFname.Font = New Font("Century Gothic", 9.75F)
        txtFname.Location = New Point(6, 162)
        txtFname.Name = "txtFname"
        txtFname.Size = New Size(199, 23)
        txtFname.TabIndex = 11
        ' 
        ' cboYearLevel
        ' 
        cboYearLevel.Font = New Font("Century Gothic", 9.75F)
        cboYearLevel.FormattingEnabled = True
        cboYearLevel.Items.AddRange(New Object() {"First Year", "Second Year", "Third Year", "Forth Year"})
        cboYearLevel.Location = New Point(552, 281)
        cboYearLevel.Name = "cboYearLevel"
        cboYearLevel.Size = New Size(152, 25)
        cboYearLevel.TabIndex = 20
        ' 
        ' cboCourses
        ' 
        cboCourses.Font = New Font("Century Gothic", 9.75F)
        cboCourses.FormattingEnabled = True
        cboCourses.Items.AddRange(New Object() {"New", "Old"})
        cboCourses.Location = New Point(236, 281)
        cboCourses.Name = "cboCourses"
        cboCourses.Size = New Size(152, 25)
        cboCourses.TabIndex = 18
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 9.75F)
        Label6.Location = New Point(236, 257)
        Label6.Name = "Label6"
        Label6.Size = New Size(53, 17)
        Label6.TabIndex = 17
        Label6.Text = "Course"
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(LsvSelectedSubjects)
        Panel3.Location = New Point(233, 476)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(720, 112)
        Panel3.TabIndex = 22
        ' 
        ' LsvSelectedSubjects
        ' 
        LsvSelectedSubjects.Dock = DockStyle.Fill
        LsvSelectedSubjects.GridLines = True
        LsvSelectedSubjects.Location = New Point(0, 0)
        LsvSelectedSubjects.Name = "LsvSelectedSubjects"
        LsvSelectedSubjects.Size = New Size(720, 112)
        LsvSelectedSubjects.TabIndex = 0
        LsvSelectedSubjects.UseCompatibleStateImageBehavior = False
        LsvSelectedSubjects.View = View.Details
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = SystemColors.Control
        GroupBox3.Controls.Add(LsvSubjectItems)
        GroupBox3.Font = New Font("Century Gothic", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox3.Location = New Point(236, 314)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(717, 156)
        GroupBox3.TabIndex = 23
        GroupBox3.TabStop = False
        GroupBox3.Text = "Available Subjects"
        ' 
        ' LsvSubjectItems
        ' 
        LsvSubjectItems.Dock = DockStyle.Fill
        LsvSubjectItems.GridLines = True
        LsvSubjectItems.Location = New Point(3, 18)
        LsvSubjectItems.Name = "LsvSubjectItems"
        LsvSubjectItems.Size = New Size(711, 135)
        LsvSubjectItems.TabIndex = 0
        LsvSubjectItems.UseCompatibleStateImageBehavior = False
        LsvSubjectItems.View = View.Details
        ' 
        ' Y
        ' 
        Y.AutoSize = True
        Y.Font = New Font("Century Gothic", 9.75F)
        Y.Location = New Point(552, 257)
        Y.Name = "Y"
        Y.Size = New Size(73, 17)
        Y.TabIndex = 24
        Y.Text = "Year Level"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 9.75F)
        Label8.Location = New Point(710, 261)
        Label8.Name = "Label8"
        Label8.Size = New Size(83, 17)
        Label8.TabIndex = 26
        Label8.Text = "School Year"
        ' 
        ' cboSchoolYear
        ' 
        cboSchoolYear.Font = New Font("Century Gothic", 9.75F)
        cboSchoolYear.FormattingEnabled = True
        cboSchoolYear.Items.AddRange(New Object() {"2021-2022", "2023-2024", "2025-2026", "2027-2028", "2029-2030", "2031-2032", "2033-2034"})
        cboSchoolYear.Location = New Point(710, 281)
        cboSchoolYear.Name = "cboSchoolYear"
        cboSchoolYear.Size = New Size(152, 25)
        cboSchoolYear.TabIndex = 25
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 9.75F)
        Label9.Location = New Point(394, 257)
        Label9.Name = "Label9"
        Label9.Size = New Size(38, 17)
        Label9.TabIndex = 29
        Label9.Text = "Term"
        ' 
        ' cboSemester
        ' 
        cboSemester.Font = New Font("Century Gothic", 9.75F)
        cboSemester.FormattingEnabled = True
        cboSemester.Items.AddRange(New Object() {"First Term", "Second Term"})
        cboSemester.Location = New Point(394, 281)
        cboSemester.Name = "cboSemester"
        cboSemester.Size = New Size(152, 25)
        cboSemester.TabIndex = 28
        ' 
        ' btnQuerySubject
        ' 
        btnQuerySubject.FlatStyle = FlatStyle.Flat
        btnQuerySubject.Location = New Point(867, 281)
        btnQuerySubject.Name = "btnQuerySubject"
        btnQuerySubject.Size = New Size(84, 25)
        btnQuerySubject.TabIndex = 30
        btnQuerySubject.Text = "FIND"
        btnQuerySubject.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(876, 594)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 23)
        btnSave.TabIndex = 34
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' UctrlEnrollments
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(btnSave)
        Controls.Add(btnQuerySubject)
        Controls.Add(Label9)
        Controls.Add(cboSemester)
        Controls.Add(Label8)
        Controls.Add(cboSchoolYear)
        Controls.Add(Y)
        Controls.Add(GroupBox3)
        Controls.Add(Panel3)
        Controls.Add(cboYearLevel)
        Controls.Add(cboCourses)
        Controls.Add(GroupBox2)
        Controls.Add(Label6)
        Controls.Add(GroupBox1)
        Name = "UctrlEnrollments"
        Size = New Size(968, 631)
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        Panel3.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents UctrlStudentList As UctrlStudentList
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtLRN As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cboYearLevel As ComboBox
    Friend WithEvents cboCourses As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLname As TextBox
    Friend WithEvents txtFname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Y As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cboSchoolYear As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cboSemester As ComboBox
    Friend WithEvents LsvSubjectItems As ListView
    Friend WithEvents btnQuerySubject As Button
    Friend WithEvents LsvSelectedSubjects As ListView
    Friend WithEvents btnSave As Button

End Class
