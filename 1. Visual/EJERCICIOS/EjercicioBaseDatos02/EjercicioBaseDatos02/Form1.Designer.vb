<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frnEjercicio02
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
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.plnMovimiento = New System.Windows.Forms.Panel()
        Me.etPosicion = New System.Windows.Forms.Label()
        Me.btnAvanzar = New System.Windows.Forms.Button()
        Me.btnFinal = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnPrincipio = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.txtFoto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtArtista = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRef = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbImagen = New System.Windows.Forms.PictureBox()
        Me.plnMovimiento.SuspendLayout()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(93, 295)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 39
        Me.btnCancelar.Text = "Ca&ncelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        Me.btnCancelar.Visible = False
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(12, 295)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 38
        Me.btnAceptar.Text = "Ace&ptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        Me.btnAceptar.Visible = False
        '
        'plnMovimiento
        '
        Me.plnMovimiento.Controls.Add(Me.etPosicion)
        Me.plnMovimiento.Controls.Add(Me.btnAvanzar)
        Me.plnMovimiento.Controls.Add(Me.btnFinal)
        Me.plnMovimiento.Controls.Add(Me.btnAnterior)
        Me.plnMovimiento.Controls.Add(Me.btnPrincipio)
        Me.plnMovimiento.Location = New System.Drawing.Point(12, 257)
        Me.plnMovimiento.Name = "plnMovimiento"
        Me.plnMovimiento.Size = New System.Drawing.Size(332, 32)
        Me.plnMovimiento.TabIndex = 40
        '
        'etPosicion
        '
        Me.etPosicion.AutoSize = True
        Me.etPosicion.Location = New System.Drawing.Point(132, 10)
        Me.etPosicion.Name = "etPosicion"
        Me.etPosicion.Size = New System.Drawing.Size(39, 13)
        Me.etPosicion.TabIndex = 26
        Me.etPosicion.Text = "Label6"
        '
        'btnAvanzar
        '
        Me.btnAvanzar.Location = New System.Drawing.Point(269, 0)
        Me.btnAvanzar.Name = "btnAvanzar"
        Me.btnAvanzar.Size = New System.Drawing.Size(28, 32)
        Me.btnAvanzar.TabIndex = 25
        Me.btnAvanzar.Text = ">"
        Me.btnAvanzar.UseVisualStyleBackColor = True
        '
        'btnFinal
        '
        Me.btnFinal.Location = New System.Drawing.Point(303, 0)
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
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(266, 295)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 37
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(185, 295)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrar.TabIndex = 36
        Me.btnBorrar.Text = "&Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(93, 295)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 35
        Me.btnActualizar.Text = "Ac&tualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(12, 295)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 34
        Me.btnNuevo.Text = "N&uevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'txtFoto
        '
        Me.txtFoto.Location = New System.Drawing.Point(12, 190)
        Me.txtFoto.Name = "txtFoto"
        Me.txtFoto.Size = New System.Drawing.Size(151, 20)
        Me.txtFoto.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "&Foto Prod.:"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(12, 151)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(151, 20)
        Me.txtPrecio.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "&Precio Prod:"
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(12, 112)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(151, 20)
        Me.txtTitulo.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "&Título:"
        '
        'txtArtista
        '
        Me.txtArtista.Location = New System.Drawing.Point(12, 73)
        Me.txtArtista.Name = "txtArtista"
        Me.txtArtista.Size = New System.Drawing.Size(151, 20)
        Me.txtArtista.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "&Artista"
        '
        'txtRef
        '
        Me.txtRef.Location = New System.Drawing.Point(12, 25)
        Me.txtRef.Name = "txtRef"
        Me.txtRef.Size = New System.Drawing.Size(151, 20)
        Me.txtRef.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "&Ref. Producto:"
        '
        'pbImagen
        '
        Me.pbImagen.Location = New System.Drawing.Point(185, 25)
        Me.pbImagen.Name = "pbImagen"
        Me.pbImagen.Size = New System.Drawing.Size(156, 162)
        Me.pbImagen.TabIndex = 41
        Me.pbImagen.TabStop = False
        '
        'frnEjercicio02
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 522)
        Me.Controls.Add(Me.pbImagen)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.plnMovimiento)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.txtFoto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTitulo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtArtista)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtRef)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frnEjercicio02"
        Me.Text = "Ejercicio02"
        Me.plnMovimiento.ResumeLayout(False)
        Me.plnMovimiento.PerformLayout()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents plnMovimiento As System.Windows.Forms.Panel
    Friend WithEvents etPosicion As System.Windows.Forms.Label
    Friend WithEvents btnAvanzar As System.Windows.Forms.Button
    Friend WithEvents btnFinal As System.Windows.Forms.Button
    Friend WithEvents btnAnterior As System.Windows.Forms.Button
    Friend WithEvents btnPrincipio As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents txtFoto As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTitulo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtArtista As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtRef As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pbImagen As System.Windows.Forms.PictureBox

End Class
