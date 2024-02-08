Public Class Form1
    Dim CS As New CoinSlot
    Private Sub DollarB_Click(sender As Object, e As EventArgs) Handles DollarB.Click
        CS.InsertDollar()
        Label1.Text = CS.Total
    End Sub
    Private Sub QuarterB_Click(sender As Object, e As EventArgs) Handles QuarterB.Click
        CS.InsertQuarter()
        Label1.Text = CS.Total
    End Sub
    Private Sub NickleB_Click(sender As Object, e As EventArgs) Handles NickelB.Click
        CS.InsertNickle()
        Label1.Text = CS.Total
    End Sub
    Private Sub DimeB_Click(sender As Object, e As EventArgs) Handles DimeB.Click
        CS.InsertDime()
        Label1.Text = CS.Total
    End Sub
End Class
