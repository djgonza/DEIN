Imports System.Data
Imports System.Data.OleDb
Public Class frnEjercicio02
    Private cn As New OleDbConnection
    Private daClientes As OleDbDataAdapter
    Private ds As New DataSet

    Private nombreBBDD As String = Application.StartupPath & "\DISCOS.accdb"
    Private WithEvents bs As New BindingSource

    Private posicionactual As Long

    Private Sub frnEjercicio02_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        configurarAccesoDatos()
        enlazarDatos()
    End Sub

    Sub configurarAccesoDatos()
        cn.ConnectionString = "provider=Microsoft.ace.oledb.12.0;data source=" & nombreBBDD
        cn.Open()
        daClientes = New OleDbDataAdapter("Select * FROM productos", cn)
        daClientes.Fill(ds, "mis_productos")
        cn.Close()
        Dim cbClientes As OleDbCommandBuilder = New OleDbCommandBuilder(daClientes)
    End Sub

    Sub enlazarDatos()
        bs.DataSource = ds.Tables("mis_productos")

        txtRef.DataBindings.Add(New Binding("text", bs, "referenciaprod"))
        txtArtista.DataBindings.Add(New Binding("text", bs, "artistaprod"))
        txtTitulo.DataBindings.Add(New Binding("text", bs, "tituloprod"))
        txtPrecio.DataBindings.Add(New Binding("text", bs, "precioprod"))
        txtFoto.DataBindings.Add(New Binding("text", bs, "fotoprod"))
        'pbImagen.Image = Image.FromFile(Application.StartupPath & "\CARATULA_DISCOS\" & Form1.ds.Tables("mis_discos").Rows(e.RowIndex).Item("fotoprod"))
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

    Private Sub bs_PositionChanged(sender As Object, e As System.EventArgs) Handles bs.PositionChanged
        etPosicion.Text = "Registro " & (bs.Position + 1) & " de " & bs.Count
    End Sub
    
    Private Sub btnBorrar_Click(sender As System.Object, e As System.EventArgs) Handles btnBorrar.Click
        If Not bs.Current Is Nothing Then
            If MessageBox.Show("¿Eliminar el producto?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                bs.RemoveCurrent()
            End If
        End If
    End Sub

    Private Sub btnActualizar_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizar.Click
        bs.EndEdit()
        If Not ds.GetChanges Is Nothing Then
            Try
                daClientes.Update(ds, "mis_productos")
                ds.AcceptChanges()
            Catch ex As Exception
                MessageBox.Show("Error al actualizar")
                MessageBox.Show(ex.Message)
                ds.Tables("mis_productos").RejectChanges()
            End Try
        End If
    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
        deshabilitar()
        bs.AddNew()
        txtRef.Focus()
    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        habilitar()
    End Sub

    Sub deshabilitar()
        btnBorrar.Enabled = False
        btnSalir.Enabled = False
        btnActualizar.Enabled = False
        btnNuevo.Enabled = False

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

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        bs.CancelEdit()

        habilitar()

        bs.Position = posicionactual
    End Sub
End Class
