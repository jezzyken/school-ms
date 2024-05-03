<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTeacher
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
        btnUpdate = New Button()
        btnSave = New Button()
        txtPassword = New TextBox()
        cboRole = New ComboBox()
        txtUsername = New TextBox()
        txtLname = New TextBox()
        txtMname = New TextBox()
        txtFname = New TextBox()
        cboDepartments = New ComboBox()
        SuspendLayout()
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(54, 445)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(75, 23)
        btnUpdate.TabIndex = 16
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(200, 445)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(118, 23)
        btnSave.TabIndex = 15
        btnSave.Text = "SAVE"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(54, 294)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(264, 23)
        txtPassword.TabIndex = 14
        ' 
        ' cboRole
        ' 
        cboRole.FormattingEnabled = True
        cboRole.Items.AddRange(New Object() {"Admin", "Teacher"})
        cboRole.Location = New Point(54, 346)
        cboRole.Name = "cboRole"
        cboRole.Size = New Size(264, 23)
        cboRole.TabIndex = 13
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(54, 230)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(264, 23)
        txtUsername.TabIndex = 12
        ' 
        ' txtLname
        ' 
        txtLname.Location = New Point(54, 160)
        txtLname.Name = "txtLname"
        txtLname.Size = New Size(264, 23)
        txtLname.TabIndex = 11
        ' 
        ' txtMname
        ' 
        txtMname.Location = New Point(54, 101)
        txtMname.Name = "txtMname"
        txtMname.Size = New Size(264, 23)
        txtMname.TabIndex = 10
        ' 
        ' txtFname
        ' 
        txtFname.Location = New Point(54, 52)
        txtFname.Name = "txtFname"
        txtFname.Size = New Size(264, 23)
        txtFname.TabIndex = 9
        ' 
        ' cboDepartments
        ' 
        cboDepartments.FormattingEnabled = True
        cboDepartments.Items.AddRange(New Object() {"Admin", "Teacher"})
        cboDepartments.Location = New Point(54, 396)
        cboDepartments.Name = "cboDepartments"
        cboDepartments.Size = New Size(264, 23)
        cboDepartments.TabIndex = 17
        ' 
        ' FrmTeacher
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(367, 514)
        Controls.Add(cboDepartments)
        Controls.Add(btnUpdate)
        Controls.Add(btnSave)
        Controls.Add(txtPassword)
        Controls.Add(cboRole)
        Controls.Add(txtUsername)
        Controls.Add(txtLname)
        Controls.Add(txtMname)
        Controls.Add(txtFname)
        Name = "FrmTeacher"
        Text = "FrmTeacher"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents cboRole As ComboBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtLname As TextBox
    Friend WithEvents txtMname As TextBox
    Friend WithEvents txtFname As TextBox
    Friend WithEvents cboDepartments As ComboBox
End Class
