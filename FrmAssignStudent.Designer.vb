<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAssignStudent
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
        GroupBox1 = New GroupBox()
        UctrlStudentList = New UctrlStudentList()
        GroupBox2 = New GroupBox()
        LsvAssignItems = New ListView()
        btnRemove = New Button()
        Button2 = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(UctrlStudentList)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(776, 172)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' UctrlStudentList
        ' 
        UctrlStudentList.Dock = DockStyle.Fill
        UctrlStudentList.Location = New Point(3, 19)
        UctrlStudentList.Name = "UctrlStudentList"
        UctrlStudentList.Size = New Size(770, 150)
        UctrlStudentList.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(LsvAssignItems)
        GroupBox2.Location = New Point(12, 190)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(776, 211)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "GroupBox2"
        ' 
        ' LsvAssignItems
        ' 
        LsvAssignItems.Dock = DockStyle.Fill
        LsvAssignItems.Location = New Point(3, 19)
        LsvAssignItems.Name = "LsvAssignItems"
        LsvAssignItems.Size = New Size(770, 189)
        LsvAssignItems.TabIndex = 0
        LsvAssignItems.UseCompatibleStateImageBehavior = False
        LsvAssignItems.View = View.Details
        ' 
        ' btnRemove
        ' 
        btnRemove.Location = New Point(15, 407)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(160, 23)
        btnRemove.TabIndex = 2
        btnRemove.Text = "Remove From List"
        btnRemove.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(710, 407)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 3
        Button2.Text = "Save"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' FrmAssignStudent
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 451)
        Controls.Add(Button2)
        Controls.Add(btnRemove)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "FrmAssignStudent"
        Text = "FrmAssignStudent"
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LsvAssignItems As ListView
    Friend WithEvents btnRemove As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents UctrlStudentList As UctrlStudentList
End Class
