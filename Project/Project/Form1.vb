Public Class Form1
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        PictureBox2.Visible = False
        TextBox1.Text = (+20)
        PictureBox11.Visible = True
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PictureBox1.Visible = False
        TextBox1.Text = (+20)
        PictureBox10.Visible = True
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox3.Visible = False
        TextBox1.Text = (80)
        PictureBox7.Visible = True
        PictureBox8.Visible = False
        PictureBox10.Visible = False
        PictureBox11.Visible = False
        PictureBox12.Visible = False
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        PictureBox6.Visible = False
        TextBox1.Text = (35)
        PictureBox7.Visible = False
        PictureBox8.Visible = True
        PictureBox10.Visible = False
        PictureBox11.Visible = False
        PictureBox12.Visible = False
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PictureBox5.Visible = False
        TextBox1.Text = (65)
        PictureBox12.Visible = True
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PictureBox4.Visible = False
        TextBox1.Visible = (80)
        PictureBox9.Visible = True
    End Sub

    Private Sub BuyButton_Click(sender As Object, e As EventArgs) Handles BuyButton.Click
        PictureBox4.Visible = True
        PictureBox1.Visible = True
        PictureBox3.Visible = True
        PictureBox2.Visible = True
        PictureBox5.Visible = True
        PictureBox6.Visible = True
        TextBox1.Text = "0"
        PictureBox6.Visible = False
        TextBox1.Text = (35)
        PictureBox7.Visible = False
        PictureBox8.Visible = False
        PictureBox10.Visible = False
        PictureBox11.Visible = False
        PictureBox12.Visible = False
    End Sub






End Class
'form2.showdialoge
