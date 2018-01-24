Module Module1
    Public listaCasas As New List(Of clsCasa)
    Public index As Integer

    Sub añadirCasa(ByVal id As String, ByVal dir As String, ByVal pob As String, ByVal cp As String, ByVal prop As String, ByVal precio As Double, ByVal foto As String)
        Dim nuevaCasa As New clsCasa(id, dir, pob, cp, prop, precio, foto)
        listaCasas.Add(nuevaCasa)
    End Sub

    Sub modificarCasa(ByVal indice As Integer, ByVal id As String, ByVal dir As String, ByVal pob As String, ByVal cp As String, ByVal prop As String, ByVal precio As Double, ByVal foto As String)
        Dim index As Integer = indice
        Dim casa As clsCasa = listaCasas(index)

        casa.id = id
        casa.direccion = dir
        casa.poblacion = pob
        casa.cp = cp
        casa.propietario = prop
        casa.precio = precio
        casa.foto = foto

        listaCasas(index) = casa
    End Sub

    Public Sub soloNumeros(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Not e.KeyChar Like "[0-9]" And e.KeyChar <> Convert.ToChar(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    'Para mensajes de Error
    Public Sub smsError(ByVal mensaje)
        MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Sub cargarDatos(ByVal indice As Integer)
        Dim index As Integer = indice
        Dim casa As clsCasa = listaCasas(index)

        frnPrincipal.txtId.Text = casa.id
        frnPrincipal.txtDireccion.Text = casa.direccion
        frnPrincipal.txtPoblacion.Text = casa.poblacion
        frnPrincipal.txtCP.Text = casa.cp
        frnPrincipal.txtPrecio.Text = Format(casa.precio, "#,###.## €")
        frnPrincipal.pbCasa.Image = Image.FromFile(casa.foto)

    End Sub

End Module
