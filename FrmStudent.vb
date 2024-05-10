Imports System.Security.Policy
Imports MySql.Data.MySqlClient
Imports SchoolMS.UctrlStudentList

Public Class FrmStudent
    Inherits Form

    Public Event OperationSuccessful()

    Private _studentId As Integer
    Private _lrn As String
    Private _fname As String
    Private _mname As String
    Private _lname As String
    Private _courseId As Integer
    Private _yearLevel As String
    Private _term As String
    Private _status As String
    Private _isUpdate As Boolean = False

    Public Sub New()
        InitializeComponent()
        cboCourses.DataSource = GetCourseList()
        cboCourses.DisplayMember = "course"
        cboCourses.ValueMember = "id"
        btnSave.Text = "Add"
        _isUpdate = False
    End Sub


    Private Sub InitializeListView()
        LsvItems.Columns.Clear()
        LsvItems.Columns.Add("ID", 0)
        LsvItems.Columns.Add("Course Code", 100)
        LsvItems.Columns.Add("Subject", 250)
        LsvItems.Columns.Add("Units", 50)
        LsvItems.FullRowSelect = True
        LsvItems.GridLines = True
        LsvItems.View = View.Details
        LoadSubjects()
    End Sub

    Private Sub LoadSubjects()
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Using cmd As New MySqlCommand("GetSubjectsByStudentId", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@param_student_id", 1)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    LsvItems.Items.Clear()
                    While reader.Read()
                        With LsvItems.Items.Add(reader("SubjectID").ToString())
                            .SubItems.Add(reader("SubjectName").ToString())
                            .SubItems.Add(reader("CourseCode").ToString())
                            .SubItems.Add(reader("Units").ToString())
                        End With
                    End While
                End Using
            End Using
        End Using
    End Sub

    Public Sub New(studentId As Integer, lrn As String, fname As String, mname As String, lname As String, courseId As Integer, yearLevel As String, term As String, status As String)
        InitializeComponent()
        InitializeListView()
        _studentId = studentId
        _fname = fname
        _mname = mname
        _lname = lname
        _courseId = courseId
        _yearLevel = yearLevel
        _term = term
        _status = status
        _lrn = lrn

        ' Set control values
        txtFname.Text = _fname
        txtMname.Text = _mname
        txtLname.Text = _lname
        txtLrn.Text = _lrn

        cboCourses.DataSource = GetCourseList()
        cboCourses.DisplayMember = "course"
        cboCourses.ValueMember = "id"
        cboCourses.SelectedValue = _courseId
        'txtYearLevel.Text = _yearLevel
        cboTerm.Text = _term
        cboStatus.Text = _status

        btnSave.Text = "Update"
        _isUpdate = True
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

    ' Function to add or update a student
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If _isUpdate Then
            If UpdateStudent() Then
                MessageBox.Show("Student updated successfully", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Close()
                RaiseEvent OperationSuccessful()
            Else
                MessageBox.Show("Failed to update student", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            If AddStudent() Then
                MessageBox.Show("Student added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RaiseEvent OperationSuccessful()
                Close()
            Else
                MessageBox.Show("Failed to add student", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Function AddStudent() As Boolean
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Dim transaction As MySqlTransaction = conn.BeginTransaction()
            Try
                Dim sql As String = "INSERT INTO tbl_students (fname, mname, lname, course_id, year_level, term, status) VALUES (@fname, @mname, @lname, @course_id, @year_level, @term, @status)"
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Transaction = transaction
                    cmd.Parameters.AddWithValue("@fname", txtFname.Text)
                    cmd.Parameters.AddWithValue("@mname", txtMname.Text)
                    cmd.Parameters.AddWithValue("@lname", txtLname.Text)
                    cmd.Parameters.AddWithValue("@course_id", cboCourses.SelectedValue)
                    'cmd.Parameters.AddWithValue("@year_level", txtYearLevel.Text)
                    cmd.Parameters.AddWithValue("@term", cboTerm.Text)
                    cmd.Parameters.AddWithValue("@status", cboStatus.Text)
                    cmd.ExecuteNonQuery()
                End Using

                ' Commit transaction
                transaction.Commit()
                Return True
            Catch ex As Exception
                ' Rollback transaction on error
                transaction.Rollback()
                MessageBox.Show("Failed to add student: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End Using
    End Function

    Private Function UpdateStudent() As Boolean
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Dim transaction As MySqlTransaction = conn.BeginTransaction()
            Try
                Dim sql As String = "UPDATE tbl_students SET fname = @fname, mname = @mname, lname = @lname, course_id = @course_id, year_level = @year_level, term = @term, status = @status WHERE id = @studentId"
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Transaction = transaction
                    cmd.Parameters.AddWithValue("@studentId", _studentId)
                    cmd.Parameters.AddWithValue("@fname", txtFname.Text)
                    cmd.Parameters.AddWithValue("@mname", txtMname.Text)
                    cmd.Parameters.AddWithValue("@lname", txtLname.Text)
                    cmd.Parameters.AddWithValue("@course_id", cboCourses.SelectedValue)
                    'cmd.Parameters.AddWithValue("@year_level", txtYearLevel.Text)
                    cmd.Parameters.AddWithValue("@term", cboTerm.Text)
                    cmd.Parameters.AddWithValue("@status", cboStatus.Text)
                    cmd.ExecuteNonQuery()
                End Using

                ' Commit the transaction
                transaction.Commit()
                Return True
            Catch ex As Exception
                ' Roll back the transaction on error
                transaction.Rollback()
                MessageBox.Show("Failed to update student: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End Using
    End Function





End Class
