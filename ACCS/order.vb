Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class order
    Private Sub Panel1_Scroll(sender As Object, e As ScrollEventArgs) Handles Panel1.Scroll
        If e.ScrollOrientation = ScrollOrientation.VerticalScroll Then
            Panel1.VerticalScroll.Value = e.NewValue
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Debug.WriteLine("ComboBox1_SelectedIndexChanged triggered") ' Debug statement

        ' Clear existing items in ComboBox2 and ComboBox3
        ComboBox2.Items.Clear()
        ComboBox3.Items.Clear()
        ComboBox4.Items.Clear()

        ' Determine the selected airline
        Dim selectedAirline As String = ComboBox1.SelectedItem.ToString()
        Debug.WriteLine("Selected Airline: " & selectedAirline) ' Debug statement

        ' Populate ComboBox2 based on the selected airline
        Select Case selectedAirline
            Case "Air India"
                ' Add cities for Air India to ComboBox2
                ComboBox2.Items.Add("Atlanta Georgia")
                ComboBox2.Items.Add("Garhoud Dubai")
                ComboBox2.Items.Add("Dallas–Fort Worth Texas")
                ' Populate ComboBox4 with seat options
                For i As Integer = 1 To 62
                    ComboBox4.Items.Add(i.ToString())
                Next i
            Case "Vistara"
                ' Add cities for Vistara to ComboBox2
                ComboBox2.Items.Add("Hillingdon London")
                ComboBox2.Items.Add("Ōta Tokyo")
                ComboBox2.Items.Add("Denver Colorado")
                ' Populate ComboBox4 with seat options
                For i As Integer = 1 To 70
                    ComboBox4.Items.Add(i.ToString())
                Next i
            Case "Indigo"
                ' Add cities for Vistara to ComboBox2
                ComboBox2.Items.Add("Singapore Changi Airport")
                ComboBox2.Items.Add("Indira Gandhi International Airport")
                ComboBox2.Items.Add("Istanbul Airport")
                ' Populate ComboBox4 with seat options
                For i As Integer = 1 To 112
                    ComboBox4.Items.Add(i.ToString())
                Next i

            Case Else
                ' Handle other cases or provide default behavior
        End Select
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Debug.WriteLine("ComboBox2_SelectedIndexChanged triggered") ' Debug statement

        ' Clear existing items in ComboBox3
        ComboBox3.Items.Clear()

        ' Determine the selected city
        Dim selectedCity As String = ComboBox2.SelectedItem.ToString()
        Debug.WriteLine("Selected City: " & selectedCity) ' Debug statement

        ' Populate ComboBox3 based on the selected city
        Select Case selectedCity
            Case "Atlanta Georgia"
                ' Add flight times for Atlanta Georgia to ComboBox3
                ComboBox3.Items.Add("6:50")
                ComboBox3.Items.Add("9:17")
                ComboBox3.Items.Add("20:20")
            Case "Garhoud Dubai"
                ' Add flight times for Garhoud Dubai to ComboBox3
                ComboBox3.Items.Add("8:30")
                ComboBox3.Items.Add("14:20")
                ComboBox3.Items.Add("22:19")
            Case "Dallas–Fort Worth Texas"
                ComboBox3.Items.Add("9:50")
                ComboBox3.Items.Add("12:13")
                ComboBox3.Items.Add("23:45")
            ' Add flight times for Dallas–Fort Worth Texas to ComboBox3
            ' You can add flight times for this city if needed
            Case "Hillingdon London"
                ' Add flight times for Hillingdon London to ComboBox3
                ComboBox3.Items.Add("9:50")
                ComboBox3.Items.Add("12:17")
                ComboBox3.Items.Add("21:20")
            Case "Ōta Tokyo"
                ' Add flight times for Ōta Tokyo to ComboBox3
                ComboBox3.Items.Add("2:30")
                ComboBox3.Items.Add("15:20")
                ComboBox3.Items.Add("23:19")
            Case "Denver Colorado"
                ComboBox3.Items.Add("1:30")
                ComboBox3.Items.Add("6:15")
                ComboBox3.Items.Add("19:39")
                ' Add flight times for Denver Colorado to ComboBox3
                ' You can add flight times for this city if needed

            Case "Singapore Changi Airport"

                ComboBox3.Items.Add("3:22")
                ComboBox3.Items.Add("11:55")
                ComboBox3.Items.Add("21:01")
            Case "Indira Gandhi International Airport"

                ComboBox3.Items.Add("2:30")
                ComboBox3.Items.Add("15:20")
                ComboBox3.Items.Add("23:19")
            Case "Istanbul Airport"
                ComboBox3.Items.Add("5:40")
                ComboBox3.Items.Add("15:00")
                ComboBox3.Items.Add("20:05")
            Case Else
                ' Handle other cases or provide default behavior
        End Select
    End Sub

    ''Private Sub order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'TODO: This line of code loads data into the 'Login_newDataSet.Table' table. You can move, or remove it, as needed.
    '' Me.TableTableAdapter.Fill(Me.Login_newDataSet.Table)

    ''End Sub



    ''order process adding the items 

    Public Sub AddToDataGridView(quantity As Integer, itemName As String, total As Integer)
        ' Access DataGridView from the other form
        Dim dgv As DataGridView = Me.DataGridView1

        ' Add data to DataGridView
        dgv.Rows.Add(itemName, quantity, total)
    End Sub



    '' connecting sql sending the Data 

    Private Sub InsertData()
        ' Connect to SQL Server
        Dim connectionString As String = "Data Source=LAPTOP-CGL76E1N\SQLEXPRESS;Initial Catalog=ACS;Integrated Security=True"
        Dim query As String = "INSERT INTO OrderDetails (itemname, quantity, total, airline, place, deptime, seatno, name, dateval) VALUES (@DataGridViewColumn1, @DataGridViewColumn2, @DataGridViewColumn3, @ComboBox1, @ComboBox2, @ComboBox3, @ComboBox4, @TextBoxValue, @DatePickerValue)"

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            ' Iterate through DataGridView rows to collect data
            For Each row As DataGridViewRow In DataGridView1.Rows
                If Not row.IsNewRow Then
                    Dim itemname As String = row.Cells("Itemname").Value.ToString()
                    Dim quantity As String = row.Cells("Quantity").Value.ToString()
                    Dim total As String = row.Cells("total").Value.ToString()

                    ' Get values from ComboBoxes, TextBox, and DateTimePicker
                    Dim airline As String = ComboBox1.Text
                    Dim place As String = ComboBox2.Text
                    Dim deptime As String = ComboBox3.Text
                    Dim seatno As String = ComboBox4.Text
                    Dim name As String = TextBox1.Text
                    Dim dateval As DateTime = DateTimePicker1.Value

                    ' Create and execute the INSERT command
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@DataGridViewColumn1", itemname)
                        command.Parameters.AddWithValue("@DataGridViewColumn2", quantity)
                        command.Parameters.AddWithValue("@DataGridViewColumn3", total)
                        command.Parameters.AddWithValue("@ComboBox1", airline)
                        command.Parameters.AddWithValue("@ComboBox2", place)
                        command.Parameters.AddWithValue("@ComboBox3", deptime)
                        command.Parameters.AddWithValue("@ComboBox4", seatno)
                        command.Parameters.AddWithValue("@TextBoxValue", name)
                        command.Parameters.AddWithValue("@DatePickerValue", dateval)

                        command.ExecuteNonQuery()
                    End Using
                End If
            Next

            MessageBox.Show("Data inserted successfully.")
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Call InsertData method when the button is clicked
        InsertData()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Home.Show()
    End Sub
End Class


