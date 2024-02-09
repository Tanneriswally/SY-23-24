Public Class Form1
    Dim WithEvents CS As New CoinSlot
    Private Sub DollarB_Click(sender As Object, e As EventArgs) Handles DollarB.Click
        CS.InsertDollar()
        Label1.Text = CS.Total.ToString("C2")
    End Sub
    Private Sub QuarterB_Click(sender As Object, e As EventArgs) Handles QuarterB.Click
        CS.InsertQuarter()
        Label1.Text = CS.Total.ToString("C2")
    End Sub
    Private Sub NickleB_Click(sender As Object, e As EventArgs) Handles NickelB.Click
        CS.InsertNickle()
        Label1.Text = CS.Total.ToString("C2")
    End Sub
    Private Sub DimeB_Click(sender As Object, e As EventArgs) Handles DimeB.Click
        CS.InsertDime()
        Label1.Text = CS.Total.ToString("C2")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CS.coinreturn()
        Label1.Text = CS.Total.ToString("C2")
    End Sub

    Private Sub CS_CoinReturnEvent(d As Integer, q As Integer, dm As Integer, n As Integer) Handles CS.CoinReturnEvent
        BackColor = Color.Red
    End Sub
End Class
