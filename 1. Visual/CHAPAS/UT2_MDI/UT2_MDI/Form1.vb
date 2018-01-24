Public Class Form1

    Private Sub mnuNuevo_Click(sender As System.Object, e As System.EventArgs) Handles mnuNuevo.Click
        Dim nuevoFormHijo As New frnHijo
        nuevoFormHijo.Text = "Formulario:" & Me.MdiChildren.Length
        nuevoFormHijo.MdiParent = Me
        nuevoFormHijo.Show()
    End Sub

    Private Sub mnuCascada_Click(sender As System.Object, e As System.EventArgs) Handles mnuCascada.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub mnuHorizontal_Click(sender As System.Object, e As System.EventArgs) Handles mnuHorizontal.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub mnuVertical_Click(sender As System.Object, e As System.EventArgs) Handles mnuVertical.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub mnuOrganizada_Click(sender As System.Object, e As System.EventArgs) Handles mnuOrganizada.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub mnuCerrar_Click(sender As System.Object, e As System.EventArgs) Handles mnuCerrar.Click
        Dim frnHijoActivo As frnHijo = CType(Me.ActiveMdiChild, frnHijo)

        If Not frnHijoActivo Is Nothing Then
            frnHijoActivo.Close()
        End If
    End Sub
End Class
