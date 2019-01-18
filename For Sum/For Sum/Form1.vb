Public Class Form1
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        ' Declare variables
        Dim strNumber As String
        Dim intNumber As Integer ' Input
        Dim intSum As Integer    ' Total
        Dim intCount As Integer  ' Loop Counter
        ' Input Number
        strNumber = InputBox("Enter a positive integer value.", "Input Needed", "10")
        If Integer.TryParse(strNumber, intNumber) Then
            If intNumber > 0 Then
                ' Calculate sum
                For intCount = 1 To intNumber
                    intSum += intCount
                Next
                ' Output
                MessageBox.Show("The sum of the numbers 1 through " & intNumber.ToString() & " is " & intSum.ToString())
            Else
                MessageBox.Show("Please enter a positive number.")
            End If
        Else
            MessageBox.Show("Please enter a valid integer.")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() ' Closes Form.
    End Sub
End Class