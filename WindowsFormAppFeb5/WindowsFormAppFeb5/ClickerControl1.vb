Public Class ClickerControl1
    Dim c As Clicker
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        c.click()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        c.reset()
    End Sub
End Class
