Public Class clsCCuentaAhorro
    Inherits clsCCuenta

    Private _cuotademantenimiento As Double
    Public Property mantenimiento() As Double
        Get
            Return _cuotademantenimiento
        End Get
        Set(ByVal cantidad As Double)
            If cantidad < 0 Then
                MessageBox.Show("Cantidad negativa")
            Else
                _cuotademantenimiento = cantidad
            End If
        End Set
    End Property

    Overloads Sub reintegro(ByVal cantidad As Double)
        Dim saldo As Double = Me.saldo
        Dim tipointeres As Double = Me.TipoInteres

        If tipointeres > 3.5 Then
            If saldo - cantidad < 1500 Then
                MessageBox.Show("ERROR: No hay esa cantidad")
                Return
            End If
        End If
        MyBase.reintegro(cantidad)
    End Sub

    Public Sub New()

    End Sub

    Public Sub New(ByVal nom As String, ByVal cuenta As String, ByVal TipoInteres As Double, ByVal saldo As Double, ByVal mant As Double)
        MyBase.New(nom, cuenta, TipoInteres, saldo)
        _cuotademantenimiento = mant
    End Sub

End Class
