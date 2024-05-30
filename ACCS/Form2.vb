Imports System.Data.SqlClient

Public Class Form2
    Dim connectionString As String = "Data Source=LAPTOP-CGL76E1N\SQLEXPRESS;Initial Catalog=ACS;Integrated Security=True"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = TextBox1.Text.Trim()
        Dim password As String = TextBox2.Text
        Dim email As String = TextBox3.Text.Trim()

        ' Validate input fields
        If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) OrElse String.IsNullOrWhiteSpace(email) Then
            MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Validate email format
        If Not IsValidEmail(email) Then
            MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Validate username length
        If username.Length < 10 Then
            MessageBox.Show("Username must be at least 10 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Validate password length
        If password.Length < 8 Then
            MessageBox.Show("Password must be at least 8 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Hash the password for security
        Dim hashedPassword As String = HashPassword(password)

        ' Insert user information into the registration table
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "INSERT INTO registration1 (username, password, email) VALUES (@username, @password, @email)"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Username", username)
                    command.Parameters.AddWithValue("@Password", hashedPassword)
                    command.Parameters.AddWithValue("@Email", email)
                    command.ExecuteNonQuery()
                End Using
                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Registration failed. Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

        ' Insert user information into the login_new table
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "INSERT INTO Login_new (username, password) VALUES (@username, @password)"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Username", username)
                    command.Parameters.AddWithValue("@Password", hashedPassword)
                    command.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                MessageBox.Show("Insert into Login_new table failed. Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub



    Private Function IsValidEmail(email As String) As Boolean
        Try
            Dim addr As New System.Net.Mail.MailAddress(email)
            Return addr.Address = email
        Catch
            Return False
        End Try
    End Function

    Private Function HashPassword(password As String) As String
        ' Implement password hashing algorithm (e.g., using BCrypt, SHA256, etc.)
        ' For demonstration purposes, we'll just return the original password
        Return password
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form1.Show()

    End Sub
End Class
