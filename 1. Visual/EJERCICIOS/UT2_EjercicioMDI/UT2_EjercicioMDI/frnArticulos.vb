Public Class frnArticulos

    Private Sub lstArticulo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstArticulo.SelectedIndexChanged
        Dim pos As Integer = lstArticulo.SelectedIndex

        lstPrecio.SelectedIndex = pos
    End Sub

    Private Sub mnuAltas_Click(sender As System.Object, e As System.EventArgs) Handles mnuAltas.Click
        Dim newArticulo As String = InputBox("Introduce un nuevo ARTICULO", "Nuevo Articulo")
        Dim newPrecio As Double = InputBox("Introduce un nuevo PRECIO", "Nuevo PRECIO")

        If String.IsNullOrEmpty(newArticulo) Then
            smsError("No ha introducido articulo")
        Else
            lstArticulo.Items.Add(newArticulo)
        End If

        If String.IsNullOrEmpty(CStr(newPrecio)) Then
            smsError("No ha introducido precio")
        Else
            lstPrecio.Items.Add(newPrecio)
        End If
    End Sub

    Private Sub mnuBajas_Click(sender As System.Object, e As System.EventArgs) Handles mnuBajas.Click
        Dim pos As Integer = nuevoArticulos.lstArticulo.SelectedIndex

        If pos <> -1 Then
            lstArticulo.Items.RemoveAt(pos)
            lstPrecio.Items.RemoveAt(pos)
        Else
            smsError("Debe seleccionar un articulo para borrar")
        End If
    End Sub

    Private Sub MnuModificar_Click(sender As System.Object, e As System.EventArgs) Handles MnuModificar.Click
        Dim pos As Integer = nuevoArticulos.lstArticulo.SelectedIndex

        If pos <> -1 Then
            Dim modiArticulo As String = InputBox("Introduce modificación ARTICULO", "Modificar Articulo")
            Dim modiPrecio As Double = InputBox("Introduce modificación PRECIO", "Modificar PRECIO")

            If String.IsNullOrEmpty(modiArticulo) Then
                smsError("No ha introducido articulo")
            Else
                lstArticulo.Items.Add(modiArticulo)
            End If

            If String.IsNullOrEmpty(CStr(modiPrecio)) Then
                smsError("No ha introducido precio")
            Else
                lstPrecio.Items.Add(modiPrecio)
            End If
        Else
            smsError("Debe seleccionar un cliente para modificar")
        End If
    End Sub

    Private Sub mnuSalir_Click(sender As System.Object, e As System.EventArgs) Handles mnuSalir.Click
        Me.Close()
    End Sub
End Class