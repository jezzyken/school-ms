Imports MySql.Data.MySqlClient

Public Class FrmSubject
    Inherits Form

    Public Event OperationSuccessful()

    Private _subjectId As Integer
    Private _units As Integer
    Private _term As String
    Private _courseCode As String
    Private _subjectName As String
    Private _level As String
    Private _courseId As Integer
    Private _isUpdate As Boolean = False

    Public Sub New()
        InitializeComponent()
        InitializeComboBoxes()
        btnSave.Text = "Add"
    End Sub

    Public Sub New(subjectId As Integer, units As Integer, term As String, courseCode As String, subjectName As String, level As String, courseId As Integer)
        InitializeComponent()
        _subjectId = subjectId
        _units = units
        _term = term
        _courseCode = courseCode
        _subjectName = subjectName
        _level = level
        _courseId = courseId

        numUnits.Value = _units
        txtCourseCode.Text = _courseCode
        txtSubjectName.Text = _subjectName

        InitializeComboBoxes()

        cboTerm.SelectedItem = _term
        cboLevel.SelectedItem = _level
        cboCourses.SelectedValue = _courseId

        btnSave.Text = "Update"
        _isUpdate = True
    End Sub

    Private Sub InitializeComboBoxes()
        cboCourses.DataSource = GetCourseList()
        cboCourses.DisplayMember = "course"
        cboCourses.ValueMember = "id"
    End Sub

    Private Function GetCourseList() As DataTable
        Using conn As MySqlConnection = GetConnection()
            Dim sql As String = "SELECT * FROM tbl_courses"
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
            If UpdateSubject() Then
                MessageBox.Show("Subject updated successfully", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RaiseEvent OperationSuccessful()
                Close()
            Else
                MessageBox.Show("Failed to update subject", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            If AddSubject() Then
                MessageBox.Show("Subject added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RaiseEvent OperationSuccessful()
                Close()
            Else
                MessageBox.Show("Failed to add subject", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Function AddSubject() As Boolean
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Dim sql As String = "INSERT INTO tbl_subjects (units, term, course_id, level, course_code, subject_name) VALUES (@units, @term, @course_id, @level, @course_code, @subject_name)"
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@units", Convert.ToInt32(numUnits.Value))
                cmd.Parameters.AddWithValue("@term", cboTerm.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@course_id", Convert.ToInt32(cboCourses.SelectedValue))
                cmd.Parameters.AddWithValue("@level", cboLevel.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@course_code", txtCourseCode.Text)
                cmd.Parameters.AddWithValue("@subject_name", txtSubjectName.Text)
                cmd.ExecuteNonQuery()
                Return True
            End Using
        End Using
    End Function

    Private Function UpdateSubject() As Boolean
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Dim sql As String = "UPDATE tbl_subjects SET units = @units, term = @term, course_id = @course_id, level = @level, course_code = @course_code, subject_name = @subject_name WHERE id = @subjectId"
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@subjectId", _subjectId)
                cmd.Parameters.AddWithValue("@units", Convert.ToInt32(numUnits.Value))
                cmd.Parameters.AddWithValue("@term", cboTerm.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@course_id", Convert.ToInt32(cboCourses.SelectedValue))
                cmd.Parameters.AddWithValue("@level", cboLevel.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@course_code", txtCourseCode.Text)
                cmd.Parameters.AddWithValue("@subject_name", txtSubjectName.Text)
                cmd.ExecuteNonQuery()
                Return True
            End Using
        End Using
    End Function
End Class
