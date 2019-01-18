Public Class Form1
    Private Sub btnCalifornia_Click(sender As Object, e As EventArgs) Handles btnCalifornia.Click
        'Make California visible.
        picCalifornia.Visible = True
        picIllinois.Visible = False
        picMissouri.Visible = False
        'Display California in status label
        lblStatus.Text = "California"
        'Display California in a MessageBox
        MessageBox.Show("California")

    End Sub

    Private Sub btnIllinois_Click(sender As Object, e As EventArgs) Handles btnIllinois.Click
        'Make Illinois visible.
        picCalifornia.Visible = False
        picIllinois.Visible = True
        picMissouri.Visible = False
        'Display Illinois in status label
        lblStatus.Text = "Illinois"
        'Display Illinois in a MessageBox
        MessageBox.Show("Illinois")
    End Sub

    Private Sub btnMissouri_Click(sender As Object, e As EventArgs) Handles btnMissouri.Click
        'Make Missouri visible.
        picCalifornia.Visible = False
        picIllinois.Visible = False
        picMissouri.Visible = True
        'Display Missouri in status label
        lblStatus.Text = "Missouri"
        'Display Missouri in a MessageBox
        MessageBox.Show("Missouri")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() 'End the program (closes form)
    End Sub
End Class
