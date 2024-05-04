<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSubject
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
        txtCourseCode = New TextBox()
        cboTerm = New ComboBox()
        cboLevel = New ComboBox()
        cboCourses = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        txtSubjectName = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        btnSave = New Button()
        numUnits = New NumericUpDown()
        CType(numUnits, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtCourseCode
        ' 
        txtCourseCode.Location = New Point(195, 26)
        txtCourseCode.Name = "txtCourseCode"
        txtCourseCode.Size = New Size(142, 23)
        txtCourseCode.TabIndex = 0
        ' 
        ' cboTerm
        ' 
        cboTerm.FormattingEnabled = True
        cboTerm.Items.AddRange(New Object() {"First Term", "Second Term"})
        cboTerm.Location = New Point(195, 139)
        cboTerm.Name = "cboTerm"
        cboTerm.Size = New Size(142, 23)
        cboTerm.TabIndex = 1
        ' 
        ' cboLevel
        ' 
        cboLevel.FormattingEnabled = True
        cboLevel.Items.AddRange(New Object() {"First Year", "Second Year", "Third Year", "Forth Year"})
        cboLevel.Location = New Point(36, 139)
        cboLevel.Name = "cboLevel"
        cboLevel.Size = New Size(142, 23)
        cboLevel.TabIndex = 2
        ' 
        ' cboCourses
        ' 
        cboCourses.FormattingEnabled = True
        cboCourses.Location = New Point(36, 26)
        cboCourses.Name = "cboCourses"
        cboCourses.Size = New Size(142, 23)
        cboCourses.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(195, 8)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 15)
        Label1.TabIndex = 6
        Label1.Text = "Course Code"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(36, 64)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 15)
        Label2.TabIndex = 8
        Label2.Text = "Course Name"
        ' 
        ' txtSubjectName
        ' 
        txtSubjectName.Location = New Point(36, 82)
        txtSubjectName.Name = "txtSubjectName"
        txtSubjectName.Size = New Size(234, 23)
        txtSubjectName.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(276, 64)
        Label3.Name = "Label3"
        Label3.Size = New Size(34, 15)
        Label3.TabIndex = 9
        Label3.Text = "Units"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(36, 8)
        Label4.Name = "Label4"
        Label4.Size = New Size(44, 15)
        Label4.TabIndex = 10
        Label4.Text = "Course"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(36, 121)
        Label5.Name = "Label5"
        Label5.Size = New Size(34, 15)
        Label5.TabIndex = 11
        Label5.Text = "Level"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(195, 121)
        Label6.Name = "Label6"
        Label6.Size = New Size(33, 15)
        Label6.TabIndex = 12
        Label6.Text = "Term"
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(262, 215)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 23)
        btnSave.TabIndex = 13
        btnSave.Text = "Add"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' numUnits
        ' 
        numUnits.Location = New Point(276, 82)
        numUnits.Name = "numUnits"
        numUnits.Size = New Size(61, 23)
        numUnits.TabIndex = 14
        ' 
        ' FrmSubject
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(373, 250)
        Controls.Add(numUnits)
        Controls.Add(btnSave)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtSubjectName)
        Controls.Add(Label1)
        Controls.Add(cboCourses)
        Controls.Add(cboLevel)
        Controls.Add(cboTerm)
        Controls.Add(txtCourseCode)
        Name = "FrmSubject"
        Text = "FrmSubject"
        CType(numUnits, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtCourseCode As TextBox
    Friend WithEvents cboTerm As ComboBox
    Friend WithEvents cboLevel As ComboBox
    Friend WithEvents cboCourses As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSubjectName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents numUnits As NumericUpDown
End Class
