Public Class Form1

    Private Sub btnRead_Click(sender As System.Object, e As System.EventArgs) Handles btnRead.Click
        ' Declare variables
        Dim strItem As String
        Dim intItemCount, intLoopCount As Integer
        ' Get number of items from ListBox
        intItemCount = lstList.Items.Count
        ' Loop through each item in list box
        intLoopCount = 0 ' Initialize
        Do While intLoopCount < intItemCount
            ' Get items from ListBox
            strItem = CStr(lstList.Items(intLoopCount))
            MessageBox.Show(strItem)
            intLoopCount += 1 ' Increment loop counter
        Loop
    End Sub

    Private Sub btnWrite_Click(sender As System.Object, e As System.EventArgs) Handles btnWrite.Click
        ' Declare variables
        Dim strWriteData As String
        Dim strItems As String
        Dim intItems As Integer
        Dim intWrite As Integer ' Loop Counter
        ' Ask for number of items
        strItems = InputBox("Please enter number of items.")
        ' Validate number of items
        If Integer.TryParse(strItems, intItems) Then
            If intItems > 0 Then
                ' Loop through items
                For intWrite = 1 To intItems
                    ' Ask for each item
                    strWriteData = InputBox("Please enter data item to write.")
                    lstList.Items.Add(strWriteData)
                Next
            Else
                MessageBox.Show("Please enter a positive integer.")
            End If
        Else
            MessageBox.Show("Please enter a valid number of items.")
        End If
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        ' Clear the list box.
        lstList.Items.Clear()
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        ' End the program.
        Me.Close()
    End Sub
End Class
