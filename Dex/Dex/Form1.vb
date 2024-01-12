Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Dim records(50) As String

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        PictureBox1.Image = Nothing
        Field1.Text = ""
        field2.Text = ""
        field3.Text = ""
        field4.Text = ""
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        PictureBox1.Load(OpenFileDialog1.FileName)
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim outFile As New IO.StreamWriter("data.txt")
        outFile.Write(Field1.Text)
        outFile.Write("|")
        outFile.Write(field2.Text)
        outFile.Write("|")
        outFile.Write(field3.Text)
        outFile.Write("|")
        outFile.Write(field4.Text)
        outFile.Write("|")
        outFile.Write(field5.Text)
        outFile.Write("|")
        outFile.Write(PictureBox1.ImageLocation)
        outFile.WriteLine()
        outFile.Close()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IO.File.Exists("") Then
            Dim infile As New StreamReader("data.text")
            records(1) = infile.ReadLine
            infile.Close()
        End If
    End Sub
End Class

