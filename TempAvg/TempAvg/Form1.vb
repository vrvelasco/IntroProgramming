Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() ' Closes form
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear text
        txtCity.Clear()
        txtState.Clear()
        txtTemp1.Clear()
        txtTemp2.Clear()
        txtTemp3.Clear()
        txtTemp4.Clear()
        txtTemp5.Clear()
        lblCityState.Text = String.Empty
        lblAvgTemp.Text = String.Empty
        ' Return focus to txtCity
        txtCity.Focus()
    End Sub

    Private Sub txtCalc_Click(sender As Object, e As EventArgs) Handles txtCalc.Click
        ' Declare variable
        Dim strCity, strState, strCityState As String
        Dim intTemp1, intTemp2, intTemp3, intTemp4, intTemp5 As Integer
        Dim decAverage As Decimal
        ' Catch runtime errors
        Try
            ' Input City and State
            strCity = txtCity.Text
            strState = txtState.Text
            ' Input Temperatures
            intTemp1 = CInt(txtTemp1.Text)
            intTemp2 = CInt(txtTemp2.Text)
            intTemp3 = CInt(txtTemp3.Text)
            intTemp4 = CInt(txtTemp4.Text)
            intTemp5 = CInt(txtTemp5.Text)
            ' Calculate average
            decAverage = (intTemp1 + intTemp2 + intTemp3 + intTemp4 + intTemp5) / 5D
            ' Concatenate City and State
            strCityState = strCity & ", " & strState
            ' Output City/State and Average
            lblCityState.Text = strCityState
            lblAvgTemp.Text = decAverage.ToString("n1")
        Catch
            MessageBox.Show("Please enter numeric values for temperatures.")
        End Try
    End Sub
End Class
