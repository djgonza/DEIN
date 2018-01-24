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
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.lstNombres = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPosicion = New System.Windows.Forms.TextBox()
        Me.txtNacionalidad = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAñadir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(12, 12)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(157, 61)
        Me.btnMostrar.TabIndex = 0
        Me.btnMostrar.Text = "mostrar nombre jugadores"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'lstNombres
        '
        Me.lstNombres.FormattingEnabled = True
        Me.lstNombres.ItemHeight = 24
        Me.lstNombres.Location = New System.Drawing.Point(12, 79)
        Me.lstNombres.Name = "lstNombres"
        Me.lstNombres.Size = New System.Drawing.Size(157, 196)
        Me.lstNombres.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(202, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Posición: "
        '
        'txtPosicion
        '
        Me.txtPosicion.Enabled = False
        Me.txtPosicion.Location = New System.Drawing.Point(328, 12)
        Me.txtPosicion.Name = "txtPosicion"
        Me.txtPosicion.Size = New System.Drawing.Size(165, 29)
        Me.txtPosicion.TabIndex = 3
        '
        'txtNacionalidad
        '
        Me.txtNacionalidad.Enabled = False
        Me.txtNacionalidad.Location = New System.Drawing.Point(328, 44)
        Me.txtNacionalidad.Name = "txtNacionalidad"
        Me.txtNacionalidad.Size = New System.Drawing.Size(165, 29)
        Me.txtNacionalidad.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(202, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nacionalidad:"
        '
        'btnAñadir
        '
        Me.btnAñadir.Location = New System.Drawing.Point(256, 79)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(141, 71)
        Me.btnAñadir.TabIndex = 6
        Me.btnAñadir.Text = "Añadir a la lista"
        Me.btnAñadir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 482)
        Me.Controls.Add(Me.btnAñadir)
        Me.Controls.Add(Me.txtNacionalidad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPosicion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstNombres)
        Me.Controls.Add(Me.btnMostrar)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMostrar As System.Windows.Forms.Button
    Friend WithEvents lstNombres As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPosicion As System.Windows.Forms.TextBox
    Friend WithEvents txtNacionalidad As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAñadir As System.Windows.Forms.Button

End Class
