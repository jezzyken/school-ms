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
        Label2 = New Label()
        GroupBox1 = New GroupBox()
        Label3 = New Label()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtFname
        ' 
        txtFname.Font = New Font("Century Gothic", 12F)
        txtFname.Location = New Point(17, 47)
        txtFname.Name = "txtFname"
        txtFname.Size = New Size(264, 27)
        txtFname.TabIndex = 0
        ' 
        ' txtMname
        ' 
        txtMname.Font = New Font("Century Gothic", 12F)
        txtMname.Location = New Point(17, 109)
        txtMname.Name = "txtMname"
        txtMname.Size = New Size(264, 27)
        txtMname.TabIndex = 1
        ' 
        ' txtLname
        ' 
        txtLname.Font = New Font("Century Gothic", 12F)
        txtLname.Location = New Point(17, 171)
        txtLname.Name = "txtLname"
        txtLname.Size = New Size(264, 27)
        txtLname.TabIndex = 2
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Century Gothic", 12F)
        txtUsername.Location = New Point(20, 50)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(264, 27)
        txtUsername.TabIndex = 3
        ' 
        ' cboRole
        ' 
        cboRole.Font = New Font("Century Gothic", 12F)
        cboRole.FormattingEnabled = True
        cboRole.Items.AddRange(New Object() {"Admin", "Teacher"})
        cboRole.Location = New Point(20, 164)
        cboRole.Name = "cboRole"
        cboRole.Size = New Size(264, 29)
        cboRole.TabIndex = 4
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Century Gothic", 12F)
        txtPassword.Location = New Point(20, 110)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(264, 27)
        txtPassword.TabIndex = 5
        ' 
        ' btnSave
        ' 
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSave.Location = New Point(214, 491)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(103, 31)
        btnSave.TabIndex = 6
        btnSave.Text = "SAVE"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 9F)
        Label2.Location = New Point(17, 30)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 17)
        Label2.TabIndex = 9
        Label2.Text = "First Name"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(txtMname)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(txtFname)
        GroupBox1.Controls.Add(txtLname)
        GroupBox1.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(12, 30)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(305, 216)
        GroupBox1.TabIndex = 10
        GroupBox1.TabStop = False
        GroupBox1.Text = "User Information"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 9F)
        Label3.Location = New Point(17, 154)
        Label3.Name = "Label3"
        Label3.Size = New Size(71, 17)
        Label3.TabIndex = 11
        Label3.Text = "Last Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 9F)
        Label1.Location = New Point(17, 92)
        Label1.Name = "Label1"
        Label1.Size = New Size(88, 17)
        Label1.TabIndex = 10
        Label1.Text = "Middle Name"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(txtUsername)
        GroupBox2.Controls.Add(txtPassword)
        GroupBox2.Controls.Add(cboRole)
        GroupBox2.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(12, 258)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(305, 217)
        GroupBox2.TabIndex = 12
        GroupBox2.TabStop = False
        GroupBox2.Text = "Account Information"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 9F)
        Label4.Location = New Point(20, 147)
        Label4.Name = "Label4"
        Label4.Size = New Size(34, 17)
        Label4.TabIndex = 11
        Label4.Text = "Role"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 9F)
        Label5.Location = New Point(20, 93)
        Label5.Name = "Label5"
        Label5.Size = New Size(63, 17)
        Label5.TabIndex = 10
        Label5.Text = "Password"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 9F)
        Label6.Location = New Point(20, 32)
        Label6.Name = "Label6"
        Label6.Size = New Size(39, 17)
        Label6.TabIndex = 9
        Label6.Text = "Email"
        ' 
        ' FrmUser
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(329, 531)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(btnSave)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "FrmUser"
        StartPosition = FormStartPosition.CenterScreen
        Text = "User"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents txtFname As TextBox
    Friend WithEvents txtMname As TextBox
    Friend WithEvents txtLname As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents cboRole As ComboBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
