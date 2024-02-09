Public Class CoinSlot
    Public Event CoinReturnEvent(d As Integer, q As Integer, dm As Integer, n As Integer)
    Public Property Quarters As Integer
    Public Property Nickles As Integer
    Public Property Dimes As Integer
    Public Property Dollars As Integer
    Public ReadOnly Property Total As Decimal
        Get
            Return Dollars + Quarters * 0.25 + Dimes * 0.1 + Nickles * 0.05
        End Get
    End Property
    Public Sub coinreturn()
        Quarters = 0
        Nickles = 0
        Dimes = 0
        Dollars = 0
        RaiseEvent CoinReturnEvent(Dollars, Quarters, Nickles, Dimes)
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
End Class
