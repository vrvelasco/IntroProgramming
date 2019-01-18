Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() ' Closes form
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear text
        txtA.Clear()
        txtB.Clear()
        txtC.Clear()
        lblRevA.Text = String.Empty
        lblRevB.Text = String.Empty
        lblRevC.Text = String.Empty
        lblTotal.Text = String.Empty
        lblMessage.Text = "Enter values above"
        ' Return focus to first TextBox
        txtA.Focus()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Try
            ' Declare values
            Dim intTicketsA As Integer
            Dim intTicketsB As Integer
            Dim intTicketsC As Integer
            Dim PriceA As Decimal
            Dim PriceB As Decimal
            Dim PriceC As Decimal
            Dim TotalPrice As Decimal
            ' User's input
            intTicketsA = CInt(txtA.Text)
            intTicketsB = CInt(txtB.Text)
            intTicketsC = CInt(txtC.Text)
            ' Math
            PriceA = 15 * intTicketsA
            PriceB = 12 * intTicketsB
            PriceC = 9 * intTicketsC
            TotalPrice = (PriceA + PriceB + PriceC)
            ' Display results
            lblRevA.Text = PriceA.ToString("c")
            lblRevB.Text = PriceB.ToString("c")
            lblRevC.Text = PriceC.ToString("c")
            lblTotal.Text = TotalPrice.ToString("c")
            lblMessage.Text = "Results displayed above"
        Catch ex As Exception
            ' Display error
            lblMessage.Text = "Please enter numeric values for each ticket class"
        End Try
    End Sub
End Class
