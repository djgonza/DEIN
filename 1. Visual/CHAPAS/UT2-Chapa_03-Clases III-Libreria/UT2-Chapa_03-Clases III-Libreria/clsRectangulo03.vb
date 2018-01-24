Public Class clsRectangulo03
    Private _anchura As Double
    Public Property anchura() As Double
        Get
            Return _anchura
        End Get
        Set(ByVal value As Double)
            _anchura = value
        End Set
    End Property

    Private _altura As Double
    Public Property altura() As Double
        Get
            Return _altura
        End Get
        Set(ByVal value As Double)
            _altura = value
        End Set
    End Property

    Function calcularArea() As Double
        Return _anchura * _altura
    End Function

    Function calcularPerimetro() As Double
        Return (_anchura * _altura) / 2
    End Function
End Class
