Public Class ProductControl
    Public Property ProductID As String
    Public Property ProductPrice As Decimal
    Public Property ProductCount As Integer
    Public Property ProductPicture As Image

    Private Sub ProductControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Image = ProductPicture
        IDlabel.Text = ProductID
        PriceL.Text = ProductPrice.ToString("C2")
    End Sub
    Public Sub Buy()
        If ProductCount > 0 Then
            ProductCount = ProductCount - 1
        End If
        If ProductCount = 0 Then
            PictureBox1.Image = Nothing
        End If
    End Sub
End Class