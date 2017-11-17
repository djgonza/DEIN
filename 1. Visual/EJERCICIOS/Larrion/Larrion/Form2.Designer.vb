<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frnMedallero
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lstPais = New System.Windows.Forms.ListBox()
        Me.lstOro = New System.Windows.Forms.ListBox()
        Me.lstPlata = New System.Windows.Forms.ListBox()
        Me.lstBronce = New System.Windows.Forms.ListBox()
        Me.lstTotal = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSeleccionPatron = New System.Windows.Forms.Button()
        Me.txtPatron = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lstTotalSelec = New System.Windows.Forms.ListBox()
        Me.btnMas = New System.Windows.Forms.Button()
        Me.btnMenos = New System.Windows.Forms.Button()
        Me.rbtOro = New System.Windows.Forms.RadioButton()
        Me.rbtPlata = New System.Windows.Forms.RadioButton()
        Me.rbtBronce = New System.Windows.Forms.RadioButton()
        Me.lblTotalMedallas = New System.Windows.Forms.Label()
        Me.btnClasificacion = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "País"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(139, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Oro"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(178, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Plata"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(221, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Bronce"
        '
        'lstPais
        '
        Me.lstPais.FormattingEnabled = True
        Me.lstPais.Items.AddRange(New Object() {"ARGENTINA", "CANADA", "DINAMARCA", "FRANCIA", "ITALIA", "GRECIA", "BRASIL", "KENIA", "AUSTRALIA"})
        Me.lstPais.Location = New System.Drawing.Point(12, 25)
        Me.lstPais.Name = "lstPais"
        Me.lstPais.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstPais.Size = New System.Drawing.Size(120, 121)
        Me.lstPais.TabIndex = 4
        '
        'lstOro
        '
        Me.lstOro.Enabled = False
        Me.lstOro.FormattingEnabled = True
        Me.lstOro.Items.AddRange(New Object() {"1", "2", "3", "0", "0", "0", "1", "1", "0"})
        Me.lstOro.Location = New System.Drawing.Point(138, 25)
        Me.lstOro.Name = "lstOro"
        Me.lstOro.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstOro.Size = New System.Drawing.Size(34, 121)
        Me.lstOro.TabIndex = 5
        '
        'lstPlata
        '
        Me.lstPlata.Enabled = False
        Me.lstPlata.FormattingEnabled = True
        Me.lstPlata.Items.AddRange(New Object() {"1", "1", "1", "0", "0", "0", "0", "0", "3"})
        Me.lstPlata.Location = New System.Drawing.Point(178, 25)
        Me.lstPlata.Name = "lstPlata"
        Me.lstPlata.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstPlata.Size = New System.Drawing.Size(36, 121)
        Me.lstPlata.TabIndex = 6
        '
        'lstBronce
        '
        Me.lstBronce.Enabled = False
        Me.lstBronce.FormattingEnabled = True
        Me.lstBronce.Items.AddRange(New Object() {"0", "0", "0", "1", "2", "1", "1", "0", "0"})
        Me.lstBronce.Location = New System.Drawing.Point(224, 25)
        Me.lstBronce.Name = "lstBronce"
        Me.lstBronce.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstBronce.Size = New System.Drawing.Size(42, 121)
        Me.lstBronce.TabIndex = 7
        '
        'lstTotal
        '
        Me.lstTotal.Enabled = False
        Me.lstTotal.FormattingEnabled = True
        Me.lstTotal.Items.AddRange(New Object() {"2", "3", "4", "1", "2", "1", "2", "1", "3"})
        Me.lstTotal.Location = New System.Drawing.Point(272, 25)
        Me.lstTotal.Name = "lstTotal"
        Me.lstTotal.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstTotal.Size = New System.Drawing.Size(38, 121)
        Me.lstTotal.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(269, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Total"
        '
        'btnSeleccionPatron
        '
        Me.btnSeleccionPatron.Location = New System.Drawing.Point(316, 25)
        Me.btnSeleccionPatron.Name = "btnSeleccionPatron"
        Me.btnSeleccionPatron.Size = New System.Drawing.Size(152, 23)
        Me.btnSeleccionPatron.TabIndex = 10
        Me.btnSeleccionPatron.Text = "Selección por patrón -->"
        Me.btnSeleccionPatron.UseVisualStyleBackColor = True
        '
        'txtPatron
        '
        Me.txtPatron.Location = New System.Drawing.Point(316, 54)
        Me.txtPatron.Name = "txtPatron"
        Me.txtPatron.Size = New System.Drawing.Size(152, 20)
        Me.txtPatron.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(316, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(147, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Medallas de la selección"
        '
        'lstTotalSelec
        '
        Me.lstTotalSelec.FormattingEnabled = True
        Me.lstTotalSelec.Location = New System.Drawing.Point(319, 103)
        Me.lstTotalSelec.Name = "lstTotalSelec"
        Me.lstTotalSelec.Size = New System.Drawing.Size(149, 69)
        Me.lstTotalSelec.TabIndex = 13
        '
        'btnMas
        '
        Me.btnMas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMas.Location = New System.Drawing.Point(15, 185)
        Me.btnMas.Name = "btnMas"
        Me.btnMas.Size = New System.Drawing.Size(30, 31)
        Me.btnMas.TabIndex = 14
        Me.btnMas.Text = "+"
        Me.btnMas.UseVisualStyleBackColor = True
        '
        'btnMenos
        '
        Me.btnMenos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenos.Location = New System.Drawing.Point(219, 185)
        Me.btnMenos.Name = "btnMenos"
        Me.btnMenos.Size = New System.Drawing.Size(30, 31)
        Me.btnMenos.TabIndex = 15
        Me.btnMenos.Text = "-"
        Me.btnMenos.UseVisualStyleBackColor = True
        '
        'rbtOro
        '
        Me.rbtOro.AutoSize = True
        Me.rbtOro.Checked = True
        Me.rbtOro.Location = New System.Drawing.Point(51, 194)
        Me.rbtOro.Name = "rbtOro"
        Me.rbtOro.Size = New System.Drawing.Size(42, 17)
        Me.rbtOro.TabIndex = 16
        Me.rbtOro.TabStop = True
        Me.rbtOro.Text = "Oro"
        Me.rbtOro.UseVisualStyleBackColor = True
        '
        'rbtPlata
        '
        Me.rbtPlata.AutoSize = True
        Me.rbtPlata.Location = New System.Drawing.Point(99, 194)
        Me.rbtPlata.Name = "rbtPlata"
        Me.rbtPlata.Size = New System.Drawing.Size(49, 17)
        Me.rbtPlata.TabIndex = 17
        Me.rbtPlata.Text = "Plata"
        Me.rbtPlata.UseVisualStyleBackColor = True
        '
        'rbtBronce
        '
        Me.rbtBronce.AutoSize = True
        Me.rbtBronce.Location = New System.Drawing.Point(154, 194)
        Me.rbtBronce.Name = "rbtBronce"
        Me.rbtBronce.Size = New System.Drawing.Size(59, 17)
        Me.rbtBronce.TabIndex = 18
        Me.rbtBronce.Text = "Bronce"
        Me.rbtBronce.UseVisualStyleBackColor = True
        '
        'lblTotalMedallas
        '
        Me.lblTotalMedallas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalMedallas.Location = New System.Drawing.Point(255, 185)
        Me.lblTotalMedallas.Name = "lblTotalMedallas"
        Me.lblTotalMedallas.Size = New System.Drawing.Size(55, 31)
        Me.lblTotalMedallas.TabIndex = 19
        Me.lblTotalMedallas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClasificacion
        '
        Me.btnClasificacion.Location = New System.Drawing.Point(12, 237)
        Me.btnClasificacion.Name = "btnClasificacion"
        Me.btnClasificacion.Size = New System.Drawing.Size(160, 33)
        Me.btnClasificacion.TabIndex = 20
        Me.btnClasificacion.Text = "Clasificación por Total"
        Me.btnClasificacion.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(316, 237)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(160, 33)
        Me.btnVolver.TabIndex = 21
        Me.btnVolver.Text = "Volver a deportes"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(9, 224)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(484, 10)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Label7"
        '
        'frnMedallero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 282)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnClasificacion)
        Me.Controls.Add(Me.lblTotalMedallas)
        Me.Controls.Add(Me.rbtBronce)
        Me.Controls.Add(Me.rbtPlata)
        Me.Controls.Add(Me.rbtOro)
        Me.Controls.Add(Me.btnMenos)
        Me.Controls.Add(Me.btnMas)
        Me.Controls.Add(Me.lstTotalSelec)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPatron)
        Me.Controls.Add(Me.btnSeleccionPatron)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lstTotal)
        Me.Controls.Add(Me.lstBronce)
        Me.Controls.Add(Me.lstPlata)
        Me.Controls.Add(Me.lstOro)
        Me.Controls.Add(Me.lstPais)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frnMedallero"
        Me.Text = "Juegos Olímpicos - MeDaLLeRo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lstPais As System.Windows.Forms.ListBox
    Friend WithEvents lstOro As System.Windows.Forms.ListBox
    Friend WithEvents lstPlata As System.Windows.Forms.ListBox
    Friend WithEvents lstBronce As System.Windows.Forms.ListBox
    Friend WithEvents lstTotal As System.Windows.Forms.ListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnSeleccionPatron As System.Windows.Forms.Button
    Friend WithEvents txtPatron As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lstTotalSelec As System.Windows.Forms.ListBox
    Friend WithEvents btnMas As System.Windows.Forms.Button
    Friend WithEvents btnMenos As System.Windows.Forms.Button
    Friend WithEvents rbtOro As System.Windows.Forms.RadioButton
    Friend WithEvents rbtPlata As System.Windows.Forms.RadioButton
    Friend WithEvents rbtBronce As System.Windows.Forms.RadioButton
    Friend WithEvents lblTotalMedallas As System.Windows.Forms.Label
    Friend WithEvents btnClasificacion As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
