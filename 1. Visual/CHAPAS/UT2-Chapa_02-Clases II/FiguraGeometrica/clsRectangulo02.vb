Public Class clsRectangulo02
    'Para crear esta libreria de clases hay que darle: Archivo, Agregar, Nuevo proyecto, Biblioteca de clases

    'Para generar el siguiente código hay que hacer: boton derecho; Insertar fragmento de código; Modelos de código (...);
    'Propiedades,procedimientos,eventos ; Definir una propiedad
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
