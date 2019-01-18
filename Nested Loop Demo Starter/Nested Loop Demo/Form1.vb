Public Class Form1
    Private Sub btnMult_Click(sender As Object, e As EventArgs) Handles btnMult.Click
        ' Declare variables
        Dim intx, inty, intz As Integer
        ' Outer Loop increments X from 0 to 3
        For intx = 0 To 3 ' Initialize and Text X
            ' Inner Loop increments Y from 0 to 3 for each X
            For inty = 0 To 3 'Initialize and Test Y
                ' Calculate Z and display X * Y = Z equation
                intz = intx * inty
                lstMult.Items.Add(intx.ToString() & " * " &
                     inty.ToString() & " = " & intz.ToString())
            Next ' Increment Y
        Next ' Increment X
    End Sub
End Class
