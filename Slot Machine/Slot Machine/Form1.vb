Imports System.Security.Cryptography

Public Class Form1
    Dim CS As New CoinSlot
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CS.Total >= 1 Then
            ReelControl1.spin()
            ReelControl2.spin()
            ReelControl3.spin()
            CS.spin()
            Label4.Text = CS.Total.ToString("c2")
            Timer1.Enabled = True
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = ReelControl1.itemValue
        Label2.Text = ReelControl2.itemValue
        Label3.Text = ReelControl3.itemValue
        Timer1.Enabled = False
        If ReelControl1.itemValue = ReelControl2.itemValue And ReelControl2.itemValue = ReelControl3.itemValue Then
            Label4.Text = CS.Total.ToString("C2") + 100.0
            Me.BackColor = Color.Green
        Else
            Me.BackColor = Color.White
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CS.InsertDollar()
        Label4.Text = CS.Total.ToString("c2")
    End Sub
End Class
