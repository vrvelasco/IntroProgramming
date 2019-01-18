Public Class Form1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Closes form
        Me.Close()
    End Sub

    Private Sub btnShowData_Click(sender As Object, e As EventArgs) Handles btnShowData.Click
        ' Declare variables
        Dim strFullName As String
        Dim intDays As Integer
        Dim decTemp As Decimal
        strFullName = txtCityName.Text & ", " & txtStateName.Text
        intDays = txtDays.Text
        decTemp = txtTemp.Text
        ' Show data
        lblFullName.Text = strFullName
        lblDays.Text = intDays
        lblTemp.Text = decTemp & "°F"

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear text
        txtCityName.Clear()
        txtStateName.Clear()
        txtDays.Clear()
        txtTemp.Clear()
        lblFullName.Text = String.Empty
        lblDays.Text = String.Empty
        lblTemp.Text = String.Empty
    End Sub
End Class
