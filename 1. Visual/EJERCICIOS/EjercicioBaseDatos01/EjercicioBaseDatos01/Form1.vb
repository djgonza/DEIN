Imports System.Data
Imports System.Data.OleDb
Public Class Form1
    'Conexion
    Public cn As New OleDbConnection
    'Los datos
    Private daClientes As OleDbDataAdapter
    Private daPedidos As OleDbDataAdapter
    Public daDiscos As OleDbDataAdapter
    Public ds As New DataSet

    Private nombreBBDD As String = Application.StartupPath & "\DISCOS.accdb"

    Private Sub frnBaseDatos01_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not ds.Tables("mis_usuarios").GetChanges Is Nothing Then
            If MessageBox.Show("Datos Modificados. ¿Continuar?", "Tabla Usuarios", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2
                               ) = Windows.Forms.DialogResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub frnBaseDatos01_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        configurarAccesoDatos()
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "mis_usuarios"

        DataGridView1.Width = Me.ClientRectangle.Width
    End Sub

    Sub configurarAccesoDatos()
        'Nos permite conectarnos a la base de datos ACCDB
        cn.ConnectionString = "provider=Microsoft.ace.oledb.12.0;data source=" & nombreBBDD

        'Abrir la conexión
        cn.Open()

        'Abrir una consulta utilizacion la conexión a la base de datos
        daClientes = New OleDbDataAdapter("Select * FROM usuarios", cn)
        daPedidos = New OleDbDataAdapter("Select * FROM pedidos", cn)
        daDiscos = New OleDbDataAdapter("Select * FROM productos", cn)

        'Cargar Datos en el DataSet
        daClientes.Fill(ds, "mis_usuarios")
        daPedidos.Fill(ds, "mis_pedidos")
        daDiscos.Fill(ds, "mis_discos")

        'Cerrar la conexión
        cn.Close()

        'Permite la edicion de los datos
        Dim cbClientes As OleDbCommandBuilder = New OleDbCommandBuilder(daClientes)
        Dim cbPedidos As OleDbCommandBuilder = New OleDbCommandBuilder(daPedidos)
        Dim cbDiscos As OleDbCommandBuilder = New OleDbCommandBuilder(daDiscos)
    End Sub

    Private Sub btnActualizar_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizar.Click
        'Guarda los cambios hechos en el DataSet
        daClientes.Update(ds, "mis_usuarios")
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        'Borra todos los cambios hechos en el DataSet
        ds.RejectChanges()
    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        'MessageBox.Show(e.RowIndex)
        With frnPedidos
            .txtId.Text = ds.Tables("mis_usuarios").Rows(e.RowIndex).Item("codigousu")
            .txtNombre.Text = ds.Tables("mis_usuarios").Rows(e.RowIndex).Item("apellidousu")
            .txtApellido.Text = ds.Tables("mis_usuarios").Rows(e.RowIndex).Item("nombreusu")
            .txtCiudad.Text = ds.Tables("mis_usuarios").Rows(e.RowIndex).Item("postalusu")
            .txtProvincia.Text = ds.Tables("mis_usuarios").Rows(e.RowIndex).Item("poblacion")
        End With

        Dim dv As DataView = ds.Tables("mis_pedidos").DefaultView
        dv.Sort = "usuarioped"
        dv.RowFilter = "usuarioped= " & ds.Tables("mis_usuarios").Rows(e.RowIndex).Item("codigousu")
        frnPedidos.DataGridView1.DataSource = dv
        'frmPedidos.txtTotalPedidos.Text = dv.Count
        frnPedidos.ShowDialog()
    End Sub
End Class

