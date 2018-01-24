Public Class frnPrincipal

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frnPrincipal_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If listaCasas.Count <> 0 Then
            For Each vivienda In listaCasas
                lstCasas.Items.Add(vivienda.direccion & " " & vivienda.cp & "-" & vivienda.poblacion)
            Next
        End If
    End Sub

    Private Sub lstCasas_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstCasas.SelectedIndexChanged
        Dim pos As Integer = lstCasas.SelectedIndex
        index = pos
        cargarDatos(pos)
    End Sub

    Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
        frnAñadir.ShowDialog()
    End Sub

    Private Sub btnModificar_Click(sender As System.Object, e As System.EventArgs) Handles btnModificar.Click
        Dim pos As Integer = lstCasas.SelectedIndex

        If pos = -1 Then
            smsError("Debe seleccionar una casa")
        Else
            frnModificar.ShowDialog()
        End If

    End Sub

    Public Sub cargarLista()
        lstCasas.Items.Clear()

        If listaCasas.Count <> 0 Then
            For Each vivienda In listaCasas
                lstCasas.Items.Add(vivienda.direccion & " " & vivienda.cp & "-" & vivienda.poblacion)
            Next
        End If
    End Sub

    Private Sub btnBorrar_Click(sender As System.Object, e As System.EventArgs) Handles btnBorrar.Click
        Dim pos As Integer = lstCasas.SelectedIndex

        If pos = -1 Then
            smsError("Debe seleccionar una casa")
        Else
            listaCasas.RemoveAt(index)
            cargarLista()
        End If
    End Sub
   
End Class
