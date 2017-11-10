<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frnCambioPelicula
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
        Me.cmbSalas = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtActual = New System.Windows.Forms.TextBox()
        Me.txtNueva = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbSalas
        '
        Me.cmbSalas.FormattingEnabled = True
        Me.cmbSalas.Items.AddRange(New Object() {"Sala 1", "Sala 2", "Sala 3", "Sala 4"})
        Me.cmbSalas.Location = New System.Drawing.Point(12, 12)
        Me.cmbSalas.Name = "cmbSalas"
        Me.cmbSalas.Size = New System.Drawing.Size(121, 21)
        Me.cmbSalas.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Pelicula Actual"
        '
        'txtActual
        '
        Me.txtActual.Location = New System.Drawing.Point(12, 70)
        Me.txtActual.Name = "txtActual"
        Me.txtActual.Size = New System.Drawing.Size(239, 20)
        Me.txtActual.TabIndex = 3
        '
        'txtNueva
        '
        Me.txtNueva.Location = New System.Drawing.Point(12, 144)
        Me.txtNueva.Name = "txtNueva"
        Me.txtNueva.Size = New System.Drawing.Size(239, 20)
        Me.txtNueva.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nueva Pelicula"
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(372, 12)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(88, 36)
        Me.btnVolver.TabIndex = 6
        Me.btnVolver.Text = "&Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(372, 135)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(88, 36)
        Me.btnActualizar.TabIndex = 7
        Me.btnActualizar.Text = "&Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'frnCambioPelicula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 179)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.txtNueva)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtActual)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbSalas)
        Me.Name = "frnCambioPelicula"
        Me.Text = "CAMBIO DE PELÍCULA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbSalas As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtActual As System.Windows.Forms.TextBox
    Friend WithEvents txtNueva As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
End Class
