Public Class frmPedidos

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub


    Private Sub frmPedidos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DataGridView1.Columns("idcliente").Visible = False
        Dim total As Double
        For Each dr As DataGridViewRow In DataGridView1.Rows
            total += dr.Cells("precio").Value * dr.Cells("cantidad").Value
        Next

        txtTotalPedidos.Text = FormatNumber(total, 2)
    End Sub
End Class