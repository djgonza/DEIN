<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frnModificar
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
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnFoto = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPropietario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCP = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPoblacion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDir = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(441, 329)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(112, 35)
        Me.btnAceptar.TabIndex = 38
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(320, 329)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(112, 35)
        Me.btnCancelar.TabIndex = 37
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnFoto
        '
        Me.btnFoto.Location = New System.Drawing.Point(414, 285)
        Me.btnFoto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnFoto.Name = "btnFoto"
        Me.btnFoto.Size = New System.Drawing.Size(140, 26)
        Me.btnFoto.TabIndex = 36
        Me.btnFoto.Text = "..."
        Me.btnFoto.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(410, 260)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 20)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Foto:"
        '
        'txtPrecio
        '
        Me.txtPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio.Location = New System.Drawing.Point(18, 285)
        Me.txtPrecio.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(385, 26)
        Me.txtPrecio.TabIndex = 34
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 260)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 20)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Precio:"
        '
        'txtPropietario
        '
        Me.txtPropietario.Location = New System.Drawing.Point(18, 225)
        Me.txtPropietario.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPropietario.Name = "txtPropietario"
        Me.txtPropietario.Size = New System.Drawing.Size(534, 26)
        Me.txtPropietario.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 200)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 20)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Propietario:"
        '
        'txtCP
        '
        Me.txtCP.Location = New System.Drawing.Point(414, 165)
        Me.txtCP.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(138, 26)
        Me.txtCP.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(410, 140)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 20)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "CP:"
        '
        'txtPoblacion
        '
        Me.txtPoblacion.Location = New System.Drawing.Point(18, 165)
        Me.txtPoblacion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPoblacion.Name = "txtPoblacion"
        Me.txtPoblacion.Size = New System.Drawing.Size(385, 26)
        Me.txtPoblacion.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 140)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 20)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Población:"
        '
        'txtDir
        '
        Me.txtDir.Location = New System.Drawing.Point(18, 97)
        Me.txtDir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDir.Name = "txtDir"
        Me.txtDir.Size = New System.Drawing.Size(534, 26)
        Me.txtDir.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 72)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 20)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Dirección:"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(18, 37)
        Me.txtId.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(138, 26)
        Me.txtId.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 12)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Id casa:"
        '
        'frnModificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(568, 380)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnFoto)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtPropietario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCP)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPoblacion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frnModificar"
        Me.Text = "Modificar casa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnFoto As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPropietario As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCP As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPoblacion As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDir As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
