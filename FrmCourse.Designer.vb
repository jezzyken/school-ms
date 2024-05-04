<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCourse
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
        GroupBox2 = New GroupBox()
        cboDepartments = New ComboBox()
        Label5 = New Label()
        Label6 = New Label()
        txtCourseName = New TextBox()
        btnSave = New Button()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(cboDepartments)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(txtCourseName)
        GroupBox2.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(12, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(305, 162)
        GroupBox2.TabIndex = 21
        GroupBox2.TabStop = False
        GroupBox2.Text = "Course Information"
        ' 
        ' cboDepartments
        ' 
        cboDepartments.Font = New Font("Century Gothic", 12F)
        cboDepartments.FormattingEnabled = True
        cboDepartments.Items.AddRange(New Object() {"Admin", "Teacher"})
        cboDepartments.Location = New Point(20, 113)
        cboDepartments.Name = "cboDepartments"
        cboDepartments.Size = New Size(264, 29)
        cboDepartments.TabIndex = 22
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 9F)
        Label5.Location = New Point(20, 93)
        Label5.Name = "Label5"
        Label5.Size = New Size(81, 17)
        Label5.TabIndex = 10
        Label5.Text = "Department"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 9F)
        Label6.Location = New Point(20, 32)
        Label6.Name = "Label6"
        Label6.Size = New Size(49, 17)
        Label6.TabIndex = 9
        Label6.Text = "Course"
        ' 
        ' txtCourseName
        ' 
        txtCourseName.Font = New Font("Century Gothic", 12F)
        txtCourseName.Location = New Point(20, 50)
        txtCourseName.Name = "txtCourseName"
        txtCourseName.Size = New Size(264, 27)
        txtCourseName.TabIndex = 3
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(238, 180)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 31)
        btnSave.TabIndex = 22
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' FrmCourse
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(325, 238)
        Controls.Add(btnSave)
        Controls.Add(GroupBox2)
        Name = "FrmCourse"
        Text = "FrmCourse"
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCourseName As TextBox
    Friend WithEvents cboDepartments As ComboBox
    Friend WithEvents btnSave As Button
End Class
