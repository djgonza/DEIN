<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frnTienda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frnTienda))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstArticulo = New System.Windows.Forms.ListBox()
        Me.lstTipo = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstPrecio = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstUnidades = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.picImagen = New System.Windows.Forms.PictureBox()
        Me.btnEliminarSelec = New System.Windows.Forms.Button()
        Me.btnEliminarProd = New System.Windows.Forms.Button()
        Me.cmbProductos = New System.Windows.Forms.ComboBox()
        Me.txtUnidades = New System.Windows.Forms.TextBox()
        Me.btnUniComprar = New System.Windows.Forms.Button()
        Me.cbDescuento = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gpbUnidades = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnComprar = New System.Windows.Forms.Button()
        Me.gpbNew = New System.Windows.Forms.GroupBox()
        Me.txtUniAña = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtArticulo = New System.Windows.Forms.TextBox()
        Me.cmbProductos2 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        CType(Me.picImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbUnidades.SuspendLayout()
        Me.gpbNew.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Articulo"
        '
        'lstArticulo
        '
        Me.lstArticulo.FormattingEnabled = True
        Me.lstArticulo.Location = New System.Drawing.Point(12, 29)
        Me.lstArticulo.Name = "lstArticulo"
        Me.lstArticulo.Size = New System.Drawing.Size(120, 121)
        Me.lstArticulo.TabIndex = 10
        '
        'lstTipo
        '
        Me.lstTipo.Enabled = False
        Me.lstTipo.FormattingEnabled = True
        Me.lstTipo.Location = New System.Drawing.Point(138, 29)
        Me.lstTipo.Name = "lstTipo"
        Me.lstTipo.Size = New System.Drawing.Size(120, 121)
        Me.lstTipo.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(135, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Tipo de producto"
        '
        'lstPrecio
        '
        Me.lstPrecio.Enabled = False
        Me.lstPrecio.FormattingEnabled = True
        Me.lstPrecio.Location = New System.Drawing.Point(264, 29)
        Me.lstPrecio.Name = "lstPrecio"
        Me.lstPrecio.Size = New System.Drawing.Size(34, 121)
        Me.lstPrecio.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(261, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Precio"
        '
        'lstUnidades
        '
        Me.lstUnidades.Enabled = False
        Me.lstUnidades.FormattingEnabled = True
        Me.lstUnidades.Location = New System.Drawing.Point(304, 29)
        Me.lstUnidades.Name = "lstUnidades"
        Me.lstUnidades.Size = New System.Drawing.Size(58, 121)
        Me.lstUnidades.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(301, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Disponibles"
        '
        'picImagen
        '
        Me.picImagen.Image = CType(resources.GetObject("picImagen.Image"), System.Drawing.Image)
        Me.picImagen.Location = New System.Drawing.Point(368, 12)
        Me.picImagen.Name = "picImagen"
        Me.picImagen.Size = New System.Drawing.Size(166, 138)
        Me.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picImagen.TabIndex = 22
        Me.picImagen.TabStop = False
        '
        'btnEliminarSelec
        '
        Me.btnEliminarSelec.Location = New System.Drawing.Point(12, 156)
        Me.btnEliminarSelec.Name = "btnEliminarSelec"
        Me.btnEliminarSelec.Size = New System.Drawing.Size(211, 29)
        Me.btnEliminarSelec.TabIndex = 23
        Me.btnEliminarSelec.Text = "Eliminar artículo seleccionado"
        Me.btnEliminarSelec.UseVisualStyleBackColor = True
        '
        'btnEliminarProd
        '
        Me.btnEliminarProd.Location = New System.Drawing.Point(229, 156)
        Me.btnEliminarProd.Name = "btnEliminarProd"
        Me.btnEliminarProd.Size = New System.Drawing.Size(164, 29)
        Me.btnEliminarProd.TabIndex = 24
        Me.btnEliminarProd.Text = "Eliminar productos -->"
        Me.btnEliminarProd.UseVisualStyleBackColor = True
        '
        'cmbProductos
        '
        Me.cmbProductos.FormattingEnabled = True
        Me.cmbProductos.Items.AddRange(New Object() {"Camisetas", "Gorras", "Zapatillas", "Pantalones", "Cazadoras"})
        Me.cmbProductos.Location = New System.Drawing.Point(399, 161)
        Me.cmbProductos.Name = "cmbProductos"
        Me.cmbProductos.Size = New System.Drawing.Size(134, 21)
        Me.cmbProductos.TabIndex = 25
        '
        'txtUnidades
        '
        Me.txtUnidades.Location = New System.Drawing.Point(217, 19)
        Me.txtUnidades.Name = "txtUnidades"
        Me.txtUnidades.Size = New System.Drawing.Size(164, 20)
        Me.txtUnidades.TabIndex = 27
        '
        'btnUniComprar
        '
        Me.btnUniComprar.Location = New System.Drawing.Point(6, 19)
        Me.btnUniComprar.Name = "btnUniComprar"
        Me.btnUniComprar.Size = New System.Drawing.Size(205, 29)
        Me.btnUniComprar.TabIndex = 26
        Me.btnUniComprar.Text = "Unidades a comprar -->"
        Me.btnUniComprar.UseVisualStyleBackColor = True
        '
        'cbDescuento
        '
        Me.cbDescuento.AutoSize = True
        Me.cbDescuento.Location = New System.Drawing.Point(388, 19)
        Me.cbDescuento.Name = "cbDescuento"
        Me.cbDescuento.Size = New System.Drawing.Size(99, 17)
        Me.cbDescuento.TabIndex = 28
        Me.cbDescuento.Text = "Aplicar dto 10%"
        Me.cbDescuento.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(401, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 20)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "CATÁLOGO"
        '
        'gpbUnidades
        '
        Me.gpbUnidades.Controls.Add(Me.btnUniComprar)
        Me.gpbUnidades.Controls.Add(Me.txtUnidades)
        Me.gpbUnidades.Controls.Add(Me.cbDescuento)
        Me.gpbUnidades.Location = New System.Drawing.Point(12, 191)
        Me.gpbUnidades.Name = "gpbUnidades"
        Me.gpbUnidades.Size = New System.Drawing.Size(522, 67)
        Me.gpbUnidades.TabIndex = 30
        Me.gpbUnidades.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 265)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(181, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Articulo --- Unidades --- Total a Pagar"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(15, 282)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(378, 20)
        Me.TextBox1.TabIndex = 32
        '
        'btnComprar
        '
        Me.btnComprar.Location = New System.Drawing.Point(399, 264)
        Me.btnComprar.Name = "btnComprar"
        Me.btnComprar.Size = New System.Drawing.Size(135, 58)
        Me.btnComprar.TabIndex = 33
        Me.btnComprar.Text = "Comprar // Cancelar"
        Me.btnComprar.UseVisualStyleBackColor = True
        '
        'gpbNew
        '
        Me.gpbNew.Controls.Add(Me.txtUniAña)
        Me.gpbNew.Controls.Add(Me.txtPrecio)
        Me.gpbNew.Controls.Add(Me.txtArticulo)
        Me.gpbNew.Controls.Add(Me.cmbProductos2)
        Me.gpbNew.Controls.Add(Me.Label7)
        Me.gpbNew.Controls.Add(Me.Label8)
        Me.gpbNew.Controls.Add(Me.Label9)
        Me.gpbNew.Controls.Add(Me.Label10)
        Me.gpbNew.Controls.Add(Me.btnNuevo)
        Me.gpbNew.Location = New System.Drawing.Point(12, 330)
        Me.gpbNew.Name = "gpbNew"
        Me.gpbNew.Size = New System.Drawing.Size(522, 102)
        Me.gpbNew.TabIndex = 34
        Me.gpbNew.TabStop = False
        Me.gpbNew.Text = "Nuevo Artículo"
        '
        'txtUniAña
        '
        Me.txtUniAña.Location = New System.Drawing.Point(416, 62)
        Me.txtUniAña.Name = "txtUniAña"
        Me.txtUniAña.Size = New System.Drawing.Size(100, 20)
        Me.txtUniAña.TabIndex = 29
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(310, 61)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 28
        '
        'txtArticulo
        '
        Me.txtArticulo.Location = New System.Drawing.Point(6, 61)
        Me.txtArticulo.Name = "txtArticulo"
        Me.txtArticulo.Size = New System.Drawing.Size(158, 20)
        Me.txtArticulo.TabIndex = 27
        '
        'cmbProductos2
        '
        Me.cmbProductos2.FormattingEnabled = True
        Me.cmbProductos2.Items.AddRange(New Object() {"Camisetas", "Gorrar", "Zapatillas", "Pantalones", "Cazadoras"})
        Me.cmbProductos2.Location = New System.Drawing.Point(170, 60)
        Me.cmbProductos2.Name = "cmbProductos2"
        Me.cmbProductos2.Size = New System.Drawing.Size(134, 21)
        Me.cmbProductos2.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(413, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Unidades"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(313, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Precio"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(167, 45)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Tipo de producto"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 45)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Articulo"
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(6, 19)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(510, 23)
        Me.btnNuevo.TabIndex = 0
        Me.btnNuevo.Text = "Nuevo artículo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(12, 438)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(522, 46)
        Me.btnSalir.TabIndex = 35
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frnTienda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 496)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.gpbNew)
        Me.Controls.Add(Me.btnComprar)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.gpbUnidades)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbProductos)
        Me.Controls.Add(Me.btnEliminarProd)
        Me.Controls.Add(Me.btnEliminarSelec)
        Me.Controls.Add(Me.picImagen)
        Me.Controls.Add(Me.lstUnidades)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lstPrecio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstTipo)
        Me.Controls.Add(Me.lstArticulo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frnTienda"
        Me.Text = "TieNDa"
        CType(Me.picImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbUnidades.ResumeLayout(False)
        Me.gpbUnidades.PerformLayout()
        Me.gpbNew.ResumeLayout(False)
        Me.gpbNew.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstArticulo As System.Windows.Forms.ListBox
    Friend WithEvents lstTipo As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lstPrecio As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lstUnidades As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents picImagen As System.Windows.Forms.PictureBox
    Friend WithEvents btnEliminarSelec As System.Windows.Forms.Button
    Friend WithEvents btnEliminarProd As System.Windows.Forms.Button
    Friend WithEvents cmbProductos As System.Windows.Forms.ComboBox
    Friend WithEvents txtUnidades As System.Windows.Forms.TextBox
    Friend WithEvents btnUniComprar As System.Windows.Forms.Button
    Friend WithEvents cbDescuento As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents gpbUnidades As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnComprar As System.Windows.Forms.Button
    Friend WithEvents gpbNew As System.Windows.Forms.GroupBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents txtArticulo As System.Windows.Forms.TextBox
    Friend WithEvents cmbProductos2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents txtUniAña As System.Windows.Forms.TextBox

End Class
