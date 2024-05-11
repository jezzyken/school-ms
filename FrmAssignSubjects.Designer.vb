<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAssignSubjects
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
        Button2 = New Button()
        Button1 = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(UctrlStudentList)
        GroupBox1.Location = New Point(3, 26)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(776, 172)
        GroupBox1.TabIndex = 4
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
        GroupBox2.Location = New Point(3, 204)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(776, 211)
        GroupBox2.TabIndex = 5
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
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(701, 421)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 7
        Button2.Text = "Save"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(6, 421)
        Button1.Name = "Button1"
        Button1.Size = New Size(160, 23)
        Button1.TabIndex = 6
        Button1.Text = "Remove From List"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' FrmAssignSubjects
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(783, 471)
        Controls.Add(GroupBox1)
        Controls.Add(GroupBox2)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "FrmAssignSubjects"
        Text = "FrmAssignSubjects"
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents UctrlStudentList As UctrlStudentList
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LsvAssignItems As ListView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
