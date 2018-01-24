Imports System.Data
Imports System.Data.OleDb
Public Class Form1
    Private cn As New OleDbConnection
    Private daClientes As OleDbDataAdapter
    Private daPedidos As OleDbDataAdapter
    Private daProductos As OleDbDataAdapter

    Private ds As New DataSet

    Private nombreBBDD As String = Application.StartupPath & "\ejemplo.accdb"

    Private WithEvents bs As New BindingSource

    Private posicionactual As Long

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        configurarAccesoDatos()
        enlazarDatos()
        bs.MoveLast()
        bs.MoveFirst()
    End Sub

    Sub configurarAccesoDatos()
        cn.ConnectionString = "provider=Microsoft.ace.oledb.12.0;data source=" & nombreBBDD
        cn.Open()

        daClientes = New OleDbDataAdapter("Select * FROM Clientes", cn)
        daClientes.Fill(ds, "mis_clientes")

        daProductos = New OleDbDataAdapter("Select * FROM Productos", cn)
        daProductos.Fill(ds, "mis_productos")

        daPedidos = New OleDbDataAdapter("Select * FROM Pedidos", cn)
        daPedidos.Fill(ds, "mis_pedidos")

        cn.Close()

        Dim cbPedidos As OleDbCommandBuilder = New OleDbCommandBuilder(daPedidos)
    End Sub

    Sub enlazarDatos()
        bs.DataSource = ds
        bs.DataMember = "mis_pedidos"

        txtIdPedido.DataBindings.Add(New Binding("text", bs, "idpedido_ped", True))

        'Para el ComboBox de Productos
        cmbProductos.DataSource = ds.Tables("mis_productos")
        cmbProductos.DisplayMember = "Producto_pro"
        cmbProductos.DataBindings.Add(New Binding("text", bs, "producto_ped", True))

        'Para el ComboBox de Clientes
        cmbClientes.DataSource = ds.Tables("mis_clientes")
        cmbClientes.DisplayMember = "Apellido_cli"
        'IMPORTANTE!!! EXAMEN!!!!
        cmbClientes.ValueMember = "IdCliente_cli"
        cmbClientes.DataBindings.Add(New Binding("selectedvalue", bs, "IdCliente_ped", True))

        'Fecha
        dtpFechaPedido.DataBindings.Add(New Binding("value", bs, "Fecha_ped", True))

        'Precio
        txtPrecio.DataBindings.Add(New Binding("text", bs, "Precio_ped", True))

        'Cantidad
        nudCantidad.DataBindings.Add(New Binding("value", bs, "Cantidad_ped", True))

        'Pagado
        cbxPagado.DataBindings.Add(New Binding("checked", bs, "Pagado_ped", True))

    End Sub

    Private Sub btnAvanzar_Click(sender As System.Object, e As System.EventArgs) Handles btnAvanzar.Click
        bs.MoveNext()
    End Sub

    Private Sub btnAnterior_Click(sender As System.Object, e As System.EventArgs) Handles btnAnterior.Click
        bs.MovePrevious()
    End Sub

    Private Sub btnPrincipio_Click(sender As System.Object, e As System.EventArgs) Handles btnPrincipio.Click
        bs.MoveFirst()
    End Sub

    Private Sub btnFinal_Click(sender As System.Object, e As System.EventArgs) Handles btnFinal.Click
        bs.MoveLast()
    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub bs_PositionChanged(sender As Object, e As System.EventArgs) Handles bs.PositionChanged
        etPosicion.Text = "Pedido " & (bs.Position + 1) & " de " & bs.Count

        If Not IsNumeric(txtPrecio.Text) Or Not IsNumeric(nudCantidad.Value) Then
            txtPrecio.Text = 0
            nudCantidad.Value = 0
        End If
        etTotalPedido.Text = CInt(txtPrecio.Text) * nudCantidad.Value

        If bs.Position = 0 Then
            desPrimBot()
        ElseIf bs.Position = bs.Count Then
            desFinBot()
        Else
            habilitarBotones()
        End If
    End Sub

    Sub desPrimBot()
        btnPrincipio.Enabled = False
        btnAnterior.Enabled = False
    End Sub

    Sub desFinBot()
        btnFinal.Enabled = False
        btnAvanzar.Enabled = False
    End Sub

    Sub habilitarBotones()
        btnPrincipio.Enabled = True
        btnAvanzar.Enabled = True
        btnFinal.Enabled = True
        btnAnterior.Enabled = True
    End Sub


    Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
        habilitarControles()

        bs.AddNew()

        cmbClientes.SelectedIndex = 0
        cmbProductos.SelectedIndex = 0
        dtpFechaPedido.Value = DateTime.Now

        txtIdPedido.Enabled = False
        txtIdPedido.Text = ds.Tables("mis_pedidos").Rows(ds.Tables("mis_pedidos").Rows.Count - 1).Item("idpedido_ped") + 1
    End Sub

    Sub habilitarControles()
        btnNuevo.Enabled = False
        btnBorrar.Enabled = False
        btnActualizar.Enabled = False

        plnMovimiento.Enabled = False

        btnAceptar.Visible = True
        btnCancelar.Visible = True

        posicionactual = bs.Position
    End Sub

    Sub habilitar()
        btnBorrar.Enabled = True
        btnSalir.Enabled = True
        btnActualizar.Enabled = True
        btnNuevo.Enabled = True

        plnMovimiento.Enabled = True

        btnAceptar.Visible = False
        btnCancelar.Visible = False

        bs.Position = posicionactual
    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        habilitar()
        bs.Position = bs.Count - 1
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        habilitar()
        bs.CancelEdit()
        bs.Position = posicionactual
    End Sub

    Private Sub frnApuntes2_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not ds.GetChanges Is Nothing Then
            If MessageBox.Show("¿Desea guardar los cambios?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2
                               ) = Windows.Forms.DialogResult.No Then
                btnAceptar.PerformClick()
            End If
        End If
    End Sub

    Private Sub btnBorrar_Click(sender As System.Object, e As System.EventArgs) Handles btnBorrar.Click
        If Not bs.Current Is Nothing Then
            If MessageBox.Show("¿Eliminar el cliente?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                bs.RemoveCurrent()
            End If
        End If
    End Sub

    Private Sub btnActualizar_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizar.Click
        bs.EndEdit()
        If Not ds.GetChanges Is Nothing Then
            Try
                daPedidos.Update(ds, "mis_pedidos")
                ds.AcceptChanges()
            Catch ex As Exception
                MessageBox.Show("Error al actualizar")
                MessageBox.Show(ex.Message)
                ds.Tables("mis_pedidos").RejectChanges()
            End Try
        End If
    End Sub


End Class
