<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.etIntento = New System.Windows.Forms.Label()
        Me.etResultado = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnFinalizar = New System.Windows.Forms.Button()
        Me.btnVerificar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(168, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Adivine el número"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(159, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Introduzca número"
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(148, 85)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(159, 30)
        Me.txtNumero.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(168, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Intento:"
        '
        'etIntento
        '
        Me.etIntento.AutoSize = True
        Me.etIntento.Location = New System.Drawing.Point(263, 129)
        Me.etIntento.Name = "etIntento"
        Me.etIntento.Size = New System.Drawing.Size(17, 23)
        Me.etIntento.TabIndex = 4
        Me.etIntento.Text = "1"
        '
        'etResultado
        '
        Me.etResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etResultado.Location = New System.Drawing.Point(52, 244)
        Me.etResultado.Name = "etResultado"
        Me.etResultado.Size = New System.Drawing.Size(369, 32)
        Me.etResultado.TabIndex = 5
        Me.etResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(128, 210)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(227, 23)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "resultado de la comprobación:"
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(80, 292)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(112, 33)
        Me.btnNuevo.TabIndex = 7
        Me.btnNuevo.Text = "&Nuevo Juego"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnFinalizar
        '
        Me.btnFinalizar.Location = New System.Drawing.Point(251, 294)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Size = New System.Drawing.Size(130, 31)
        Me.btnFinalizar.TabIndex = 8
        Me.btnFinalizar.Text = "&Finalizar"
        Me.btnFinalizar.UseVisualStyleBackColor = True
        '
        'btnVerificar
        '
        Me.btnVerificar.Location = New System.Drawing.Point(80, 163)
        Me.btnVerificar.Name = "btnVerificar"
        Me.btnVerificar.Size = New System.Drawing.Size(301, 30)
        Me.btnVerificar.TabIndex = 9
        Me.btnVerificar.Text = "&Verificar"
        Me.btnVerificar.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 380)
        Me.Controls.Add(Me.btnVerificar)
        Me.Controls.Add(Me.btnFinalizar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.etResultado)
        Me.Controls.Add(Me.etIntento)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents etIntento As System.Windows.Forms.Label
    Friend WithEvents etResultado As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnFinalizar As System.Windows.Forms.Button
    Friend WithEvents btnVerificar As System.Windows.Forms.Button
End Class
