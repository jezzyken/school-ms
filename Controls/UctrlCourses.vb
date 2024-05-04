Imports MySql.Data.MySqlClient

Public Class UctrlCourses
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        OpenFormAdd()
    End Sub

    Private Sub InitializeListView()
        LsvItems.Columns.Clear()
        LsvItems.Columns.Add("ID", 50)
        LsvItems.Columns.Add("Course", 200)
        LsvItems.Columns.Add("Department ID", 200)
        LsvItems.FullRowSelect = True
        LsvItems.GridLines = True
        LsvItems.View = View.Details
        LoadCourses()
    End Sub

    Private Sub OpenFormAdd()
        Dim _frmCourse As New FrmCourse()
        AddHandler _frmCourse.OperationSuccessful, AddressOf reloadList
        _frmCourse.Show()
    End Sub

    Private Sub reloadList()
        LoadCourses()
    End Sub

    Private Sub LoadCourses()
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Dim sql As String = "SELECT * FROM course_view"
            Using cmd As New MySqlCommand(sql, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    LsvItems.Items.Clear()
                    While reader.Read()
                        With LsvItems.Items.Add(reader("id").ToString())
                            .SubItems.Add(reader("course").ToString())
                            .SubItems.Add(reader("department").ToString())
                        End With
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub OpenFormUpdate()
        If LsvItems.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select a course to edit.")
            Exit Sub
        End If

        Dim selectedItem As ListViewItem = LsvItems.SelectedItems(0)
        Dim courseId As Integer = Convert.ToInt32(selectedItem.Text)
        Dim courseName As String = selectedItem.SubItems(1).Text
        Dim departmentId As Integer = Convert.ToInt32(selectedItem.SubItems(2).Text)

        Dim frmCourse As New FrmCourse(courseId, courseName, departmentId)
        AddHandler frmCourse.OperationSuccessful, AddressOf reloadList
        frmCourse.Show()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        OpenFormUpdate()
    End Sub

    Private Sub UctrlCourses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeListView()
    End Sub

    Public Function DeleteCourse(id As Integer) As Boolean
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Dim sql As String = "DELETE FROM tbl_courses WHERE id = @id"
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@id", id)
                Dim result As Integer = cmd.ExecuteNonQuery()
                Return result > 0
            End Using
        End Using
    End Function

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If LsvItems.SelectedItems.Count > 0 Then
            Dim selectedId = Convert.ToInt32(LsvItems.SelectedItems(0).Text)
            If DeleteCourse(selectedId) Then
                LoadCourses()
                MessageBox.Show("Course deleted successfully.")
            Else
                MessageBox.Show("Failed to delete course.")
            End If
        Else
            MessageBox.Show("Please select a course to delete.")
        End If
    End Sub
End Class
