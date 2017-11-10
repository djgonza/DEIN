Public Class frnTienda
    Private articulos() As String = {"DICKIES CAMILA", "ADIDAS GAZELLE", "BILLABONG HEAD", "QUIKSILVER FIRSTY", "CARHARTT TEXAS"}
    Private producto() As String = {"Camisetas", "Zapatillas", "Gorras", "Gorras", "Pantalones"}
    Private precios() As Integer = {25, 75, 21, 15, 80}
    Private unidades() As Integer = {10, 10, 5, 3, 5}

    Private Sub frnTienda_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        For i As Integer = 0 To 4
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
        Dim pos As Integer = lstArticulo.SelectedIndex

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
        Dim pos As Integer = cmbProductos.SelectedIndex

        If pos = -1 Then
            MessageBox.Show("Debe seleccionar un producto a eliminar")
        Else
            Dim producto As String = cmbProductos.Items.Item(pos)
            Dim cont As Integer = 0

            
        End If
    End Sub
End Class
