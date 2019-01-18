Public Class Form1

    Private Sub btnEnterSales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnterSales.Click
        Const intNUM_DAYS As Integer = 5
        Dim intCount As Integer = 1 ' Initialize Loop Counter
        Dim decSales As Decimal
        Dim decTotal As Decimal = 0
        Dim strInput As String
        ' Get the sales for each day
        Do While intCount <= intNUM_DAYS ' Test Condition
            ' Get a daily sales amount from the user
            strInput = InputBox("Enter the sales for day " & intCount.ToString)
            ' Convert the input to a decimal
            If Decimal.TryParse(strInput, decSales) Then
                ' Add daily sales to total
                decTotal += decSales
                ' Add 1 to the Loop Counter
                intCount += 1
            Else
                MessageBox.Show("Enter a numeric value.")
            End If
        Loop
        ' Display total sales
        lblTotal.Text = decTotal.ToString("c")
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
