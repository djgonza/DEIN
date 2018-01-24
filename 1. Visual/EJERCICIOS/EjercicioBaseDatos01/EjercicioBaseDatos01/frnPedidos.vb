Imports System.Data
Imports System.Data.OleDb
Public Class frnPedidos
    Private daDiscos As OleDbDataAdapter

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        'MessageBox.Show(Form1.ds.Tables("mis_discos").Rows(e.RowIndex).Item("referenciaprod"))
        With frnDisco
            .txtRef.Text = Form1.ds.Tables("mis_discos").Rows(e.RowIndex).Item("referenciaprod")
            .txtArtista.Text = Form1.ds.Tables("mis_discos").Rows(e.RowIndex).Item("artistaprod")
            .txtTitulo.Text = Form1.ds.Tables("mis_discos").Rows(e.RowIndex).Item("tituloprod")
            .txtPrecio.Text = Form1.ds.Tables("mis_discos").Rows(e.RowIndex).Item("precioprod")
            .pbCaratula.Image = Image.FromFile(Application.StartupPath & "\CARATULA_DISCOS\" & Form1.ds.Tables("mis_discos").Rows(e.RowIndex).Item("fotoprod"))
        End With

        'Dim dv As DataView = Form1.ds.Tables("mis_discos").DefaultView
        'dv.Sort = "referenciaprod"
        'dv.RowFilter = "referenciaprod= " & Form1.ds.Tables("mis_pedidos").Rows(e.RowIndex).Item("productoped")

        frnDisco.ShowDialog()
    End Sub

End Class