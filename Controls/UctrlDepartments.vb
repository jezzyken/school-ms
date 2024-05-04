Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class UctrlDepartments

    Private _dapartmentDataAccess As New DepartmentDataAccess()

    Private Sub UctrlDepartments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeListView()
        LoadDepartments()
    End Sub

    Private Sub InitializeListView()
        LsvItems.Columns.Clear()
        LsvItems.Columns.Add("ID", 120, HorizontalAlignment.Left)
        LsvItems.Columns.Add("Name", 200, HorizontalAlignment.Left)
    End Sub

    Private Sub LoadDepartments()
        LsvItems.Items.Clear()
        For Each dept In _dapartmentDataAccess.getItem()
            With LsvItems.Items.Add(dept.Id.ToString())
                .SubItems.Add(dept.Name)
            End With
        Next
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If _dapartmentDataAccess.addItem(txtItem.Text) Then
            LoadDepartments()
            ClearInput()
        Else
            MessageBox.Show("Failed to add department.")
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If LsvItems.SelectedItems.Count > 0 Then
            Dim selectedId As Integer = Convert.ToInt32(LsvItems.SelectedItems(0).Text)
            If _dapartmentDataAccess.updateItem(selectedId, txtItem.Text) Then
                LoadDepartments()
                ClearInput()
            Else
                MessageBox.Show("Failed to update department.")
            End If
        Else
            MessageBox.Show("Please select a department to update.")
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If LsvItems.SelectedItems.Count > 0 Then
            Dim selectedId As Integer = Convert.ToInt32(LsvItems.SelectedItems(0).Text)
            If _dapartmentDataAccess.deleteItem(selectedId) Then
                LoadDepartments()
                ClearInput()
            Else
                MessageBox.Show("Failed to delete department.")
            End If
        Else
            MessageBox.Show("Please select a department to delete.")
        End If
    End Sub

    Private Sub LsvItems_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LsvItems.SelectedIndexChanged
        If LsvItems.SelectedItems.Count > 0 Then
            txtItem.Text = LsvItems.SelectedItems(0).SubItems(1).Text
        Else
            ClearInput()
        End If
    End Sub

    Private Sub ClearInput()
        txtItem.Text = ""
    End Sub

End Class
