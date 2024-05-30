Public Class dessertss
    Private Sub Panel1_Scroll(sender As Object, e As ScrollEventArgs) Handles Panel1.Scroll
        If e.ScrollOrientation = ScrollOrientation.VerticalScroll Then
            Panel1.VerticalScroll.Value = e.NewValue
        End If
    End Sub

    'Addition all
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim currentValue As Integer

        If Integer.TryParse(TextBox1.Text, currentValue) Then
            ' Increment the value by one
            currentValue += 1
            ' Update the textbox with the new value
            TextBox1.Text = currentValue.ToString()
        Else
            ' If the textbox doesn't contain a valid integer, you can handle the error here
            MessageBox.Show("Invalid value in the textbox. Please enter a valid integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim currentValue As Integer

        If Integer.TryParse(TextBox2.Text, currentValue) Then
            ' Increment the value by one
            currentValue += 1
            ' Update the textbox with the new value
            TextBox2.Text = currentValue.ToString()
        Else
            ' If the textbox doesn't contain a valid integer, you can handle the error here
            MessageBox.Show("Invalid value in the textbox. Please enter a valid integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim currentValue As Integer

        If Integer.TryParse(TextBox3.Text, currentValue) Then
            ' Increment the value by one
            currentValue += 1
            ' Update the textbox with the new value
            TextBox3.Text = currentValue.ToString()
        Else
            ' If the textbox doesn't contain a valid integer, you can handle the error here
            MessageBox.Show("Invalid value in the textbox. Please enter a valid integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim currentValue As Integer

        If Integer.TryParse(TextBox4.Text, currentValue) Then
            ' Increment the value by one
            currentValue += 1
            ' Update the textbox with the new value
            TextBox4.Text = currentValue.ToString()
        Else
            ' If the textbox doesn't contain a valid integer, you can handle the error here
            MessageBox.Show("Invalid value in the textbox. Please enter a valid integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim currentValue As Integer

        If Integer.TryParse(TextBox5.Text, currentValue) Then
            ' Increment the value by one
            currentValue += 1
            ' Update the textbox with the new value
            TextBox5.Text = currentValue.ToString()
        Else
            ' If the textbox doesn't contain a valid integer, you can handle the error here
            MessageBox.Show("Invalid value in the textbox. Please enter a valid integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim currentValue As Integer

        If Integer.TryParse(TextBox6.Text, currentValue) Then
            ' Increment the value by one
            currentValue += 1
            ' Update the textbox with the new value
            TextBox6.Text = currentValue.ToString()
        Else
            ' If the textbox doesn't contain a valid integer, you can handle the error here
            MessageBox.Show("Invalid value in the textbox. Please enter a valid integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    'Subtraction ALL

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim currentValue As Integer
        If Integer.TryParse(TextBox1.Text, currentValue) Then
            ' Check if the current value is greater than 0 before decrementing
            If currentValue > 0 Then
                ' Decrement the value by one
                currentValue -= 1
                ' Update the textbox with the new value
                TextBox1.Text = currentValue.ToString()
            Else
                ' If the current value is already 0, display a message
                MessageBox.Show("Value cannot be less than 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            ' If the textbox doesn't contain a valid integer, you can handle the error here
            MessageBox.Show("Invalid value in the textbox. Please enter a valid integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim currentValue As Integer
        If Integer.TryParse(TextBox2.Text, currentValue) Then
            ' Check if the current value is greater than 0 before decrementing
            If currentValue > 0 Then
                ' Decrement the value by one
                currentValue -= 1
                ' Update the textbox with the new value
                TextBox2.Text = currentValue.ToString()
            Else
                ' If the current value is already 0, display a message
                MessageBox.Show("Value cannot be less than 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            ' If the textbox doesn't contain a valid integer, you can handle the error here
            MessageBox.Show("Invalid value in the textbox. Please enter a valid integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim currentValue As Integer
        If Integer.TryParse(TextBox3.Text, currentValue) Then
            ' Check if the current value is greater than 0 before decrementing
            If currentValue > 0 Then
                ' Decrement the value by one
                currentValue -= 1
                ' Update the textbox with the new value
                TextBox3.Text = currentValue.ToString()
            Else
                ' If the current value is already 0, display a message
                MessageBox.Show("Value cannot be less than 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            ' If the textbox doesn't contain a valid integer, you can handle the error here
            MessageBox.Show("Invalid value in the textbox. Please enter a valid integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim currentValue As Integer
        If Integer.TryParse(TextBox4.Text, currentValue) Then
            ' Check if the current value is greater than 0 before decrementing
            If currentValue > 0 Then
                ' Decrement the value by one
                currentValue -= 1
                ' Update the textbox with the new value
                TextBox4.Text = currentValue.ToString()
            Else
                ' If the current value is already 0, display a message
                MessageBox.Show("Value cannot be less than 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            ' If the textbox doesn't contain a valid integer, you can handle the error here
            MessageBox.Show("Invalid value in the textbox. Please enter a valid integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim currentValue As Integer
        If Integer.TryParse(TextBox5.Text, currentValue) Then
            ' Check if the current value is greater than 0 before decrementing
            If currentValue > 0 Then
                ' Decrement the value by one
                currentValue -= 1
                ' Update the textbox with the new value
                TextBox5.Text = currentValue.ToString()
            Else
                ' If the current value is already 0, display a message
                MessageBox.Show("Value cannot be less than 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            ' If the textbox doesn't contain a valid integer, you can handle the error here
            MessageBox.Show("Invalid value in the textbox. Please enter a valid integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim currentValue As Integer
        If Integer.TryParse(TextBox6.Text, currentValue) Then
            ' Check if the current value is greater than 0 before decrementing
            If currentValue > 0 Then
                ' Decrement the value by one
                currentValue -= 1
                ' Update the textbox with the new value
                TextBox6.Text = currentValue.ToString()
            Else
                ' If the current value is already 0, display a message
                MessageBox.Show("Value cannot be less than 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            ' If the textbox doesn't contain a valid integer, you can handle the error here
            MessageBox.Show("Invalid value in the textbox. Please enter a valid integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub






    'order Button Working 

    ' Instantiate the Order form
    Dim order As New order()
    Private Sub CopyToOrderDataGridView(textBox As TextBox, label As Label, label2 As Label)
        ' Get the text from TextBox and Label
        Dim quantity As Integer
        If Integer.TryParse(textBox.Text, quantity) AndAlso quantity > 0 Then
            Dim itemName As String = label.Text
            Dim anotherLabelValue As String = label2.Text

            ' Calculate the total by adding the value of label2 and the text from textBox
            Dim total As Integer = Integer.Parse(label2.Text) * Integer.Parse(textBox.Text)

            ' Pass the data to a method or property on the Order form
            order.AddToDataGridView(quantity, itemName, total)

            order.Show()
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        CopyToOrderDataGridView(TextBox1, Label1, Label2)
        CopyToOrderDataGridView(TextBox2, Label4, Label3)
        CopyToOrderDataGridView(TextBox3, Label6, Label5)
        CopyToOrderDataGridView(TextBox4, Label8, Label7)
        CopyToOrderDataGridView(TextBox5, Label10, Label9)
        CopyToOrderDataGridView(TextBox6, Label12, Label11)



    End Sub
End Class