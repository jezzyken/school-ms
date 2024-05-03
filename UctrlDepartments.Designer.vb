<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UctrlDepartments
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
        btnDelete = New Button()
        btnUpdate = New Button()
        txtItem = New TextBox()
        btnAdd = New Button()
        Panel2 = New Panel()
        LsvItems = New ListView()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btnDelete)
        Panel1.Controls.Add(btnUpdate)
        Panel1.Controls.Add(txtItem)
        Panel1.Controls.Add(btnAdd)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(984, 62)
        Panel1.TabIndex = 0
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(509, 20)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 23)
        btnDelete.TabIndex = 3
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(590, 20)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(75, 23)
        btnUpdate.TabIndex = 2
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' txtItem
        ' 
        txtItem.Location = New Point(681, 20)
        txtItem.Name = "txtItem"
        txtItem.Size = New Size(206, 23)
        txtItem.TabIndex = 1
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(893, 20)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 23)
        btnAdd.TabIndex = 0
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(LsvItems)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 62)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(984, 649)
        Panel2.TabIndex = 1
        ' 
        ' LsvItems
        ' 
        LsvItems.Dock = DockStyle.Fill
        LsvItems.FullRowSelect = True
        LsvItems.Location = New Point(0, 0)
        LsvItems.Name = "LsvItems"
        LsvItems.Size = New Size(984, 649)
        LsvItems.TabIndex = 0
        LsvItems.UseCompatibleStateImageBehavior = False
        LsvItems.View = View.Details
        ' 
        ' UctrlDepartments
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "UctrlDepartments"
        Size = New Size(984, 711)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnAdd As Button
    Friend WithEvents LsvItems As ListView
    Friend WithEvents txtItem As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button

End Class
