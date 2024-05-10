<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UctrlStudentList
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
        LsvItems = New ListView()
        SuspendLayout()
        ' 
        ' LsvItems
        ' 
        LsvItems.Dock = DockStyle.Fill
        LsvItems.FullRowSelect = True
        LsvItems.GridLines = True
        LsvItems.Location = New Point(0, 0)
        LsvItems.Name = "LsvItems"
        LsvItems.Size = New Size(720, 151)
        LsvItems.TabIndex = 0
        LsvItems.UseCompatibleStateImageBehavior = False
        LsvItems.View = View.Details
        ' 
        ' UctrlStudentList
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(LsvItems)
        Name = "UctrlStudentList"
        Size = New Size(720, 151)
        ResumeLayout(False)
    End Sub

    Friend WithEvents LsvItems As ListView

End Class
