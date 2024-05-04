Imports MySql.Data.MySqlClient

Public Class FrmCourse

    Inherits Form

    Public Event OperationSuccessful()

    Private _courseId As Integer
    Private _courseName As String
    Private _departmentId As Integer
    Private _isUpdate As Boolean = False

    Public Sub New()
        InitializeComponent()
        cboDepartments.DataSource = GetDepartmentList()
        cboDepartments.DisplayMember = "department"
        cboDepartments.ValueMember = "id"
        btnSave.Text = "Add"
        _isUpdate = False
    End Sub

    Public Sub New(courseId As Integer, courseName As String, departmentId As Integer)
        InitializeComponent()
        _courseId = courseId
        _courseName = courseName
        _departmentId = departmentId

        ' Set control values
        txtCourseName.Text = _courseName
        cboDepartments.DataSource = GetDepartmentList()
        cboDepartments.DisplayMember = "department"
        cboDepartments.ValueMember = "id"
        cboDepartments.SelectedValue = _departmentId

        btnSave.Text = "Update"
        _isUpdate = True
    End Sub

    Private Function GetDepartmentList() As DataTable
        Using conn As MySqlConnection = GetConnection()
            Dim sql As String = "SELECT id, department FROM tbl_departments"
            Using cmd As New MySqlCommand(sql, conn)
                Using adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If _isUpdate Then
            If UpdateCourse() Then
                MessageBox.Show("Course updated successfully", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Close()  ' Optionally close the form or clear fields
                RaiseEvent OperationSuccessful()
            Else
                MessageBox.Show("Failed to update course", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            If AddCourse(txtCourseName.Text, Convert.ToInt32(cboDepartments.SelectedValue)) Then
                MessageBox.Show("Course added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RaiseEvent OperationSuccessful()
            Else
                MessageBox.Show("Failed to add course", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Function AddCourse(courseName As String, departmentId As Integer) As Boolean
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Dim sql As String = "INSERT INTO tbl_courses (course, departmentId) VALUES (@course, @departmentId)"
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@course", courseName)
                cmd.Parameters.AddWithValue("@departmentId", departmentId)
                Dim result As Integer = cmd.ExecuteNonQuery()
                Return result > 0
            End Using
        End Using
    End Function

    Private Function UpdateCourse() As Boolean
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Dim sql As String = "UPDATE tbl_courses SET course = @course, departmentId = @departmentId WHERE id = @courseId"
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@courseId", _courseId)
                cmd.Parameters.AddWithValue("@course", txtCourseName.Text)
                cmd.Parameters.AddWithValue("@departmentId", cboDepartments.SelectedValue)
                Dim result As Integer = cmd.ExecuteNonQuery()
                Return result > 0
            End Using
        End Using
    End Function

End Class
