Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()                ' Closes form
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        ' Declare variable
        Dim strInput As String    ' InputBox string
        Dim intInput As Integer   ' Integer version of String
        Dim intCounter As Integer ' Loop Counter
        Dim intSum As Integer     ' The sum of the Loop
        ' Get user input
        strInput = InputBox("Enter a positive integer value.", "Input Needed", "5") ' Display InputBox (Set 5 as example integer)
        If Integer.TryParse(strInput, intInput) Then                                ' Validate input
            If intInput > 0 Then                                                    ' Positive numbers only
                Do While intCounter <= intInput                                     ' Loop until we reach the user's number input
                    intSum += intCounter                                            ' Keep adding the number between 1 and the user's input
                    intCounter += 1                                                 ' Increment Loop counter
                Loop
                MessageBox.Show("The sum of numbers 1 through " & intInput & " is " & intSum & ".") ' Display the result
            Else
                MessageBox.Show("Please enter a positive value.")                                   ' Positive value error message
            End If
        Else
            MessageBox.Show("Please enter valid integer.")                                          ' Integer error message
        End If
    End Sub
End Class
