Imports System.Data
Imports System.Data.OleDb
Public Class Form1
    Private cn As New OleDbConnection
    Private daClientes As OleDbDataAdapter
    Private ds As New DataSet

    Private nombreBBDD As String = Application.StartupPath & "\DISCOS.accdb"
    Private WithEvents bs As New BindingSource

    Private Sub frnApuntes2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        configurarAccesoDatos()
        enlazarDatos()
    End Sub

    Sub configurarAccesoDatos()
        cn.ConnectionString = "provider=Microsoft.ace.oledb.12.0;data source=" & nombreBBDD
        cn.Open()

        daClientes = New OleDbDataAdapter("Select * FROM productos", cn)
        daClientes.Fill(ds, "mis_discos")

        cn.Close()

        Dim claves(0) As DataColumn
        claves(0) = New DataColumn
        claves(0) = ds.Tables("mis_discos").Columns("referenciaprod")
        ds.Tables("mis_discos").PrimaryKey = claves
        
        Dim cbClientes As OleDbCommandBuilder = New OleDbCommandBuilder(daClientes)
    End Sub

    Sub enlazarDatos()
        bs.DataSource = ds.Tables("mis_discos")
    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        Dim posicion As Integer
        Dim key As String

        key = txtRef.Text.ToUpper

        If key <> "" Or key <> " " Then
            posicion = ds.Tables("mis_discos").Rows.IndexOf(ds.Tables("mis_discos").Rows.Find(key))
            bs.Position = posicion
            MessageBox.Show(bs.Position)

            If posicion <> -1 Then
                txtArtista.Text = bs.Current("artistaprod")
                txtTitulo.Text = ds.Tables("mis_discos").Rows(posicion).Item("tituloprod")
                txtPrecio.Text = ds.Tables("mis_discos").Rows(posicion).Item("precioprod")
                txtFoto.Text = ds.Tables("mis_discos").Rows(posicion).Item("fotoprod")

                Try
                    imgCaratula.Image = Image.FromFile(Application.StartupPath & "\CARATULA_DISCOS\" & ds.Tables("mis_discos").Rows(posicion).Item("fotoprod"))
                Catch ex As Exception
                    imgCaratula.Image = Image.FromFile(Application.StartupPath & "\CARATULA_DISCOS\nodisp.jpg")
                End Try

                btnEditar.Enabled = True
                btnBorrar.Enabled = True
            Else
                MessageBox.Show("Oohhhhhh no existe!!")
            End If
        End If
    End Sub

    Sub habilitarTextboxs()
        txtArtista.Enabled = True
        txtTitulo.Enabled = True
        txtPrecio.Enabled = True
        txtFoto.Enabled = True
    End Sub

    Sub deshabilitarTextboxs()
        txtArtista.Enabled = False
        txtTitulo.Enabled = False
        txtPrecio.Enabled = False
        txtFoto.Enabled = False

        btnEditar.Enabled = False
        btnBorrar.Enabled = False
    End Sub

    Sub limpiar()
        txtArtista.Text = "-"
        txtTitulo.Text = "-"
        txtPrecio.Text = "-"
        txtFoto.Text = "-"

        txtRef.Text = ""
        txtRef.Focus()
    End Sub

    Private Sub btnEditar_Click(sender As System.Object, e As System.EventArgs) Handles btnEditar.Click
        Dim texto As String = btnEditar.Text

        If texto = "Editar" Then
            habilitarTextboxs()
            btnEditar.Text = "Guardar"
        Else
            MessageBox.Show(bs.Position)
            bs.Current("artistaprod") = txtArtista.Text
            bs.Current("tituloprod") = txtTitulo.Text
            bs.Current("precioprod") = txtPrecio.Text
            bs.Current("fotoprod") = txtFoto.Text
            bs.EndEdit()
            If Not ds.GetChanges Is Nothing Then
                Try
                    daClientes.Update(ds, "mis_discos")
                    ds.AcceptChanges()
                Catch ex As Exception
                    MessageBox.Show("Error al actualizar")
                    MessageBox.Show(ex.Message)
                    ds.Tables("mis_discos").RejectChanges()
                End Try
            End If
            deshabilitarTextboxs()
            btnEditar.Text = "Editar"
            limpiar()
        End If
    End Sub

    Private Sub btnBorrar_Click(sender As System.Object, e As System.EventArgs) Handles btnBorrar.Click
        If Not bs.Current Is Nothing Then
            If MessageBox.Show("¿Eliminar el disco?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                bs.RemoveCurrent()
            End If
        End If
    End Sub
End Class
