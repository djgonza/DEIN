Public Class Form1

    Private nomFruta() As String = {"cereza", "platano", "naranja", "manzana"}
    Private precio() As Integer = {100, 200, 300, 400}
    Dim pre As Integer


    Private _unidades As Integer
    Public Property unidades() As Integer
        Get
            Return _unidades
        End Get
        Set(ByVal value As Integer)
            _unidades = value
        End Set
    End Property

    Function CaracterVAlido(ByVal caracter As String) As Boolean
        If caracter Like "[A-Z]" Then
            CaracterVAlido = True
        Else
            CaracterVAlido = False
        End If
    End Function

    Function existeFruta(ByVal frutita As String) As Boolean
        Dim i As Integer
        For i = 0 To 3
            If frutita = nomFruta(i) Then
                existeFruta = True
                pre = precio(i)
                Exit For
            End If
        Next
    End Function

    Function importe() As Double
        importe = _unidades * pre

    End Function

    Private Sub etUnidades_Click(sender As System.Object, e As System.EventArgs) Handles etUnidades.Click

    End Sub
End Class
