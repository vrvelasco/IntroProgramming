Public Class Form1

    Private Sub btnBegin_Click(sender As System.Object, e As System.EventArgs) Handles btnBegin.Click
        ' Declare variables
        Dim intPhraseCount As Integer
        Dim strPhrase As String
        Dim intParrotCount As Integer
        Dim strParrot As String
        'BEGIN OUTER LOOP
        intPhraseCount = 1 ' Initialize phrase loop counter
        Do While intPhraseCount <= 5 ' Test condition
            strPhrase = InputBox("Please type a phrase.")
            lstPhrases.Items.Add(strPhrase)
            ' BEGIN INNER LOOP
            For intParrotCount = 1 To intPhraseCount ' Initialize and test condition
                strParrot = lstPhrases.Items(intParrotCount - 1)
                lstParrots.Items.Add(strParrot)
            Next ' Increment
            intPhraseCount += 1 ' Increment
        Loop
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        ' Clear the list boxes.
        lstPhrases.Items.Clear()
        lstParrots.Items.Clear()
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        ' End the application.
        Me.Close()
    End Sub
End Class
