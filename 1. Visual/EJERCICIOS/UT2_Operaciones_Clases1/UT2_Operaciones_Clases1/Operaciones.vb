Public Class Operaciones
    Private _num1 As Integer
    Public Property num1() As Double
        Get
            Return _num1
        End Get
        Set(ByVal value As Double)
            _num1 = value
        End Set
    End Property

    Private _num2 As Double
    Public Property num2() As Double
        Get
            Return _num2
        End Get
        Set(ByVal value As Double)
            _num2 = value
        End Set
    End Property

    Function sumar() As Double
        Return _num1 + _num2
    End Function

    Function restar() As Double
        Return _num1 - _num2
    End Function

    Function multiplicar() As Double
        Return _num1 * _num2
    End Function

    Function dividir() As Double
        Return _num1 / _num2
    End Function
End Class
