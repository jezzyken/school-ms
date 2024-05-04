Imports MySql.Data.MySqlClient

Public Class CourseDataAccess

    Private Const SQL_SELECT_COURSES As String = "SELECT * FROM tbl_courses"
    Private Const SQL_INSERT_COURSE As String = "INSERT INTO tbl_courses (course, departmentId) VALUES (@course, @departmentId)"
    Private Const SQL_UPDATE_COURSE As String = "UPDATE tbl_courses SET course = @course, departmentId = @departmentId WHERE id = @id"
    Private Const SQL_DELETE_COURSE As String = "DELETE FROM tbl_courses WHERE id = @id"

    Public Function getItem() As List(Of Course)
        Dim courses As New List(Of Course)()
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Using cmd As New MySqlCommand(SQL_SELECT_COURSES, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        courses.Add(New Course(reader("id"), reader("course"), reader("departmentId")))
                    End While
                End Using
            End Using
        End Using
        Return courses
    End Function

    Public Function addItem(course As String, departmentId As Integer) As Boolean
        Return ExecuteNonQuery(SQL_INSERT_COURSE, course, departmentId)
    End Function

    Public Function updateItem(id As Integer, course As String, departmentId As Integer) As Boolean
        Return ExecuteNonQuery(SQL_UPDATE_COURSE, course, departmentId, id)
    End Function

    Public Function deleteItem(id As Integer) As Boolean
        Return ExecuteNonQuery(SQL_DELETE_COURSE, id:=id)
    End Function

    Private Function ExecuteNonQuery(sql As String, Optional course As String = Nothing, Optional departmentId As Integer? = Nothing, Optional id As Integer? = Nothing) As Boolean
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Using cmd As New MySqlCommand(sql, conn)
                If course IsNot Nothing Then cmd.Parameters.AddWithValue("@course", course)
                If departmentId.HasValue Then cmd.Parameters.AddWithValue("@departmentId", departmentId.Value)
                If id.HasValue Then cmd.Parameters.AddWithValue("@id", id.Value)
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

End Class

Public Class Course
    Public Property Id As Integer
    Public Property CourseName As String
    Public Property DepartmentId As Integer

    Public Sub New(id As Integer, courseName As String, departmentId As Integer)
        Me.Id = id
        Me.CourseName = courseName
        Me.DepartmentId = departmentId
    End Sub
End Class
