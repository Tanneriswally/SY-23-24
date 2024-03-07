Public Class CoinSlot
    Public Event Dispense(p As Image)
    Public Event CoinReturnEvent(d As Integer, q As Integer, di As Integer, n As Integer)
    Public Property Quarters As Integer
    Public Property Nickles As Integer
    Public Property Dimes As Integer
    Public Property Dollars As Integer
    Dim _total As Decimal
    Public ReadOnly Property Total As Decimal
        Get
            _total = Dollars + Quarters * 0.25 + Dimes * 0.1 + Nickles * 0.05
            Return _total
        End Get
    End Property
    Public Sub coinreturn()
        RaiseEvent CoinReturnEvent(Dollars, Quarters, Nickles, Dimes)
        Quarters = 0
        Nickles = 0
        Dimes = 0
        Dollars = 0
    End Sub
    Public Sub InsertQuarter()
        Quarters = Quarters + 1
    End Sub
    Public Sub InsertNickle()
        Nickles = Nickles + 1
    End Sub
    Public Sub InsertDime()
        Dimes = Dimes + 1
    End Sub
    Public Sub InsertDollar()
        Dollars = Dollars + 1
    End Sub
    Public Sub spin()
        If Total >= 1 Then
            _total = Total - 1
            Quarters = 0
            Dimes = 0
            Dollars = 0
            Nickles = _total / 0.05
        End If
    End Sub
End Class
