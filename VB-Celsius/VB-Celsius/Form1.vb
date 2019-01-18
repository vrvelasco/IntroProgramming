Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() ' Closes form
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear Temperature TextBox
        txtCelsius.Clear()
        lblFahrenheit.Text = "°F"
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        ' Declare value
        Dim intCelsius As Integer
        Dim decFahrenheit As Decimal
        ' For error
        If txtCelsius.Text = String.Empty Then
            ' Message to user
            MessageBox.Show("Please enter a value.")
        Else
            ' Calculation
            intCelsius = txtCelsius.Text
            decFahrenheit = (intCelsius * (9 / 5) + 32)
            lblFahrenheit.Text = decFahrenheit & "°F"
        End If
    End Sub
End Class
