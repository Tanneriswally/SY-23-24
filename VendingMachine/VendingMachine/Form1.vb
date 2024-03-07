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
        If d > 0 Then
            DollarPB.Visible = True
        Else
            DollarPB.Visible = False
        End If
        If q > 0 Then
            QaurterPB.Visible = True
        Else
            QaurterPB.Visible = False
        End If
        If dm > 0 Then
            DimePB.Visible = True
        Else
            DimePB.Visible = False
        End If
        If n > 0 Then
            NickelPB.Visible = True
        Else
            NickelPB.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Select Case IDTextbox.Text
            Case ProductControl1.ProductID
                CS.buy(ProductControl1)
            Case ProductControl2.ProductID
                CS.buy(ProductControl2)
            Case ProductControl3.ProductID
                CS.buy(ProductControl3)
            Case ProductControl4.ProductID
                CS.buy(ProductControl4)
            Case ProductControl5.ProductID
                CS.buy(ProductControl5)
            Case ProductControl6.ProductID
                CS.buy(ProductControl6)
            Case ProductControl7.ProductID
                CS.buy(ProductControl7)
            Case Else

        End Select
        Label1.Text = CS.Total.ToString("C2")
    End Sub
    Private Sub CS_Dispense(p As Image) Handles CS.Dispense
        productPB.Image = p
    End Sub
End Class

