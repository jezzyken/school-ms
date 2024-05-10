Public Class FrmMain


    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlMain.Controls.Clear()
        Dim _uctrlAdminDashboard As New UctrlAdminDashboard
        pnlMain.Controls.Add(_uctrlAdminDashboard)
    End Sub

    Private Sub btnDepartments_Click(sender As Object, e As EventArgs) Handles btnDepartments.Click
        pnlMain.Controls.Clear
        Dim _uctrlDepartments As New UctrlDepartments
        pnlMain.Controls.Add(_uctrlDepartments)
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        pnlMain.Controls.Clear
        Dim _uctrlUsers As New UctrlUsers
        pnlMain.Controls.Add(_uctrlUsers)
    End Sub

    Private Sub btnTeachers_Click(sender As Object, e As EventArgs) Handles btnTeachers.Click
        pnlMain.Controls.Clear()
        Dim _uctrlTeachers As New UctrlTeachers()
        pnlMain.Controls.Add(_uctrlTeachers)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        pnlMain.Controls.Clear()
        Dim _uctrlAdminDashboard As New UctrlAdminDashboard
        pnlMain.Controls.Add(_uctrlAdminDashboard)
    End Sub

    Private Sub btnCourses_Click(sender As Object, e As EventArgs) Handles btnCourses.Click
        pnlMain.Controls.Clear()
        Dim _uctrlcourses As New UctrlCourses
        pnlMain.Controls.Add(_uctrlcourses)
    End Sub

    Private Sub btnSubjects_Click(sender As Object, e As EventArgs) Handles btnSubjects.Click
        pnlMain.Controls.Clear()
        Dim _uctrlSubjects As New UctrlSubjects
        pnlMain.Controls.Add(_uctrlSubjects)
    End Sub

    Private Sub btnStudents_Click(sender As Object, e As EventArgs) Handles btnStudents.Click
        pnlMain.Controls.Clear()
        Dim _uctrlStudents As New UctrlStudents
        pnlMain.Controls.Add(_uctrlStudents)
    End Sub

    Private Sub btnEnroll_Click(sender As Object, e As EventArgs) Handles btnEnroll.Click
        pnlMain.Controls.Clear()
        Dim _uctrlEnrollments As New UctrlEnrollments
        pnlMain.Controls.Add(_uctrlEnrollments)
    End Sub

    Private Sub pnlMain_Layout(sender As Object, e As LayoutEventArgs) Handles pnlMain.Layout
        For Each ctrl As Control In pnlMain.Controls
            ctrl.Width = pnlMain.ClientSize.Width - SystemInformation.VerticalScrollBarWidth
        Next
    End Sub
End Class
