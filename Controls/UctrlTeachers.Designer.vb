﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UctrlTeachers
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
        btnDelete = New Button()
        btnUpdate = New Button()
        btnAdd = New Button()
        Panel2 = New Panel()
        Panel4 = New Panel()
        btnAssign = New Button()
        Panel1 = New Panel()
        LsvItems = New ListView()
        Panel3 = New Panel()
        btnSearch = New Button()
        TextBox1 = New TextBox()
        btnAssignSubjects = New Button()
        Panel2.SuspendLayout()
        Panel4.SuspendLayout()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnDelete
        ' 
        btnDelete.Font = New Font("Century Gothic", 9.75F)
        btnDelete.Location = New Point(743, 8)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(98, 31)
        btnDelete.TabIndex = 3
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Font = New Font("Century Gothic", 9.75F)
        btnUpdate.Location = New Point(847, 8)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(98, 31)
        btnUpdate.TabIndex = 2
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAdd.Location = New Point(870, 16)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 31)
        btnAdd.TabIndex = 0
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Panel4)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 587)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(968, 44)
        Panel2.TabIndex = 5
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.Control
        Panel4.Controls.Add(btnAssignSubjects)
        Panel4.Controls.Add(btnAssign)
        Panel4.Controls.Add(btnDelete)
        Panel4.Controls.Add(btnUpdate)
        Panel4.Dock = DockStyle.Bottom
        Panel4.Location = New Point(0, -2)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(968, 46)
        Panel4.TabIndex = 3
        ' 
        ' btnAssign
        ' 
        btnAssign.Font = New Font("Century Gothic", 9.75F)
        btnAssign.Location = New Point(15, 8)
        btnAssign.Name = "btnAssign"
        btnAssign.Size = New Size(176, 31)
        btnAssign.TabIndex = 4
        btnAssign.Text = "Asign Students"
        btnAssign.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(LsvItems)
        Panel1.Controls.Add(Panel3)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(968, 587)
        Panel1.TabIndex = 4
        ' 
        ' LsvItems
        ' 
        LsvItems.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LsvItems.FullRowSelect = True
        LsvItems.GridLines = True
        LsvItems.Location = New Point(0, 62)
        LsvItems.Name = "LsvItems"
        LsvItems.Size = New Size(968, 525)
        LsvItems.TabIndex = 6
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
        Panel3.TabIndex = 5
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
        TextBox1.Location = New Point(15, 15)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(208, 31)
        TextBox1.TabIndex = 2
        ' 
        ' btnAssignSubjects
        ' 
        btnAssignSubjects.Font = New Font("Century Gothic", 9.75F)
        btnAssignSubjects.Location = New Point(197, 8)
        btnAssignSubjects.Name = "btnAssignSubjects"
        btnAssignSubjects.Size = New Size(176, 31)
        btnAssignSubjects.TabIndex = 5
        btnAssignSubjects.Text = "Asign Subjects"
        btnAssignSubjects.UseVisualStyleBackColor = True
        ' 
        ' UctrlTeachers
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "UctrlTeachers"
        Size = New Size(968, 631)
        Panel2.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnSearch As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents LsvItems As ListView
    Friend WithEvents btnAssign As Button
    Friend WithEvents btnAssignSubjects As Button

End Class
