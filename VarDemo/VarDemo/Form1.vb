Public Class Form1
    Private Sub btnShowName_Click(sender As Object, e As EventArgs) Handles btnShowName.Click
        ' Declare a string variable to hold the full name
        Dim strFullName As String
        ' Declare an integer variable to hold the age
        Dim intAge As Integer
        ' Combine first and last name and assign to full name variable
        strFullName = txtFirstName.Text & " " & txtLastName.Text
        ' Read age from text box into variable
        intAge = txtAge.Text
        ' Display the full name in the lblFullName label
        lblFullName.Text = strFullName
        ' Display age in label
        lblAge.Text = intAge

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear text boxes and labels
        txtFirstName.Clear()
        txtLastName.Clear()
        txtAge.Clear()
        lblFullName.Text = String.Empty
        lblAge.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
