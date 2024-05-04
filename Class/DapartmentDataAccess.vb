Imports MySql.Data.MySqlClient

Public Class DepartmentDataAccess

    Private Const SQL_SELECT_DEPARTMENTS As String = "SELECT * FROM tbl_departments"
    Private Const SQL_INSERT_DEPARTMENT As String = "INSERT INTO tbl_departments (department) VALUES (@department)"
    Private Const SQL_UPDATE_DEPARTMENT As String = "UPDATE tbl_departments SET department = @department WHERE id = @id"
    Private Const SQL_DELETE_DEPARTMENT As String = "DELETE FROM tbl_departments WHERE id = @id"

    Public Function getItem() As List(Of Department)
        Dim departments As New List(Of Department)()
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Using cmd As New MySqlCommand(SQL_SELECT_DEPARTMENTS, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        departments.Add(New Department(reader("id"), reader("department")))
                    End While
                End Using
            End Using
        End Using
        Return departments
    End Function

    Public Function addItem(department As String) As Boolean
        Return ExecuteNonQuery(SQL_INSERT_DEPARTMENT, department)
    End Function

    Public Function updateItem(id As Integer, department As String) As Boolean
        Return ExecuteNonQuery(SQL_UPDATE_DEPARTMENT, department, id)
    End Function

    Public Function deleteItem(id As Integer) As Boolean
        Return ExecuteNonQuery(SQL_DELETE_DEPARTMENT, id:=id)
    End Function

    Private Function ExecuteNonQuery(sql As String, Optional department As String = Nothing, Optional id As Integer? = Nothing) As Boolean
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Using cmd As New MySqlCommand(sql, conn)
                If department IsNot Nothing Then cmd.Parameters.AddWithValue("@department", department)
                If id.HasValue Then cmd.Parameters.AddWithValue("@id", id.Value)
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

End Class

Public Class Department
    Public Property Id As Integer
    Public Property Name As String

    Public Sub New(id As Integer, name As String)
        Me.Id = id
        Me.Name = name
    End Sub
End Class
