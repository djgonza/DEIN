Public Class clsCasa

    Private _id As String

    Public Property id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    Private _direccion As String
    Public Property direccion() As String
        Get
            Return _direccion
        End Get
        Set(ByVal value As String)
            _direccion = value
        End Set
    End Property

    Private _poblacion As String
    Public Property poblacion() As String
        Get
            Return _poblacion
        End Get
        Set(ByVal value As String)
            _poblacion = value
        End Set
    End Property

    Private _cp As String
    Public Property cp() As String
        Get
            Return _cp
        End Get
        Set(ByVal value As String)
            _cp = value
        End Set
    End Property

    Private _propietario As String
    Public Property propietario() As String
        Get
            Return _propietario
        End Get
        Set(ByVal value As String)
            _propietario = value
        End Set
    End Property

    Private _precio As Double
    Public Property precio() As Double
        Get
            Return _precio
        End Get
        Set(ByVal value As Double)
            If value < 0 Then
                MessageBox.Show("No se admiten precios menores a 0")
            Else
                _precio = value
            End If
        End Set
    End Property

    Private _foto As String
    Public Property foto() As String
        Get
            Return _foto
        End Get
        Set(ByVal value As String)
            _foto = value
        End Set
    End Property

    Public Sub New(ByVal id As String, ByVal dir As String, ByVal pob As String, ByVal cp As String, ByVal prop As String, ByVal precio As Double, ByVal foto As String)
        _id = id
        _direccion = dir
        _poblacion = pob
        _cp = cp
        _propietario = prop
        _precio = precio
        _foto = foto
    End Sub
End Class
