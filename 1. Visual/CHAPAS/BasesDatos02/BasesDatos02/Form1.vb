Imports System.Data
Imports System.Data.OleDb
Public Class frnApuntes2
    Private cn As New OleDbConnection
    Private daClientes As OleDbDataAdapter
    Private daClientes2 As OleDbDataAdapter
    Private ds As New DataSet

    Private nombreBBDD As String = Application.StartupPath & "\ejemplo.accdb"
    Private WithEvents bs As New BindingSource
    Private WithEvents bs2 As New BindingSource

    Private posicionactual As Long

    Private Sub frnApuntes2_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not ds.GetChanges Is Nothing Then
            If MessageBox.Show("¿Desea guardar los cambios?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2
                               ) = Windows.Forms.DialogResult.No Then
                btnAceptar.PerformClick()
            End If
        End If
    End Sub

    Private Sub frnApuntes2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        configurarAccesoDatos()
        enlazarDatos()
    End Sub

    Sub configurarAccesoDatos()
        cn.ConnectionString = "provider=Microsoft.ace.oledb.12.0;data source=" & nombreBBDD
        cn.Open()

        daClientes = New OleDbDataAdapter("Select * FROM Clientes", cn)
        daClientes.Fill(ds, "mis_clientes")

        daClientes2 = New OleDbDataAdapter("Select * FROM Clientes", cn)
        daClientes2.Fill(ds, "mis_clientes2")

        cn.Close()

        Dim claves(0) As DataColumn
        claves(0) = New DataColumn
        claves(0) = ds.Tables("mis_clientes").Columns("idcliente")
        ds.Tables("mis_clientes").PrimaryKey = claves

        Dim cbClientes As OleDbCommandBuilder = New OleDbCommandBuilder(daClientes)
        Dim cbClientes2 As OleDbCommandBuilder = New OleDbCommandBuilder(daClientes2)
    End Sub

    Sub enlazarDatos()
        bs.DataSource = ds.Tables("mis_clientes")
        bs2.DataSource = ds.Tables("mis_clientes2")

        txtIdCliente.DataBindings.Add(New Binding("text", bs, "idcliente"))
        txtApellido.DataBindings.Add(New Binding("text", bs, "apellido"))
        txtNombre.DataBindings.Add(New Binding("text", bs, "nombre"))
        txtProvincia.DataBindings.Add(New Binding("text", bs, "Provincia"))
        txtCiudad.DataBindings.Add(New Binding("text", bs, "Ciudad"))
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
        btnAvanzar.Enabled = False
    End Sub

    Sub desFinBot()
        btnFinal.Enabled = False
        btnAnterior.Enabled = False
    End Sub

    Sub habilitarBotones()
        btnPrincipio.Enabled = True
        btnAvanzar.Enabled = True
        btnFinal.Enabled = True
        btnAnterior.Enabled = True
    End Sub

    Private Sub btnBS_Click(sender As System.Object, e As System.EventArgs) Handles btnBS.Click
        MessageBox.Show(bs.Count)
        MessageBox.Show(bs.Position)
        MessageBox.Show(bs.Current("apellido"))
        bs.Position = 5
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
                daClientes.Update(ds, "mis_clientes")
                ds.AcceptChanges()
            Catch ex As Exception
                MessageBox.Show("Error al actualizar")
                MessageBox.Show(ex.Message)
                ds.Tables("mis_clientes").RejectChanges()
            End Try
        End If
    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
        deshabilitar()
        bs.AddNew()
        txtIdCliente.Focus()
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

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        bs2.MoveFirst()

        For i = 0 To bs2.Count - 1
            ListBox1.Items.Add(bs2.Current("apellido"))
            bs2.MoveNext()
        Next
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
        bs2.MoveFirst()
        For Each fila In ds.Tables("mis_clientes2").Rows
            ListBox1.Items.Add(fila("apellido"))
        Next
    End Sub

    Private Sub btnFind1_Click(sender As System.Object, e As System.EventArgs) Handles btnFind1.Click
        Dim dr As DataRow

        dr = ds.Tables("mis_clientes").Rows.Find("10330")

        If Not (dr Is Nothing) Then
            MessageBox.Show(dr("apellido") & " * " & dr("nombre"))
        Else
            MessageBox.Show("Nooooooooooooooooooooorrrrrlllll!!!!!")
        End If
    End Sub

    Private Sub btnBs2_Click(sender As System.Object, e As System.EventArgs) Handles btnBs2.Click

    End Sub

    Private Sub btnFind2_Click(sender As System.Object, e As System.EventArgs) Handles btnFind2.Click
        Dim posicion As Integer
        posicion = ds.Tables("mis_clientes").Rows.IndexOf(ds.Tables("mis_clientes").Rows.Find("10330"))

        'MessageBox.Show(posicion)

        If posicion <> -1 Then
            bs.Position = posicion
            txtBusqueda.Text = bs.Current("apellido")
        Else
            MessageBox.Show("Nooooooooooooooooooooorrrrrlllll!!!!!")
        End If
    End Sub

    Private Sub btnSiguiente2_Click(sender As System.Object, e As System.EventArgs) Handles btnSiguiente2.Click
        bs.MoveNext()
        txtBusqueda.Text = bs.Current("apellido")
    End Sub

    Private Sub btnRenew_Click(sender As System.Object, e As System.EventArgs) Handles btnRenew.Click
        bs.Current("apellido") = txtBusqueda.Text
        bs.EndEdit()
        If Not ds.GetChanges Is Nothing Then
            Try
                daClientes.Update(ds, "mis_clientes")
                ds.AcceptChanges()
            Catch ex As Exception
                MessageBox.Show("Error al actualizar")
                MessageBox.Show(ex.Message)
                ds.Tables("mis_clientes").RejectChanges()
            End Try
        End If
    End Sub
End Class
