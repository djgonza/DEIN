<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frnVuelos
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
        Me.lblOrigen = New System.Windows.Forms.Label()
        Me.cbOrigen = New System.Windows.Forms.ComboBox()
        Me.lblDestino = New System.Windows.Forms.Label()
        Me.rbtNacional = New System.Windows.Forms.RadioButton()
        Me.rbtInternacional = New System.Windows.Forms.RadioButton()
        Me.lstNacional = New System.Windows.Forms.ListBox()
        Me.lstInternacional = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.nudBilletes = New System.Windows.Forms.NumericUpDown()
        Me.cbTarifa = New System.Windows.Forms.ComboBox()
        Me.btnAñadir = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.lstVuelos = New System.Windows.Forms.ListBox()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.txtCP = New System.Windows.Forms.TextBox()
        Me.lblCP = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lstPrecio = New System.Windows.Forms.ListBox()
        CType(Me.nudBilletes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblOrigen
        '
        Me.lblOrigen.AutoSize = True
        Me.lblOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrigen.Location = New System.Drawing.Point(13, 13)
        Me.lblOrigen.Name = "lblOrigen"
        Me.lblOrigen.Size = New System.Drawing.Size(57, 17)
        Me.lblOrigen.TabIndex = 0
        Me.lblOrigen.Text = "Origen"
        '
        'cbOrigen
        '
        Me.cbOrigen.FormattingEnabled = True
        Me.cbOrigen.Items.AddRange(New Object() {"BARCELONA", "BILBAO", "MADRID", "SANTANDER", "VITORIA", "ZARAGOZA"})
        Me.cbOrigen.Location = New System.Drawing.Point(13, 34)
        Me.cbOrigen.Name = "cbOrigen"
        Me.cbOrigen.Size = New System.Drawing.Size(154, 21)
        Me.cbOrigen.TabIndex = 1
        '
        'lblDestino
        '
        Me.lblDestino.AutoSize = True
        Me.lblDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDestino.Location = New System.Drawing.Point(185, 13)
        Me.lblDestino.Name = "lblDestino"
        Me.lblDestino.Size = New System.Drawing.Size(63, 17)
        Me.lblDestino.TabIndex = 2
        Me.lblDestino.Text = "Destino"
        '
        'rbtNacional
        '
        Me.rbtNacional.AutoSize = True
        Me.rbtNacional.Checked = True
        Me.rbtNacional.Location = New System.Drawing.Point(188, 34)
        Me.rbtNacional.Name = "rbtNacional"
        Me.rbtNacional.Size = New System.Drawing.Size(67, 17)
        Me.rbtNacional.TabIndex = 3
        Me.rbtNacional.TabStop = True
        Me.rbtNacional.Text = "Nacional"
        Me.rbtNacional.UseVisualStyleBackColor = True
        '
        'rbtInternacional
        '
        Me.rbtInternacional.AutoSize = True
        Me.rbtInternacional.Location = New System.Drawing.Point(314, 35)
        Me.rbtInternacional.Name = "rbtInternacional"
        Me.rbtInternacional.Size = New System.Drawing.Size(86, 17)
        Me.rbtInternacional.TabIndex = 4
        Me.rbtInternacional.Text = "Internacional"
        Me.rbtInternacional.UseVisualStyleBackColor = True
        '
        'lstNacional
        '
        Me.lstNacional.FormattingEnabled = True
        Me.lstNacional.Items.AddRange(New Object() {"BARCELONA", "BILBAO", "MADRID", "SANTANDER", "VITORIA", "ZARAGOZA"})
        Me.lstNacional.Location = New System.Drawing.Point(188, 58)
        Me.lstNacional.Name = "lstNacional"
        Me.lstNacional.Size = New System.Drawing.Size(120, 95)
        Me.lstNacional.TabIndex = 5
        '
        'lstInternacional
        '
        Me.lstInternacional.FormattingEnabled = True
        Me.lstInternacional.Items.AddRange(New Object() {"AMSTERDAM", "ESTOCOLMO", "LONDRES", "NEW YORK", "PARIS", "SIDNEY"})
        Me.lstInternacional.Location = New System.Drawing.Point(314, 58)
        Me.lstInternacional.Name = "lstInternacional"
        Me.lstInternacional.Size = New System.Drawing.Size(120, 95)
        Me.lstInternacional.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(451, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 144)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "VUELOS DEIN"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumero.Location = New System.Drawing.Point(13, 161)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(83, 13)
        Me.lblNumero.TabIndex = 8
        Me.lblNumero.Text = "Nº de billetes"
        '
        'nudBilletes
        '
        Me.nudBilletes.Location = New System.Drawing.Point(103, 159)
        Me.nudBilletes.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudBilletes.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudBilletes.Name = "nudBilletes"
        Me.nudBilletes.Size = New System.Drawing.Size(64, 20)
        Me.nudBilletes.TabIndex = 9
        Me.nudBilletes.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cbTarifa
        '
        Me.cbTarifa.FormattingEnabled = True
        Me.cbTarifa.Items.AddRange(New Object() {"---seleccione tarifa---", "Básica.......150€", "Clásica......200€", "Extra..........300€", "VIP.............500€"})
        Me.cbTarifa.Location = New System.Drawing.Point(13, 185)
        Me.cbTarifa.Name = "cbTarifa"
        Me.cbTarifa.Size = New System.Drawing.Size(154, 21)
        Me.cbTarifa.TabIndex = 10
        Me.cbTarifa.Text = "---seleccione tarifa---"
        '
        'btnAñadir
        '
        Me.btnAñadir.Location = New System.Drawing.Point(188, 159)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(115, 96)
        Me.btnAñadir.TabIndex = 11
        Me.btnAñadir.Text = "Añadir vuelo"
        Me.btnAñadir.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(520, 159)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(67, 96)
        Me.btnEliminar.TabIndex = 12
        Me.btnEliminar.Text = "Eliminar vuelo"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'lstVuelos
        '
        Me.lstVuelos.FormattingEnabled = True
        Me.lstVuelos.Location = New System.Drawing.Point(309, 161)
        Me.lstVuelos.Name = "lstVuelos"
        Me.lstVuelos.Size = New System.Drawing.Size(205, 95)
        Me.lstVuelos.TabIndex = 13
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Location = New System.Drawing.Point(309, 263)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(86, 13)
        Me.lblInfo.TabIndex = 14
        Me.lblInfo.Text = "Total a Pagar -->"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Location = New System.Drawing.Point(401, 259)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 24)
        Me.lblTotal.TabIndex = 15
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(85, 299)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 16
        Me.lblNombre.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(88, 315)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 17
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(194, 315)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(100, 20)
        Me.txtApellido.TabIndex = 19
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(191, 299)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(44, 13)
        Me.lblApellido.TabIndex = 18
        Me.lblApellido.Text = "Apellido"
        '
        'txtCP
        '
        Me.txtCP.Location = New System.Drawing.Point(300, 315)
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(100, 20)
        Me.txtCP.TabIndex = 21
        '
        'lblCP
        '
        Me.lblCP.AutoSize = True
        Me.lblCP.Location = New System.Drawing.Point(297, 299)
        Me.lblCP.Name = "lblCP"
        Me.lblCP.Size = New System.Drawing.Size(72, 13)
        Me.lblCP.TabIndex = 20
        Me.lblCP.Text = "Código Postal"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(423, 292)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(78, 65)
        Me.btnAceptar.TabIndex = 22
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(509, 292)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(78, 65)
        Me.btnCancelar.TabIndex = 23
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(12, 363)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(579, 24)
        Me.btnSalir.TabIndex = 24
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'lstPrecio
        '
        Me.lstPrecio.FormattingEnabled = True
        Me.lstPrecio.Location = New System.Drawing.Point(504, 161)
        Me.lstPrecio.Name = "lstPrecio"
        Me.lstPrecio.Size = New System.Drawing.Size(10, 95)
        Me.lstPrecio.TabIndex = 25
        Me.lstPrecio.Visible = False
        '
        'frnVuelos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 399)
        Me.Controls.Add(Me.lstPrecio)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtCP)
        Me.Controls.Add(Me.lblCP)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lstVuelos)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAñadir)
        Me.Controls.Add(Me.cbTarifa)
        Me.Controls.Add(Me.nudBilletes)
        Me.Controls.Add(Me.lblNumero)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstInternacional)
        Me.Controls.Add(Me.lstNacional)
        Me.Controls.Add(Me.rbtInternacional)
        Me.Controls.Add(Me.rbtNacional)
        Me.Controls.Add(Me.lblDestino)
        Me.Controls.Add(Me.cbOrigen)
        Me.Controls.Add(Me.lblOrigen)
        Me.Name = "frnVuelos"
        Me.Text = "Vuela con nosotros!!"
        CType(Me.nudBilletes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblOrigen As System.Windows.Forms.Label
    Friend WithEvents cbOrigen As System.Windows.Forms.ComboBox
    Friend WithEvents lblDestino As System.Windows.Forms.Label
    Friend WithEvents rbtNacional As System.Windows.Forms.RadioButton
    Friend WithEvents rbtInternacional As System.Windows.Forms.RadioButton
    Friend WithEvents lstNacional As System.Windows.Forms.ListBox
    Friend WithEvents lstInternacional As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblNumero As System.Windows.Forms.Label
    Friend WithEvents nudBilletes As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbTarifa As System.Windows.Forms.ComboBox
    Friend WithEvents btnAñadir As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents lstVuelos As System.Windows.Forms.ListBox
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents lblApellido As System.Windows.Forms.Label
    Friend WithEvents txtCP As System.Windows.Forms.TextBox
    Friend WithEvents lblCP As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents lstPrecio As System.Windows.Forms.ListBox

End Class
