Public Class Form1
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        ' Declare variables
        Dim intNumber, intListCount As Integer
        Dim strNumber As String
        ' Restricts user to five items
        If lstNumbers.Items.Count >= 5 Then
            MessageBox.Show("Please clear the previous values before entering new values.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information) ' Error message
        Else
            ' Get user input and validate
            For intListCount = 1 To 5
                strNumber = InputBox("Please enter a number. " & vbCrLf & vbCrLf & "Hint: You can always enter ""0"", if you want to use less than five numbers.", "Enter number")                          ' Prompt for user
                If Integer.TryParse(strNumber, intNumber) Then                                          ' Convert to integer
                    If intNumber >= 0 Then                                                              ' Greater than or equal to zero?
                        lstNumbers.Items.Add(intNumber)                                                 ' Add the number to the ListBox
                        intListCount = lstNumbers.Items.Count()                                         ' The user can try again, but I won't let them enter more than five numbers
                    Else
                        MessageBox.Show("Please enter a number that is greater than or equal to zero.") ' Error message
                    End If
                Else
                    MessageBox.Show("Please enter a valid integer.")                                    ' Error message
                End If
            Next
        End If
    End Sub

    Private Sub btnCalcAvg_Click(sender As Object, e As EventArgs) Handles btnCalcAvg.Click
        ' Declare variables
        Dim decAvg As Decimal
        Dim intCounter, intSum As Integer
        ' Restrict to always have five numbers
        If lstNumbers.Items.Count() < 5 Then
            MessageBox.Show("Please make sure that you have entered five numbers." & vbCrLf & vbCrLf & "Hint: You can always enter ""0"", if you want to use less than five numbers.", "Results", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Do While intCounter < 5

                intSum += CInt(lstNumbers.Items(intCounter))
                intCounter += 1 'Increment
            Loop
            decAvg = intSum / 5D
            ' Display message
            MessageBox.Show("For the numbers entered:" & vbCrLf & vbCrLf & "The sum is: " & intSum.ToString() & vbCrLf & "The average is: " & decAvg.ToString(), "Results", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstNumbers.Items.Clear() ' Clear ListBox
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() ' Close form
    End Sub
End Class
