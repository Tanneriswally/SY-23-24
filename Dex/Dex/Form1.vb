Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        PictureBox1.image = Nothing
        Field1.Text = ""
        field2.Text = ""
        field3.Text = ""
        field4.Text = ""
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        OpenFileDialog1.ShowDialog()
    End Sub
End Class

