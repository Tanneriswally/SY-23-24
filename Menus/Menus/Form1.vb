Public Class Form1
    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Me.Close()

    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        TextBox1.Clear()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim outFile As New IO.StreamWriter("out.txt")
        outFile.Write(TextBox1.Text)
        outFile.Close()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If IO.File.Exists("out.txt") Then
            Dim inFILE As New IO.StreamReader("out.txt")
        TextBox1.Text = inFILE.ReadToEnd
        inFILE.Close()
    End Sub
End Class
