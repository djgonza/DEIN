<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frnApuntes2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.btnBS = New System.Windows.Forms.Button()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtProvincia = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCiudad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.plnMovimiento = New System.Windows.Forms.Panel()
        Me.etPosicion = New System.Windows.Forms.Label()
        Me.btnAvanzar = New System.Windows.Forms.Button()
        Me.btnFinal = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnPrincipio = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnFind1 = New System.Windows.Forms.Button()
        Me.btnFind2 = New System.Windows.Forms.Button()
        Me.btnBs2 = New System.Windows.Forms.Button()
        Me.btnRenew = New System.Windows.Forms.Button()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.btnSiguiente2 = New System.Windows.Forms.Button()
        Me.plnMovimiento.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Id. cliente:"
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Location = New System.Drawing.Point(15, 25)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(100, 20)
        Me.txtIdCliente.TabIndex = 1
        '
        'btnBS
        '
        Me.btnBS.Location = New System.Drawing.Point(172, 9)
        Me.btnBS.Name = "btnBS"
        Me.btnBS.Size = New System.Drawing.Size(86, 39)
        Me.btnBS.TabIndex = 2
        Me.btnBS.Text = "BS"
        Me.btnBS.UseVisualStyleBackColor = True
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(15, 73)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(151, 20)
        Me.txtApellido.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "&Apellido"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(172, 73)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(172, 20)
        Me.txtNombre.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(169, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "&Nombre:"
        '
        'txtProvincia
        '
        Me.txtProvincia.Location = New System.Drawing.Point(172, 117)
        Me.txtProvincia.Name = "txtProvincia"
        Me.txtProvincia.Size = New System.Drawing.Size(172, 20)
        Me.txtProvincia.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(169, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "&Provincia:"
        '
        'txtCiudad
        '
        Me.txtCiudad.Location = New System.Drawing.Point(15, 117)
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(151, 20)
        Me.txtCiudad.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "&Ciudad:"
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(15, 181)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 15
        Me.btnNuevo.Text = "N&uevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(96, 181)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 16
        Me.btnActualizar.Text = "Ac&tualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(188, 181)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrar.TabIndex = 17
        Me.btnBorrar.Text = "&Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(269, 181)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 18
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(96, 181)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 20
        Me.btnCancelar.Text = "Ca&ncelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        Me.btnCancelar.Visible = False
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(15, 181)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 19
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
        Me.plnMovimiento.Location = New System.Drawing.Point(15, 143)
        Me.plnMovimiento.Name = "plnMovimiento"
        Me.plnMovimiento.Size = New System.Drawing.Size(332, 32)
        Me.plnMovimiento.TabIndex = 22
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
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(96, 248)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(90, 212)
        Me.ListBox1.TabIndex = 23
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 248)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 44)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Cargar ListBox"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(356, 628)
        Me.ShapeContainer1.TabIndex = 25
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderWidth = 14
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 17
        Me.LineShape1.X2 = 337
        Me.LineShape1.Y1 = 220
        Me.LineShape1.Y2 = 220
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 299)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 46)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "Cargar Listbox II"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnFind1
        '
        Me.btnFind1.Location = New System.Drawing.Point(192, 248)
        Me.btnFind1.Name = "btnFind1"
        Me.btnFind1.Size = New System.Drawing.Size(75, 23)
        Me.btnFind1.TabIndex = 27
        Me.btnFind1.Text = "FIND1"
        Me.btnFind1.UseVisualStyleBackColor = True
        '
        'btnFind2
        '
        Me.btnFind2.Location = New System.Drawing.Point(192, 277)
        Me.btnFind2.Name = "btnFind2"
        Me.btnFind2.Size = New System.Drawing.Size(75, 23)
        Me.btnFind2.TabIndex = 28
        Me.btnFind2.Text = "FIND2"
        Me.btnFind2.UseVisualStyleBackColor = True
        '
        'btnBs2
        '
        Me.btnBs2.Location = New System.Drawing.Point(192, 306)
        Me.btnBs2.Name = "btnBs2"
        Me.btnBs2.Size = New System.Drawing.Size(86, 39)
        Me.btnBs2.TabIndex = 29
        Me.btnBs2.Text = "BS2"
        Me.btnBs2.UseVisualStyleBackColor = True
        '
        'btnRenew
        '
        Me.btnRenew.Location = New System.Drawing.Point(192, 403)
        Me.btnRenew.Name = "btnRenew"
        Me.btnRenew.Size = New System.Drawing.Size(75, 23)
        Me.btnRenew.TabIndex = 30
        Me.btnRenew.Text = "Actualizar"
        Me.btnRenew.UseVisualStyleBackColor = True
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Location = New System.Drawing.Point(192, 351)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(100, 20)
        Me.txtBusqueda.TabIndex = 31
        '
        'btnSiguiente2
        '
        Me.btnSiguiente2.Location = New System.Drawing.Point(192, 377)
        Me.btnSiguiente2.Name = "btnSiguiente2"
        Me.btnSiguiente2.Size = New System.Drawing.Size(75, 23)
        Me.btnSiguiente2.TabIndex = 32
        Me.btnSiguiente2.Text = "->"
        Me.btnSiguiente2.UseVisualStyleBackColor = True
        '
        'frnApuntes2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 628)
        Me.Controls.Add(Me.btnSiguiente2)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Controls.Add(Me.btnRenew)
        Me.Controls.Add(Me.btnBs2)
        Me.Controls.Add(Me.btnFind2)
        Me.Controls.Add(Me.btnFind1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.plnMovimiento)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.txtProvincia)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCiudad)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnBS)
        Me.Controls.Add(Me.txtIdCliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "frnApuntes2"
        Me.Text = "Gestión de clientes"
        Me.plnMovimiento.ResumeLayout(False)
        Me.plnMovimiento.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtIdCliente As System.Windows.Forms.TextBox
    Friend WithEvents btnBS As System.Windows.Forms.Button
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtProvincia As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCiudad As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents plnMovimiento As System.Windows.Forms.Panel
    Friend WithEvents etPosicion As System.Windows.Forms.Label
    Friend WithEvents btnAvanzar As System.Windows.Forms.Button
    Friend WithEvents btnFinal As System.Windows.Forms.Button
    Friend WithEvents btnAnterior As System.Windows.Forms.Button
    Friend WithEvents btnPrincipio As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnFind1 As System.Windows.Forms.Button
    Friend WithEvents btnFind2 As System.Windows.Forms.Button
    Friend WithEvents btnBs2 As System.Windows.Forms.Button
    Friend WithEvents btnRenew As System.Windows.Forms.Button
    Friend WithEvents txtBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents btnSiguiente2 As System.Windows.Forms.Button

End Class
