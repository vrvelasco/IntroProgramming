Public Class Form1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Exit from the program.
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear the form
        txtGallons.Clear()
        txtMiles.Clear()
        lblMPG.Text = String.Empty
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Declare variables
        Dim intMiles As Integer
        Dim decGallons As Decimal
        Dim decMPG As Decimal
        ' Input data from user
        intMiles = txtMiles.Text
        decGallons = txtGallons.Text
        ' Calculate MPG
        decMPG = intMiles / decGallons
        ' Output answer to user
        lblMPG.Text = decMPG
    End Sub
End Class
