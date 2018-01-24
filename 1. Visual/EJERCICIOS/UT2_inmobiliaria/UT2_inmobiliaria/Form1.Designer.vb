<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frnPrincipal
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
        Me.lstCasas = New System.Windows.Forms.ListBox()
        Me.pbCasa = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPoblacion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCP = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        CType(Me.pbCasa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleccione las casas:"
        '
        'lstCasas
        '
        Me.lstCasas.FormattingEnabled = True
        Me.lstCasas.ItemHeight = 20
        Me.lstCasas.Location = New System.Drawing.Point(18, 38)
        Me.lstCasas.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstCasas.Name = "lstCasas"
        Me.lstCasas.Size = New System.Drawing.Size(499, 284)
        Me.lstCasas.TabIndex = 1
        '
        'pbCasa
        '
        Me.pbCasa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbCasa.Location = New System.Drawing.Point(528, 38)
        Me.pbCasa.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pbCasa.Name = "pbCasa"
        Me.pbCasa.Size = New System.Drawing.Size(252, 285)
        Me.pbCasa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCasa.TabIndex = 2
        Me.pbCasa.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 329)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Id casa:"
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(18, 354)
        Me.txtId.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(138, 26)
        Me.txtId.TabIndex = 4
        '
        'txtDireccion
        '
        Me.txtDireccion.Enabled = False
        Me.txtDireccion.Location = New System.Drawing.Point(166, 354)
        Me.txtDireccion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(613, 26)
        Me.txtDireccion.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(162, 329)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Dirección:"
        '
        'txtPoblacion
        '
        Me.txtPoblacion.Enabled = False
        Me.txtPoblacion.Location = New System.Drawing.Point(18, 414)
        Me.txtPoblacion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPoblacion.Name = "txtPoblacion"
        Me.txtPoblacion.Size = New System.Drawing.Size(408, 26)
        Me.txtPoblacion.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 389)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Población:"
        '
        'txtCP
        '
        Me.txtCP.Enabled = False
        Me.txtCP.Location = New System.Drawing.Point(436, 414)
        Me.txtCP.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(138, 26)
        Me.txtCP.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(432, 389)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "CP:"
        '
        'txtPrecio
        '
        Me.txtPrecio.Enabled = False
        Me.txtPrecio.Location = New System.Drawing.Point(585, 414)
        Me.txtPrecio.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(194, 26)
        Me.txtPrecio.TabIndex = 12
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(580, 389)
        Me.lblPrecio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(57, 20)
        Me.lblPrecio.TabIndex = 11
        Me.lblPrecio.Text = "Precio:"
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(153, 454)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(130, 40)
        Me.btnNuevo.TabIndex = 13
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(292, 454)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(130, 40)
        Me.btnModificar.TabIndex = 14
        Me.btnModificar.Text = "&Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(432, 454)
        Me.btnBorrar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(130, 40)
        Me.btnBorrar.TabIndex = 15
        Me.btnBorrar.Text = "&Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(572, 454)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(130, 40)
        Me.btnSalir.TabIndex = 16
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frnPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 511)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.txtCP)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPoblacion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pbCasa)
        Me.Controls.Add(Me.lstCasas)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frnPrincipal"
        Me.Text = "Listado de casas"
        CType(Me.pbCasa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstCasas As System.Windows.Forms.ListBox
    Friend WithEvents pbCasa As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPoblacion As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCP As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents lblPrecio As System.Windows.Forms.Label
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button

End Class
