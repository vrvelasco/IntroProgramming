Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        ' Declare values
        Dim intNum1 As Integer
        Dim intNum2 As Integer
        Dim decAnswer As Decimal
        ' Set values
        intNum1 = txtNum1.Text
        intNum2 = txtNum2.Text
        ' Subtraction
        decAnswer = (intNum1 - intNum2)
        ' Display math
        lblResult.Text = decAnswer
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() ' Closes form
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Declare values
        Dim intNum1 As Integer
        Dim intNum2 As Integer
        Dim decAnswer As Decimal
        ' Set values
        intNum1 = txtNum1.Text
        intNum2 = txtNum2.Text
        ' Addition
        decAnswer = (intNum1 + intNum2)
        ' Display math
        lblResult.Text = decAnswer
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        ' Declare values
        Dim intNum1 As Integer
        Dim intNum2 As Integer
        Dim decAnswer As Decimal
        ' Set values
        intNum1 = txtNum1.Text
        intNum2 = txtNum2.Text
        ' Multiplication
        decAnswer = (intNum1 * intNum2)
        ' Display math
        lblResult.Text = decAnswer
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        ' Declare values
        Dim intNum1 As Integer
        Dim intNum2 As Integer
        Dim decAnswer As Decimal
        ' Set values
        intNum1 = txtNum1.Text
        intNum2 = txtNum2.Text
        'division (with Error message)
        If txtNum2.Text = 0 Then
            lblResult.Text = "Can't divide by zero"
        Else
            decAnswer = (intNum1 / intNum2)
            lblResult.Text = decAnswer
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear TextBoxes and Label
        txtNum1.Clear()
        txtNum2.Clear()
        lblResult.Text = String.Empty
    End Sub
End Class
