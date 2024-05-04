<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UctrlUsers
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
        LsvItems = New ListView()
        Panel3 = New Panel()
        btnSearch = New Button()
        TextBox1 = New TextBox()
        btnAdd = New Button()
        btnDelete = New Button()
        btnUpdate = New Button()
        Panel2 = New Panel()
        Panel4 = New Panel()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(LsvItems)
        Panel1.Controls.Add(Panel3)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(968, 586)
        Panel1.TabIndex = 2
        ' 
        ' LsvItems
        ' 
        LsvItems.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LsvItems.FullRowSelect = True
        LsvItems.GridLines = True
        LsvItems.Location = New Point(0, 62)
        LsvItems.Name = "LsvItems"
        LsvItems.Size = New Size(968, 525)
        LsvItems.TabIndex = 5
        LsvItems.UseCompatibleStateImageBehavior = False
        LsvItems.View = View.Details
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.Control
        Panel3.Controls.Add(btnSearch)
        Panel3.Controls.Add(TextBox1)
        Panel3.Controls.Add(btnAdd)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(968, 62)
        Panel3.TabIndex = 4
        ' 
        ' btnSearch
        ' 
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.Font = New Font("Century Gothic", 9.75F)
        btnSearch.Location = New Point(221, 15)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(100, 31)
        btnSearch.TabIndex = 3
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(0, 15)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(223, 31)
        TextBox1.TabIndex = 2
        ' 
        ' btnAdd
        ' 
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.Font = New Font("Century Gothic", 9.75F)
        btnAdd.Location = New Point(893, 20)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 31)
        btnAdd.TabIndex = 0
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Font = New Font("Century Gothic", 9.75F)
        btnDelete.Location = New Point(766, 8)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(98, 31)
        btnDelete.TabIndex = 3
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Font = New Font("Century Gothic", 9.75F)
        btnUpdate.Location = New Point(870, 8)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(98, 31)
        btnUpdate.TabIndex = 2
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Panel4)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 586)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(968, 45)
        Panel2.TabIndex = 3
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.Control
        Panel4.Controls.Add(btnUpdate)
        Panel4.Controls.Add(btnDelete)
        Panel4.Dock = DockStyle.Bottom
        Panel4.Location = New Point(0, -1)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(968, 46)
        Panel4.TabIndex = 2
        ' 
        ' UctrlUsers
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "UctrlUsers"
        Size = New Size(968, 631)
        Panel1.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnSearch As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents LsvItems As ListView

End Class
