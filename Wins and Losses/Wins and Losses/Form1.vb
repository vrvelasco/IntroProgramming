Public Class Form1
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Try ' For code and errors
            ' Declare variables
            Dim intWins As Integer
            Dim intLosses As Integer
            Dim strName, strCity As String
            Dim intTotalWins As Integer
            Dim decPercentage As Decimal
            ' Input User's Name and City strings
            strName = txtName.Text
            strCity = txtCity.Text
            intWins = CInt(txtWins.Text)
            intLosses = CInt(txtLosses.Text)
            ' Concatenate Name and City
            lblNameCity.Text = strName & ", " & strCity
            ' Math
            intTotalWins = intWins + intLosses
            decPercentage = CDec(intWins / intTotalWins)
            ' Output data
            lblTotalGames.Text = intTotalWins.ToString()
            lblPerWins.Text = decPercentage.ToString("p")
            ' Confirm success
            lblMessage.Text = "Results complete!"
        Catch ex As Exception
            lblMessage.Text = "ERROR - Invalid values entered!" ' Error message
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear text
        txtName.Clear()
        txtCity.Clear()
        txtWins.Clear()
        txtLosses.Clear()
        lblNameCity.Text = String.Empty
        lblTotalGames.Text = String.Empty
        lblPerWins.Text = String.Empty
        lblMessage.Text = "Enter values above to calculate..."
        ' Return focus to txtName
        txtName.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() ' Closes form
    End Sub
End Class
