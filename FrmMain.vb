Public Class FrmMain

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnDepartments_Click(sender As Object, e As EventArgs) Handles btnDepartments.Click
        pnlMain.Controls.Clear()
        Dim _uctrlDepartments As New UctrlDepartments()
        pnlMain.Controls.Add(_uctrlDepartments)
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        pnlMain.Controls.Clear()
        Dim _uctrlUsers As New UctrlUsers()
        pnlMain.Controls.Add(_uctrlUsers)
    End Sub

    Private Sub btnTeachers_Click(sender As Object, e As EventArgs) Handles btnTeachers.Click
        pnlMain.Controls.Clear()
        Dim _uctrlTeachers As New UctrlTeachers()
        pnlMain.Controls.Add(_uctrlTeachers)
    End Sub
End Class
