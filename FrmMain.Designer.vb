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
        Panel1 = New Panel()
        btnDepartments = New Button()
        btnTeachers = New Button()
        btnUsers = New Button()
        pnlMain = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btnDepartments)
        Panel1.Controls.Add(btnTeachers)
        Panel1.Controls.Add(btnUsers)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(200, 711)
        Panel1.TabIndex = 0
        ' 
        ' btnDepartments
        ' 
        btnDepartments.Location = New Point(24, 189)
        btnDepartments.Name = "btnDepartments"
        btnDepartments.Size = New Size(151, 33)
        btnDepartments.TabIndex = 2
        btnDepartments.Text = "Departments"
        btnDepartments.UseVisualStyleBackColor = True
        ' 
        ' btnTeachers
        ' 
        btnTeachers.Location = New Point(24, 139)
        btnTeachers.Name = "btnTeachers"
        btnTeachers.Size = New Size(151, 33)
        btnTeachers.TabIndex = 1
        btnTeachers.Text = "Teachers"
        btnTeachers.UseVisualStyleBackColor = True
        ' 
        ' btnUsers
        ' 
        btnUsers.Location = New Point(24, 87)
        btnUsers.Name = "btnUsers"
        btnUsers.Size = New Size(151, 33)
        btnUsers.TabIndex = 0
        btnUsers.Text = "Users"
        btnUsers.UseVisualStyleBackColor = True
        ' 
        ' pnlMain
        ' 
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(200, 0)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(984, 711)
        pnlMain.TabIndex = 1
        ' 
        ' FrmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(1184, 711)
        Controls.Add(pnlMain)
        Controls.Add(Panel1)
        Name = "FrmMain"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Public WithEvents btnDepartments As Button
    Public WithEvents btnTeachers As Button
    Friend WithEvents btnUsers As Button
    Friend WithEvents pnlMain As Panel

End Class
