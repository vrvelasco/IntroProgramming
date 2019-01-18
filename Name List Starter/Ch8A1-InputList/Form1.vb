Public Class Form1

    Private Sub btnEnter_Click(sender As System.Object, e As System.EventArgs) Handles btnEnter.Click
        ' Declare variables
        Dim strName As String
        ' Ask the user to enter a name
        strName = InputBox("Please enter a name.", "Enter")
        ' Put name into ListBox
        lstNames.Items.Add(strName)
    End Sub

    Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click
        ' Declare variables
        Dim strIndex As String  ' Index typed by user
        Dim intIndex As Integer ' Index for ListBox
        Dim strName As String   ' Name from ListBox
        strIndex = InputBox("Please enter serial number. (Starting at 1)", "Serial Number")
        If Integer.TryParse(strIndex, intIndex) Then
            ' Convert serial number to index number
            intIndex = intIndex - 1
            If intIndex >= 0 And intIndex < lstNames.Items.Count Then
                ' Get name from ListBox
                strName = lstNames.Items(intIndex)
                ' Display name in MessageBox
                MessageBox.Show(strName)
            Else
                MessageBox.Show("Please enter serial number in range.")
            End If
        Else
            MessageBox.Show("Please enter a valid integer.")
        End If
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        ' Clear ListBox
        lstNames.Items.Clear()
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        ' Exit from the application.
        Me.Close()
    End Sub

End Class
