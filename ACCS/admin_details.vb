Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class admin_details

    Dim connectionString As String = "Data Source=LAPTOP-CGL76E1N\SQLEXPRESS;Initial Catalog=ACS;Integrated Security=True"

    Private Sub admin_details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = getDataTable("SELECT * FROM OrderDetails")
    End Sub

    'to return table data
    Private Function getDataTable(query As String) As DataTable
        Dim dataTable As New DataTable()

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Using command As New SqlCommand(query, connection)
                    Using adapter As New SqlDataAdapter(command)
                        adapter.Fill(dataTable)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving data: " & ex.Message)
        End Try

        Return dataTable
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show() ' Ensure Form1 exists and is correctly named
    End Sub

    ' MODIFIED EDIT FUNCTION
    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        ' Update the edited row in the database
        Dim rowIndex As Integer = e.RowIndex
        Dim editedRow As DataGridViewRow = DataGridView1.Rows(rowIndex)

        Dim id As Integer = Convert.ToInt32(editedRow.Cells("ID").Value)
        Dim itemName As String = editedRow.Cells("itemname").Value.ToString()
        Dim quantity As Integer = Convert.ToInt32(editedRow.Cells("quantity").Value)
        Dim total As Decimal = Convert.ToDecimal(editedRow.Cells("total").Value)
        Dim airline As String = editedRow.Cells("airline").Value.ToString()
        Dim place As String = editedRow.Cells("place").Value.ToString()
        Dim depTime As DateTime = Convert.ToDateTime(editedRow.Cells("deptime").Value)

        Dim updateQuery As String = "UPDATE OrderDetails SET itemname = @itemname, quantity = @quantity, total = @total, airline = @airline, place = @place, deptime = @deptime WHERE ID = @ID"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(updateQuery, connection)
                command.Parameters.AddWithValue("@ID", id)
                command.Parameters.AddWithValue("@itemname", itemName)
                command.Parameters.AddWithValue("@quantity", quantity)
                command.Parameters.AddWithValue("@total", total)
                command.Parameters.AddWithValue("@airline", airline)
                command.Parameters.AddWithValue("@place", place)
                command.Parameters.AddWithValue("@deptime", depTime)

                Try
                    connection.Open()
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    MessageBox.Show(rowsAffected.ToString() & " row(s) updated successfully.")
                Catch ex As Exception
                    MessageBox.Show("Error updating row: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ToDelete As String = TextBox1.Text.Trim()
        If Not String.IsNullOrEmpty(ToDelete) Then
            Dim deleteQuery As String = "DELETE FROM OrderDetails WHERE ID = @ID"

            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(deleteQuery, connection)
                    command.Parameters.AddWithValue("@ID", ToDelete)

                    Try
                        connection.Open()
                        Dim rowsAffected As Integer = command.ExecuteNonQuery()
                        MessageBox.Show(rowsAffected.ToString() & " row(s) deleted successfully.")
                        TextBox1.Clear()
                        DataGridView1.DataSource = getDataTable("SELECT * FROM OrderDetails")
                    Catch ex As Exception
                        MessageBox.Show("Error deleting row: " & ex.Message)
                    End Try
                End Using
            End Using
        Else
            MessageBox.Show("Please enter ID to delete.")
        End If
    End Sub

End Class
