Imports System.Data.SqlClient

Public Class Form1
    Dim connectionString As String = "Data Source=LAPTOP-CGL76E1N\SQLEXPRESS;Initial Catalog=ACS;Integrated Security=True"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = TextBox1.Text
        Dim password As String = TextBox2.Text
        Dim isAdminChecked As Boolean = CheckBox1.Checked

        If ValidateUser(username, password) Then
            MessageBox.Show("Login Successful!")

            If isAdminChecked AndAlso IsAdmin(username, password) Then
                MessageBox.Show("Admin login detected. Opening admin form.")
                Me.Hide()
                Dim Admin As New Admin()
                Admin.Show()
            Else
                Me.Hide()
                Dim Home As New Home() ' Assuming Home is the name of your home form
                Home.Show()
            End If
        Else
            MessageBox.Show("Invalid username or password. Please try again.")
        End If
    End Sub

    Private Function ValidateUser(username As String, password As String) As Boolean
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT COUNT(*) FROM Login_new WHERE username = @username AND password = @password"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@username", username)
                    command.Parameters.AddWithValue("@password", password)

                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

                    Return count > 0
                End Using
            Catch ex As Exception
                MessageBox.Show("An error occurred while validating user: " & ex.Message)
                Return False
            End Try



        End Using
    End Function

    Private Function IsAdmin(username As String, password As String) As Boolean
        ' Check if the provided username and password belong to an admin
        ' You can implement your own logic to determine if a user is an admin or not
        ' For example, you might have a separate column in your database to indicate admin status
        ' Here, I'll just hardcode an example admin username and password
        Return username = "admin" AndAlso password = "admin123"
    End Function

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Form2.Show()
    End Sub
End Class


