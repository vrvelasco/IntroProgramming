Public Class Form1
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        ' Declare variables
        Dim strAnswer As String = "y" ' Initialize Loop Flag
        Dim strFood As String
        Dim strPrice As String
        Dim decPrice As Decimal
        Dim decTotal As Decimal
        Dim intIndex As Integer
        ' Begin shopping loop
        Do While strAnswer = "y" ' Test Loop Flag
            ' Enter food and price
            strFood = InputBox("Please enter food:", "Food item")
            strPrice = InputBox("Please enter price:", "Price of food")
            If Decimal.TryParse(strPrice, decPrice) Then
                If decPrice >= 0 Then
                    lstFood.Items.Add(strFood)
                    lstPrice.Items.Add(decPrice)
                End If
            End If
            ' Ask to keep shopping ' Update Loop Flag
            strAnswer = InputBox("Enter y to keep shopping.")
        Loop
        ' Calculate total
        intIndex = 0 ' Initialize Loop Counter
        Do While intIndex < lstPrice.Items.Count ' Test Condition
            decTotal += lstPrice.Items(intIndex)
            intIndex += 1 ' Increment Loop Counter
        Loop
        ' Display total
        lblTotal.Text = decTotal.ToString("c")
    End Sub

    Private Sub btnEmpty_Click(sender As Object, e As EventArgs) Handles btnEmpty.Click
        ' Clear Form
        lstFood.Items.Clear()
        lstPrice.Items.Clear()
        lblTotal.Text = String.Empty
    End Sub
End Class
