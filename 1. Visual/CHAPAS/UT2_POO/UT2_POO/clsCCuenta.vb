Public Class clsCCuenta

    Private _nombre As String
    Public Property nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal nom As String)
            If nom.Length = 0 Then
                MessageBox.Show("Cuenta NO válida")
            Else
                _nombre = nom
            End If
        End Set
    End Property

    Private _cuenta As String
    Public Property cuenta() As String
        Get
            Return _cuenta
        End Get
        Set(ByVal cue As String)
            If cue.Length = 0 Then
                MessageBox.Show("Cuenta NO válida")
            Else
                _cuenta = cue
            End If
        End Set
    End Property

    Private _TipoInteres As Double
    Public Property TipoInteres() As Double
        Get
            Return _TipoInteres
        End Get
        Set(ByVal tipo As Double)
            _TipoInteres = tipo
        End Set
    End Property

    Private _saldo As Double
    Public ReadOnly Property saldo() As Double
        Get
            Return _saldo
        End Get
    End Property

    Sub ingreso(ByVal cantidad As Double)
        If cantidad < 0 Then
            MessageBox.Show("Cantidad negativa")
        Else
            _saldo += cantidad
        End If
    End Sub


    Public Sub New()
        'MessageBox.Show("OBJETO CCUENTA CREADO")
    End Sub


    Public Sub New(ByVal nom As String, ByVal cuenta As String, ByVal TipoInteres As Double, ByVal saldo As Double)
        _nombre = nom
        _cuenta = cuenta
        _TipoInteres = TipoInteres
        ingreso(saldo)
    End Sub


    Function obtenernombre() As String
        Return "Nombre: " & Me.nombre
    End Function

    Sub reintegro(ByVal cantidad As Double)
        If _saldo - cantidad < 0 Then
            MessageBox.Show("No disponible ese saldo")
        Else
            _saldo -= cantidad
        End If
    End Sub
End Class
