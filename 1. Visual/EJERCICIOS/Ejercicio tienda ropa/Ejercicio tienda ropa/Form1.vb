Public Class frnTienda
    Private articulos() As String = {"DICKIES CAMILA", "ADIDAS GAZELLE", "BILLABONG HEAD", "QUIKSILVER FIRSTY", "CARHARTT TEXAS"}
    Private producto() As String = {"Camisetas", "Zapatillas", "Gorras", "Gorras", "Pantalones"}
    Private precios() As Integer = {25, 75, 21, 15, 80}
    Private unidades() As Integer = {10, 10, 5, 3, 5}

    Private articulo As String
    Private unidadesComprar As Integer
    Private precioTotal As Integer
    Private pos As Integer

    Private Sub frnTienda_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cargarListas()
    End Sub

    Sub cargarListas()
        For i As Integer = 0 To lstArticulo.Items.Count
            lstArticulo.Items.Add(articulos(i))
            lstTipo.Items.Add(producto(i))
            lstPrecio.Items.Add(precios(i))
            lstUnidades.Items.Add(unidades(i))
        Next
    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub lstArticulo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstArticulo.SelectedIndexChanged
        Dim pos As Integer = lstArticulo.SelectedIndex

        lstTipo.SelectedIndex = pos
        lstPrecio.SelectedIndex = pos
        lstUnidades.SelectedIndex = pos
    End Sub

    Private Sub btnEliminarSelec_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminarSelec.Click
        pos = lstArticulo.SelectedIndex

        If pos = -1 Then
            MessageBox.Show("Debe seleccionar un artículo")
        Else
            Dim resultado As DialogResult
            resultado = MessageBox.Show("¿Deseas eliminar el artículo?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If resultado = Windows.Forms.DialogResult.Yes Then
                lstArticulo.Items.RemoveAt(pos)
                lstTipo.Items.RemoveAt(pos)
                lstPrecio.Items.RemoveAt(pos)
                lstUnidades.Items.RemoveAt(pos)
            End If
        End If
    End Sub

    
    Private Sub btnEliminarProd_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminarProd.Click
        Dim posi As Integer = cmbProductos.SelectedIndex

        If posi = -1 Then
            MessageBox.Show("Debe seleccionar un producto a eliminar")
        Else
            Dim producto As String = cmbProductos.Items.Item(pos)


        End If
    End Sub


    Private Sub btnUniComprar_Click(sender As System.Object, e As System.EventArgs) Handles btnUniComprar.Click
        pos = lstArticulo.SelectedIndex

        If txtUnidades.Text = "" Then
            MessageBox.Show("Introduce un nº de unidades a comprar")
        Else
            unidadesComprar = CInt(txtUnidades.Text)
        End If

        If pos = -1 Then
            MessageBox.Show("Debe seleccionar un producto a eliminar")
        Else
            Dim unidadesDispo As Integer = unidades(pos)
            articulo = articulos(pos)
            Dim precio As Integer = precios(pos)

            If unidadesComprar > unidadesDispo Then
                MessageBox.Show("No hay tantas unidades disponibles!!!")
            Else
                precioTotal = precio * unidadesComprar
                unidadesDispo -= unidadesComprar

                If cbDescuento.Checked Then
                    precioTotal = precioTotal - (precioTotal * 10 / 100)
                End If

                txtMostrar.Text = articulo + " --- " + CStr(unidadesComprar) + " --- " + CStr(precioTotal)

                btnComprar.Enabled = True
                gpbUnidades.Enabled = False
            End If

        End If
    End Sub
    
    Private Sub txtUnidades_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtUnidades.KeyPress, txtPrecio,tx
        If Not (e.KeyChar Like "[0-9]") And AscW(e.KeyChar) <> Keys.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnComprar_Click(sender As System.Object, e As System.EventArgs) Handles btnComprar.Click
        Dim resultado As DialogResult
        resultado = MessageBox.Show("¿Deseas comprar el artículo?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If resultado = Windows.Forms.DialogResult.Yes Then
            Dim unidadesDispo As Integer = unidades(pos)

            unidadesDispo -= unidadesComprar
            lstUnidades.Items.Item(pos) = unidadesDispo

            Dim mensaje As String = "Ha realizado la compra: " + articulo + " " + CStr(unidadesComprar) + " " + CStr(precioTotal)
            MessageBox.Show(mensaje)

            btnComprar.Enabled = False
            gpbUnidades.Enabled = True
            txtMostrar.Text = ""
            cbDescuento.Checked = False
            articulo = ""
            unidadesComprar = 0
            precioTotal = 0

        End If
    End Sub

  
    Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
        Dim arti As String = txtArticulo.Text
        Dim posi As String = cmbProductos2.SelectedIndex
        Dim precio As Integer = CInt(txtPrecio.Text)
        Dim uni As Integer = CInt(txtUniAña.Text)

        If arti = "" Then
            MessageBox.Show("Debe introducir un articulo")
        End If

        If posi = -1 Then
            MessageBox.Show("Debe seleccionar un Tipo de Producto")
        Else
            Dim tipo As String = cmbProductos2.Items.Item(pos)
        End If

        articulos.

        cargarListas()
    End Sub
End Class
