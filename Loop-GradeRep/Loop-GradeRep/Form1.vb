Public Class Form1
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        ' ≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈
        ' ≈ DECLARE VARIABLES ≈
        ' ≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈
        '    ** Student's Name**
        Dim strName, strMessage As String
        '    ** Test Scores **
        Dim strTest As String = Nothing
        '    ** Test Scores (integer verison) **
        Dim intTest As Integer
        '   ** Average **
        Dim decTotal, decTestAvg As Decimal
        '   ** Letter Grade **
        Dim strGrade As String = "Null"
        '   ** Loop Counters **
        Dim intInnerLoopCounter, intOuterLoopCounter As Integer
        ' ≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈
        ' ≈ BEGIN OUTER LOOP ≈
        ' ≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈
        Do While intOuterLoopCounter < 3
            '  ** Get Name of Student **
            Do While strName = Nothing
                strName = UCase(InputBox("Please enter the student's name:", "Student's Name"))
            Loop
            ' ≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈
            ' ≈ BEGIN INNER LOOP ≈
            ' ≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈
            intInnerLoopCounter = 0
            decTotal = 0
            Do While intInnerLoopCounter < 3
                ' ≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈
                ' ≈ GET INPUT AND VALIDATE ≈
                ' ≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈
                strTest = Nothing
                Do While strTest = Nothing
                    strTest = InputBox("Please enter " & strName & "'s first test score:", strName & ": Test Score 1")
                Loop
                ' Set integer (Validation)
                If Integer.TryParse(strTest, intTest) And intTest >= 0 And intTest <= 100 Then
                    ' Total of scores
                    decTotal += intTest
                Else                                                     ' ▼ ERROR MESSAGES ▼
                    MessageBox.Show("Please enter a valid score for Test #" & (intInnerLoopCounter + 1).ToString & "." & vbCrLf & vbCrLf & "Valid test scores are whole numbers between 0-100.")
                End If
                ' ≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈
                ' ≈ DISPLAY RESULTS ≈
                ' ≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈
                intInnerLoopCounter += 1 ' Increment
            Loop
            ' Average of test scores
            decTestAvg = decTotal / 3D
            ' Letter grade
            If decTestAvg < 60 Then
                strGrade = "F"
            ElseIf decTestAvg < 70 Then
                strGrade = "D"
            ElseIf decTestAvg < 80 Then
                strGrade = "C"
            ElseIf decTestAvg < 90 Then
                strGrade = "B"
            ElseIf decTestAvg <= 100 Then
                strGrade = "A"
            End If
            strMessage = strName & vbTab & "Average: " & decTestAvg.ToString("n0") & vbTab & "Grade: " & strGrade
            ' Display ListBox info
            If strMessage = Nothing Then
                intOuterLoopCounter = 999 ' End Loop
            Else
                lstGrades.Items.Add(strMessage)
            End If
            ' Reset variables
            intInnerLoopCounter = 0
            strName = Nothing
            strTest = Nothing
            strMessage = Nothing
            intOuterLoopCounter += 1 ' Increment
        Loop
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstGrades.Items.Clear() ' Clears ListBox
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() ' Closes form
    End Sub
End Class
