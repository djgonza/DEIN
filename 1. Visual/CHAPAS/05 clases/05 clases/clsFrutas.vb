Public Class clsFrutas
    Private nomFruta() As String = {"CEREZA", "PLATANO", "NARANJA", "MANZANA"}
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


    Function CaracterValido(ByVal caracter As String) As Boolean
        If caracter Like "[A-ZÑ]" Then
            CaracterValido = True
        Else
            CaracterValido = False
        End If
    End Function

    Function existeFruta(ByVal fruta As String) As Boolean
        Dim i As Integer
        For i = 0 To 3
            If fruta = nomFruta(i) Then
                existeFruta = True
                pre = precio(i)
                Exit For
            End If
        Next
    End Function

    Function importe()
        importe = _unidades * pre
    End Function
   
End Class
