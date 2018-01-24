Public Class frnMdi
    'Dim nuevoClientes As New frnClientes
    Private Sub mnuClientes_Click(sender As System.Object, e As System.EventArgs) Handles mnuClientes.Click
        nuevoClientes.Text = "ClientesMDI"
        nuevoClientes.MdiParent = Me
        nuevoClientes.Show()
    End Sub

    Private Sub mnuArticulos_Click(sender As System.Object, e As System.EventArgs) Handles mnuArticulos.Click
        nuevoArticulos.Text = "ArticulosMDI"
        nuevoArticulos.MdiParent = Me
        nuevoArticulos.Show()
    End Sub

    Private Sub mnuPedidos_Click(sender As System.Object, e As System.EventArgs) Handles mnuPedidos.Click
        nuevoPedidos.Text = "FormularioMDI"
        nuevoPedidos.MdiParent = Me
        nuevoPedidos.Show()
    End Sub

    Private Sub mnuSalir_Click(sender As System.Object, e As System.EventArgs) Handles mnuSalir.Click
        Dim frnHijoActivo As Form = CType(Me.ActiveMdiChild, Form)
        If Not frnHijoActivo Is Nothing Then
            frnHijoActivo.Close()
        End If
    End Sub

    Private Sub mnuHorizontal_Click(sender As System.Object, e As System.EventArgs) Handles mnuHorizontal.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub mnuVertical_Click(sender As System.Object, e As System.EventArgs) Handles mnuVertical.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub mnuAcercade_Click(sender As System.Object, e As System.EventArgs) Handles mnuAcercade.Click
        AboutBox1.Show()
    End Sub
End Class
