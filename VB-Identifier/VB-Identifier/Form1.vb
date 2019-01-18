Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() 'Closes program
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles picLion.Click
        'Display a selection box to show change
        picLionSelected.Visible = True
        picLeopardSelected.Visible = False
        picTigerSelected.Visible = False
        'Displays Genre in label
        lblGenre.Text = "Genre: Animals"
        'Displays Subject in StatusStrip
        lblSubject.Text = "Subject: Big Cat (Panthera genus)"
        'Displays Name in a MessageBox
        MessageBox.Show("Name: Lion")
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles picSnowLeopard.Click
        'Display a selection box to show change
        picLionSelected.Visible = False
        picLeopardSelected.Visible = True
        picTigerSelected.Visible = False
        'Displays Genre in label
        lblGenre.Text = "Genre: Animals"
        'Displays Subject in StatusStrip
        lblSubject.Text = "Subject: Big Cat (Panthera genus)"
        'Displays Name in a MessageBox
        MessageBox.Show("Name: Snow Leopard")
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles picTiger.Click
        'Display a selection box to show change
        picLionSelected.Visible = False
        picLeopardSelected.Visible = False
        picTigerSelected.Visible = True
        'Displays Genre in label
        lblGenre.Text = "Genre: Animals"
        'Displays Subject in StatusStrip
        lblSubject.Text = "Subject: Big Cat (Panthera genus)"
        'Displays Name in a MessageBox
        MessageBox.Show("Name: Tiger")
    End Sub
End Class
