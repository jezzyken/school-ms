<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUser
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
        txtFname = New TextBox()
        txtMname = New TextBox()
        txtLname = New TextBox()
        txtUsername = New TextBox()
        cboRole = New ComboBox()
        txtPassword = New TextBox()
        btnSave = New Button()
        btnUpdate = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' txtFname
        ' 
        txtFname.Location = New Point(74, 80)
        txtFname.Name = "txtFname"
        txtFname.Size = New Size(264, 23)
        txtFname.TabIndex = 0
        ' 
        ' txtMname
        ' 
        txtMname.Location = New Point(74, 129)
        txtMname.Name = "txtMname"
        txtMname.Size = New Size(264, 23)
        txtMname.TabIndex = 1
        ' 
        ' txtLname
        ' 
        txtLname.Location = New Point(74, 188)
        txtLname.Name = "txtLname"
        txtLname.Size = New Size(264, 23)
        txtLname.TabIndex = 2
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(74, 258)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(264, 23)
        txtUsername.TabIndex = 3
        ' 
        ' cboRole
        ' 
        cboRole.FormattingEnabled = True
        cboRole.Items.AddRange(New Object() {"Admin", "Teacher"})
        cboRole.Location = New Point(74, 395)
        cboRole.Name = "cboRole"
        cboRole.Size = New Size(264, 23)
        cboRole.TabIndex = 4
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(74, 322)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(264, 23)
        txtPassword.TabIndex = 5
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(220, 453)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(118, 23)
        btnSave.TabIndex = 6
        btnSave.Text = "SAVE"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(108, 463)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(75, 23)
        btnUpdate.TabIndex = 7
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(256, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 15)
        Label1.TabIndex = 8
        Label1.Text = "Label1"
        ' 
        ' FrmUser
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(422, 590)
        Controls.Add(Label1)
        Controls.Add(btnUpdate)
        Controls.Add(btnSave)
        Controls.Add(txtPassword)
        Controls.Add(cboRole)
        Controls.Add(txtUsername)
        Controls.Add(txtLname)
        Controls.Add(txtMname)
        Controls.Add(txtFname)
        Name = "FrmUser"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FrmUser"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtFname As TextBox
    Friend WithEvents txtMname As TextBox
    Friend WithEvents txtLname As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents cboRole As ComboBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Label1 As Label
End Class
