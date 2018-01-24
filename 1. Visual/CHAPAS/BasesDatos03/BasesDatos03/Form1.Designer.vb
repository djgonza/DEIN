<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtIdPedido = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbClientes = New System.Windows.Forms.ComboBox()
        Me.cmbProductos = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpFechaPedido = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nudCantidad = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbxPagado = New System.Windows.Forms.CheckBox()
        Me.plnMovimiento = New System.Windows.Forms.Panel()
        Me.etPosicion = New System.Windows.Forms.Label()
        Me.btnAvanzar = New System.Windows.Forms.Button()
        Me.btnFinal = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnPrincipio = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.etTotalPedido = New System.Windows.Forms.Label()
        CType(Me.nudCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.plnMovimiento.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtIdPedido
        '
        Me.txtIdPedido.Location = New System.Drawing.Point(15, 25)
        Me.txtIdPedido.Name = "txtIdPedido"
        Me.txtIdPedido.Size = New System.Drawing.Size(151, 20)
        Me.txtIdPedido.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "&Id. Pedido:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(169, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Cliente:"
        '
        'cmbClientes
        '
        Me.cmbClientes.FormattingEnabled = True
        Me.cmbClientes.Location = New System.Drawing.Point(172, 25)
        Me.cmbClientes.Name = "cmbClientes"
        Me.cmbClientes.Size = New System.Drawing.Size(258, 21)
        Me.cmbClientes.TabIndex = 5
        '
        'cmbProductos
        '
        Me.cmbProductos.FormattingEnabled = True
        Me.cmbProductos.Location = New System.Drawing.Point(15, 64)
        Me.cmbProductos.Name = "cmbProductos"
        Me.cmbProductos.Size = New System.Drawing.Size(241, 21)
        Me.cmbProductos.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Producto:"
        '
        'dtpFechaPedido
        '
        Me.dtpFechaPedido.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaPedido.Location = New System.Drawing.Point(262, 65)
        Me.dtpFechaPedido.Name = "dtpFechaPedido"
        Me.dtpFechaPedido.Size = New System.Drawing.Size(168, 20)
        Me.dtpFechaPedido.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(258, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Fecha del pedido:"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(15, 104)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(102, 20)
        Me.txtPrecio.TabIndex = 11
        Me.txtPrecio.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Precio:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(120, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Cantidad:"
        '
        'nudCantidad
        '
        Me.nudCantidad.Location = New System.Drawing.Point(123, 104)
        Me.nudCantidad.Name = "nudCantidad"
        Me.nudCantidad.Size = New System.Drawing.Size(95, 20)
        Me.nudCantidad.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(221, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Total pedido:"
        '
        'cbxPagado
        '
        Me.cbxPagado.AutoSize = True
        Me.cbxPagado.Location = New System.Drawing.Point(367, 108)
        Me.cbxPagado.Name = "cbxPagado"
        Me.cbxPagado.Size = New System.Drawing.Size(63, 17)
        Me.cbxPagado.TabIndex = 16
        Me.cbxPagado.Text = "Pagado"
        Me.cbxPagado.UseVisualStyleBackColor = True
        '
        'plnMovimiento
        '
        Me.plnMovimiento.Controls.Add(Me.etPosicion)
        Me.plnMovimiento.Controls.Add(Me.btnAvanzar)
        Me.plnMovimiento.Controls.Add(Me.btnFinal)
        Me.plnMovimiento.Controls.Add(Me.btnAnterior)
        Me.plnMovimiento.Controls.Add(Me.btnPrincipio)
        Me.plnMovimiento.Location = New System.Drawing.Point(15, 134)
        Me.plnMovimiento.Name = "plnMovimiento"
        Me.plnMovimiento.Size = New System.Drawing.Size(415, 32)
        Me.plnMovimiento.TabIndex = 23
        '
        'etPosicion
        '
        Me.etPosicion.AutoSize = True
        Me.etPosicion.Location = New System.Drawing.Point(157, 10)
        Me.etPosicion.Name = "etPosicion"
        Me.etPosicion.Size = New System.Drawing.Size(39, 13)
        Me.etPosicion.TabIndex = 26
        Me.etPosicion.Text = "Label6"
        '
        'btnAvanzar
        '
        Me.btnAvanzar.Location = New System.Drawing.Point(350, 0)
        Me.btnAvanzar.Name = "btnAvanzar"
        Me.btnAvanzar.Size = New System.Drawing.Size(28, 32)
        Me.btnAvanzar.TabIndex = 25
        Me.btnAvanzar.Text = ">"
        Me.btnAvanzar.UseVisualStyleBackColor = True
        '
        'btnFinal
        '
        Me.btnFinal.Location = New System.Drawing.Point(384, 0)
        Me.btnFinal.Name = "btnFinal"
        Me.btnFinal.Size = New System.Drawing.Size(28, 32)
        Me.btnFinal.TabIndex = 24
        Me.btnFinal.Text = ">>"
        Me.btnFinal.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Location = New System.Drawing.Point(36, 0)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(28, 32)
        Me.btnAnterior.TabIndex = 23
        Me.btnAnterior.Text = "<"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnPrincipio
        '
        Me.btnPrincipio.Location = New System.Drawing.Point(2, 0)
        Me.btnPrincipio.Name = "btnPrincipio"
        Me.btnPrincipio.Size = New System.Drawing.Size(28, 32)
        Me.btnPrincipio.TabIndex = 22
        Me.btnPrincipio.Text = "<<"
        Me.btnPrincipio.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(96, 201)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 29
        Me.btnCancelar.Text = "Ca&ncelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        Me.btnCancelar.Visible = False
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(15, 201)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 28
        Me.btnAceptar.Text = "Ace&ptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        Me.btnAceptar.Visible = False
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(352, 172)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 27
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(271, 172)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrar.TabIndex = 26
        Me.btnBorrar.Text = "&Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(96, 172)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 25
        Me.btnActualizar.Text = "Ac&tualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(15, 172)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 24
        Me.btnNuevo.Text = "N&uevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'etTotalPedido
        '
        Me.etTotalPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.etTotalPedido.Location = New System.Drawing.Point(224, 102)
        Me.etTotalPedido.Name = "etTotalPedido"
        Me.etTotalPedido.Size = New System.Drawing.Size(137, 23)
        Me.etTotalPedido.TabIndex = 30
        Me.etTotalPedido.Text = "Label8"
        Me.etTotalPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 300)
        Me.Controls.Add(Me.etTotalPedido)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.plnMovimiento)
        Me.Controls.Add(Me.cbxPagado)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.nudCantidad)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpFechaPedido)
        Me.Controls.Add(Me.cmbProductos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbClientes)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtIdPedido)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.nudCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.plnMovimiento.ResumeLayout(False)
        Me.plnMovimiento.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtIdPedido As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbClientes As System.Windows.Forms.ComboBox
    Friend WithEvents cmbProductos As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaPedido As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents nudCantidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbxPagado As System.Windows.Forms.CheckBox
    Friend WithEvents plnMovimiento As System.Windows.Forms.Panel
    Friend WithEvents etPosicion As System.Windows.Forms.Label
    Friend WithEvents btnAvanzar As System.Windows.Forms.Button
    Friend WithEvents btnFinal As System.Windows.Forms.Button
    Friend WithEvents btnAnterior As System.Windows.Forms.Button
    Friend WithEvents btnPrincipio As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents etTotalPedido As System.Windows.Forms.Label

End Class
