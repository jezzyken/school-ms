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
        btnSave = New Button()
        cboDepartments = New ComboBox()
        txtMname = New TextBox()
        txtFname = New TextBox()
        txtLname = New TextBox()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        Label2 = New Label()
        GroupBox1 = New GroupBox()
        Label7 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        Label5 = New Label()
        Label6 = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnSave
        ' 
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Century Gothic", 9.75F)
        btnSave.Location = New Point(212, 471)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(103, 31)
        btnSave.TabIndex = 15
        btnSave.Text = "SAVE"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' cboDepartments
        ' 
        cboDepartments.Font = New Font("Century Gothic", 12F)
        cboDepartments.FormattingEnabled = True
        cboDepartments.Items.AddRange(New Object() {"Admin", "Teacher"})
        cboDepartments.Location = New Point(17, 235)
        cboDepartments.Name = "cboDepartments"
        cboDepartments.Size = New Size(264, 29)
        cboDepartments.TabIndex = 17
        ' 
        ' txtMname
        ' 
        txtMname.Font = New Font("Century Gothic", 12F)
        txtMname.Location = New Point(17, 109)
        txtMname.Name = "txtMname"
        txtMname.Size = New Size(264, 27)
        txtMname.TabIndex = 1
        ' 
        ' txtFname
        ' 
        txtFname.Font = New Font("Century Gothic", 12F)
        txtFname.Location = New Point(17, 47)
        txtFname.Name = "txtFname"
        txtFname.Size = New Size(264, 27)
        txtFname.TabIndex = 0
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
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Century Gothic", 12F)
        txtPassword.Location = New Point(20, 110)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(264, 27)
        txtPassword.TabIndex = 5
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
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(txtMname)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(cboDepartments)
        GroupBox1.Controls.Add(txtFname)
        GroupBox1.Controls.Add(txtLname)
        GroupBox1.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(10, 10)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(305, 277)
        GroupBox1.TabIndex = 19
        GroupBox1.TabStop = False
        GroupBox1.Text = "User Information"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 9F)
        Label7.Location = New Point(20, 215)
        Label7.Name = "Label7"
        Label7.Size = New Size(81, 17)
        Label7.TabIndex = 21
        Label7.Text = "Department"
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
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(txtUsername)
        GroupBox2.Controls.Add(txtPassword)
        GroupBox2.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(10, 293)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(305, 162)
        GroupBox2.TabIndex = 20
        GroupBox2.TabStop = False
        GroupBox2.Text = "Account Information"
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
        ' FrmTeacher
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(332, 514)
        Controls.Add(GroupBox1)
        Controls.Add(GroupBox2)
        Controls.Add(btnSave)
        Name = "FrmTeacher"
        Text = "Teacher"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnSave As Button
    Friend WithEvents cboDepartments As ComboBox
    Friend WithEvents txtMname As TextBox
    Friend WithEvents txtFname As TextBox
    Friend WithEvents txtLname As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
