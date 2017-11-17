<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frnClasi
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
        Me.lstPais = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lstTotal = New System.Windows.Forms.ListBox()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.nupMedallas = New System.Windows.Forms.NumericUpDown()
        Me.btnVuelta = New System.Windows.Forms.Button()
        Me.btnOcultar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.nupMedallas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstPais
        '
        Me.lstPais.FormattingEnabled = True
        Me.lstPais.Items.AddRange(New Object() {"ARGENTINA", "CANADA", "DINAMARCA", "FRANCIA", "ITALIA", "GRECIA", "BRASIL", "KENIA", "AUSTRALIA"})
        Me.lstPais.Location = New System.Drawing.Point(48, 42)
        Me.lstPais.Name = "lstPais"
        Me.lstPais.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstPais.Size = New System.Drawing.Size(120, 121)
        Me.lstPais.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "País"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(180, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Total"
        '
        'lstTotal
        '
        Me.lstTotal.Enabled = False
        Me.lstTotal.FormattingEnabled = True
        Me.lstTotal.Location = New System.Drawing.Point(183, 42)
        Me.lstTotal.Name = "lstTotal"
        Me.lstTotal.Size = New System.Drawing.Size(81, 121)
        Me.lstTotal.TabIndex = 10
        '
        'btnAnterior
        '
        Me.btnAnterior.Enabled = False
        Me.btnAnterior.Location = New System.Drawing.Point(48, 169)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(98, 23)
        Me.btnAnterior.TabIndex = 12
        Me.btnAnterior.Text = "Anterior"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(166, 169)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(98, 23)
        Me.btnSiguiente.TabIndex = 13
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'nupMedallas
        '
        Me.nupMedallas.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nupMedallas.Location = New System.Drawing.Point(174, 208)
        Me.nupMedallas.Name = "nupMedallas"
        Me.nupMedallas.Size = New System.Drawing.Size(42, 38)
        Me.nupMedallas.TabIndex = 15
        '
        'btnVuelta
        '
        Me.btnVuelta.Location = New System.Drawing.Point(51, 270)
        Me.btnVuelta.Name = "btnVuelta"
        Me.btnVuelta.Size = New System.Drawing.Size(213, 49)
        Me.btnVuelta.TabIndex = 16
        Me.btnVuelta.Text = "Volver al medallero"
        Me.btnVuelta.UseVisualStyleBackColor = True
        '
        'btnOcultar
        '
        Me.btnOcultar.Location = New System.Drawing.Point(48, 208)
        Me.btnOcultar.Name = "btnOcultar"
        Me.btnOcultar.Size = New System.Drawing.Size(120, 38)
        Me.btnOcultar.TabIndex = 17
        Me.btnOcultar.Text = "Ocultar los países con un número de medallas igual a:"
        Me.btnOcultar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(35, 253)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(226, 10)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Label2"
        '
        'frnClasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(286, 340)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnOcultar)
        Me.Controls.Add(Me.btnVuelta)
        Me.Controls.Add(Me.nupMedallas)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lstTotal)
        Me.Controls.Add(Me.lstPais)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frnClasi"
        Me.Text = "Juegos Olímpicos - CLaSiFiCaCioN"
        CType(Me.nupMedallas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstPais As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lstTotal As System.Windows.Forms.ListBox
    Friend WithEvents btnAnterior As System.Windows.Forms.Button
    Friend WithEvents btnSiguiente As System.Windows.Forms.Button
    Friend WithEvents nupMedallas As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnVuelta As System.Windows.Forms.Button
    Friend WithEvents btnOcultar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
