Public Class form1
    Dim C As New Clicker
    Dim c2 As New Clicker
    Dim c3 As New Clicker
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        C.incriment = NumericUpDown1.Value
        C.click()
        TextBox1.Text = C.count
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox2.Text = TextBox1.Text
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        C.reset()
        TextBox1.Text = C.count
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        c2.incriment = NumericUpDown2.Value
        c2.click()
        TextBox2.Text = c2.count
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        c2.reset()
        TextBox2.Text = c2.count
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        c3.incriment = NumericUpDown3.Value
        c3.click()
        TextBox3.Text = c3.count
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        c3.reset()
        TextBox3.Text = c3.count
    End Sub
End Class
