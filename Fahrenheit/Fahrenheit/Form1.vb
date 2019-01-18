Public Class Form1
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        ' Declare variables
        Dim decFahrenheit As Decimal
        Dim decCelsius As Decimal
        ' Catch runtime errors
        Try
            ' Input from Fahrenheit TextBox
            decFahrenheit = CDec(txtFahrenheit.Text)
            ' Convert Fahrenheit to Celsius
            decCelsius = CDec((decFahrenheit - 32) / 1.8)
            ' Display Celsius
            lblCelsius.Text = decCelsius.ToString("n1")
        Catch ex As Exception
            ' Display error message
            MessageBox.Show("Please enter a numeric value")
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear text
        txtFahrenheit.Clear()
        lblCelsius.Text = String.Empty
    End Sub
End Class
