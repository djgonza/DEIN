Public Class frnClasi

    Dim indice As Integer = 0

    Private Sub btnVuelta_Click(sender As System.Object, e As System.EventArgs) Handles btnVuelta.Click
        Me.Dispose()
    End Sub

    Private Sub frnClasi_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        For i As Integer = 0 To frnMedallero.lstTotal.Items.Count - 1
            lstTotal.Items.Add(frnMedallero.lstTotal.Items.Item(i))
        Next

        seleccionar(indice)
    End Sub


    Private Sub btnAnterior_Click(sender As System.Object, e As System.EventArgs) Handles btnAnterior.Click
        If indice - 1 >= 0 Then
            btnAnterior.Enabled = True
            btnSiguiente.Enabled = True
            indice -= 1
            seleccionar(indice)
        Else
            btnAnterior.Enabled = False
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As System.Object, e As System.EventArgs) Handles btnSiguiente.Click
        If indice + 1 <= lstPais.Items.Count - 1 Then
            btnSiguiente.Enabled = True
            btnAnterior.Enabled = True
            indice += 1
            seleccionar(indice)
        Else
            btnSiguiente.Enabled = False
        End If
    End Sub

    Sub seleccionar(indice)
        lstPais.SelectedIndex = -1
        lstTotal.SelectedIndex = -1

        lstPais.SelectedIndex = indice
        lstTotal.SelectedIndex = indice
    End Sub

    Sub activarBotones()
        If indice = 0 Then
            btnAnterior.Enabled = False
            btnSiguiente.Enabled = True
        ElseIf indice = lstPais.Items.Count - 1 Then
            btnAnterior.Enabled = True
            btnSiguiente.Enabled = False
        Else
            btnAnterior.Enabled = True
            btnSiguiente.Enabled = True
        End If
    End Sub

    Private Sub btnOcultar_Click(sender As System.Object, e As System.EventArgs) Handles btnOcultar.Click
        Dim num As Integer = nupMedallas.Value

        For i As Integer = (lstTotal.Items.Count - 1) To 0 Step -1
            Dim valor As Integer = CInt(lstTotal.Items.Item(i))
            If valor = num Then
                ocultar(i)
            End If
        Next

       
    End Sub

    Sub ocultar(posicion)
        lstPais.Items.RemoveAt(posicion)
        lstTotal.Items.RemoveAt(posicion)
    End Sub
End Class