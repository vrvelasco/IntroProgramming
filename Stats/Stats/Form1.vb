Public Class Form1
    Private Sub radEnglish_CheckedChanged(sender As Object, e As EventArgs) Handles radEnglish.CheckedChanged
        'Change to English
        Me.Text = "2018 FIFA World Cup Russia™"
        grpStarPlayer.Text = "Star Player"
        lblName.Text = "Name:"
        lblNumber.Text = "Number:"
        grpScores.Text = "Scores"
        lblGame1.Text = "Game 1:"
        lblGame2.Text = "Game 2:"
        lblGame3.Text = "Game 3:"
        btnStats.Text = "Stats"
        btnClear.Text = "Clear"
        btnExit.Text = "Exit"
        lblStarPlayer.Text = "Star Player"
        lblAverage.Text = "Average Score"
    End Sub

    Private Sub radEspanol_CheckedChanged(sender As Object, e As EventArgs) Handles radEspanol.CheckedChanged
        ' Change to Spanish
        Me.Text = "La Copa Mundial de la FIFA Rusia 2018™"
        grpStarPlayer.Text = "Jugador Estrella"
        lblName.Text = "Nombre:"
        lblNumber.Text = "Número:"
        grpScores.Text = "Puntuaciones"
        lblGame1.Text = "Juego 1:"
        lblGame2.Text = "Juego 2:"
        lblGame3.Text = "Juego 3:"
        btnStats.Text = "Estadísticas"
        btnClear.Text = "Borrar"
        btnExit.Text = "Salir"
        lblStarPlayer.Text = "Jugador Estrella"
        lblAverage.Text = "Puntuación Media"
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear text
        txtName.Clear()
        txtNumber.Clear()
        txtGame1.Clear()
        txtGame2.Clear()
        txtGame3.Clear()
        ' Return focus to Name TextBox
        txtName.Focus()
        ' Resize form
        Me.Height = 675
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() ' Closes form
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = 675 ' Hide calculated info
    End Sub

    Private Sub btnStats_Click(sender As Object, e As EventArgs) Handles btnStats.Click
        ' Declare variables
        Dim strName As String
        Dim intPlayerNumber, intGame1, intGame2, intGame3 As Integer
        Dim decAverageScore As Decimal
        strName = txtName.Text
        Try 'Handles errors
            If Integer.TryParse(txtNumber.Text, intPlayerNumber) Then ' Test user input
                lblCalcPlayer.Text = strName & ", " & intPlayerNumber.ToString() ' Concatenate Name and Number
                ' Process average after testing user input
                If Integer.TryParse(txtGame1.Text, intGame1) And Integer.TryParse(txtGame2.Text, intGame2) And Integer.TryParse(txtGame3.Text, intGame3) Then
                    decAverageScore = (intGame1 + intGame2 + intGame3) / 3D
                    lblCalcAverage.Text = decAverageScore.ToString("n2") ' Output average
                    Me.Height = 830 'Show calculated info
                Else
                    MessageBox.Show("Please enter numerical values.")
                End If
            Else
                MessageBox.Show("Please enter numerical values.")
            End If
        Catch ex As Exception
            MessageBox.Show("Please enter numerical values.")
        End Try
    End Sub
End Class
