Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim cuenta01 As New clsCCuenta

        cuenta01.nombre = "nombre 1"
        cuenta01.cuenta = "123456789"
        cuenta01.TipoInteres = 1.1
        cuenta01.ingreso(100)

        MessageBox.Show("CUENTA 1")
        MessageBox.Show(cuenta01.nombre)
        MessageBox.Show(cuenta01.cuenta)
        MessageBox.Show(cuenta01.TipoInteres)
        MessageBox.Show(cuenta01.saldo)

        'cuenta01.ingreso(100)
        'MessageBox.Show(cuenta01.saldo)

        Dim cuenta02 As New clsCCuenta("nombre 2", "111111111", 2.8, 500)
        MessageBox.Show("CUENTA 2")
        MessageBox.Show(cuenta02.nombre)
        MessageBox.Show(cuenta02.cuenta)
        MessageBox.Show(cuenta02.TipoInteres)
        MessageBox.Show(cuenta02.saldo)
        cuenta02.ingreso(100)
        MessageBox.Show(cuenta02.saldo)

        MessageBox.Show(cuenta01.obtenernombre())
        MessageBox.Show(cuenta02.obtenernombre())

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim cuentaAhorro As New clsCCuentaAhorro
        cuentaAhorro.nombre = "Cuenta ahorro 01"
        cuentaAhorro.cuenta = "666666666"
        cuentaAhorro.TipoInteres = 1.6
        cuentaAhorro.ingreso(666)
        cuentaAhorro.reintegro(66)

        MessageBox.Show("CUENTA AHORRO")
        MessageBox.Show(cuentaAhorro.nombre)
        MessageBox.Show(cuentaAhorro.cuenta)
        MessageBox.Show(cuentaAhorro.TipoInteres)
        MessageBox.Show(cuentaAhorro.saldo)
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim cuentaAhorroMant As New clsCCuentaAhorro("cuentaAhorroMant", "888888888", 7.7, 7000, 90)

        cuentaAhorroMant.reintegro(20)

        MessageBox.Show("CUENTA AHORRO MANTENIMIENTO")
        MessageBox.Show(cuentaAhorroMant.nombre)
        MessageBox.Show(cuentaAhorroMant.cuenta)
        MessageBox.Show(cuentaAhorroMant.TipoInteres)
        MessageBox.Show(cuentaAhorroMant.saldo)
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        clsCShared.nombreShared = "jaaaaaaaaaaaarrrr"
        clsCShared.mostrarcompartido()

        Dim shar As New clsCShared
        shar.instancia = "Agromenaweeeer"
        shar.mostrarinstancia()
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        'Dim j As New clsExpliOver3
        'MessageBox.Show(j.suma(2, 2))

        Dim a As New clsExpliOver
        Dim a2 As New clsExpliOver2
        Dim a3 As New clsExpliOver3

        a = a2
        a.patata()

        a = a3
        a.patata()
    End Sub

End Class

