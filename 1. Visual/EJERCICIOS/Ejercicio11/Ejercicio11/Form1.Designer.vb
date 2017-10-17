<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frnAtletas
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
        Me.pln1 = New System.Windows.Forms.Panel()
        Me.btnNuevoAtleta = New System.Windows.Forms.Button()
        Me.txtAtletaNuevo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbAtletas = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pln2 = New System.Windows.Forms.Panel()
        Me.lblMejorSsalto = New System.Windows.Forms.Label()
        Me.lblMesjorSaltador = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSalto = New System.Windows.Forms.Button()
        Me.gpbValidez = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.rbtNulo = New System.Windows.Forms.RadioButton()
        Me.lstSalto3 = New System.Windows.Forms.ListBox()
        Me.lstSalto2 = New System.Windows.Forms.ListBox()
        Me.lstSalto1 = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pln1.SuspendLayout()
        Me.pln2.SuspendLayout()
        Me.gpbValidez.SuspendLayout()
        Me.SuspendLayout()
        '
        'pln1
        '
        Me.pln1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pln1.Controls.Add(Me.btnNuevoAtleta)
        Me.pln1.Controls.Add(Me.txtAtletaNuevo)
        Me.pln1.Controls.Add(Me.Label2)
        Me.pln1.Controls.Add(Me.cbAtletas)
        Me.pln1.Controls.Add(Me.Label1)
        Me.pln1.Location = New System.Drawing.Point(6, 5)
        Me.pln1.Name = "pln1"
        Me.pln1.Size = New System.Drawing.Size(641, 100)
        Me.pln1.TabIndex = 0
        '
        'btnNuevoAtleta
        '
        Me.btnNuevoAtleta.Location = New System.Drawing.Point(419, 56)
        Me.btnNuevoAtleta.Name = "btnNuevoAtleta"
        Me.btnNuevoAtleta.Size = New System.Drawing.Size(176, 23)
        Me.btnNuevoAtleta.TabIndex = 4
        Me.btnNuevoAtleta.Text = "&Nuevo Atleta"
        Me.btnNuevoAtleta.UseVisualStyleBackColor = True
        '
        'txtAtletaNuevo
        '
        Me.txtAtletaNuevo.Location = New System.Drawing.Point(419, 29)
        Me.txtAtletaNuevo.Name = "txtAtletaNuevo"
        Me.txtAtletaNuevo.Size = New System.Drawing.Size(176, 20)
        Me.txtAtletaNuevo.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(416, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Introduzca nuevo atleta"
        '
        'cbAtletas
        '
        Me.cbAtletas.FormattingEnabled = True
        Me.cbAtletas.Location = New System.Drawing.Point(7, 29)
        Me.cbAtletas.Name = "cbAtletas"
        Me.cbAtletas.Size = New System.Drawing.Size(219, 21)
        Me.cbAtletas.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Atleta"
        '
        'pln2
        '
        Me.pln2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pln2.Controls.Add(Me.lblMejorSsalto)
        Me.pln2.Controls.Add(Me.lblMesjorSaltador)
        Me.pln2.Controls.Add(Me.Label8)
        Me.pln2.Controls.Add(Me.btnSalir)
        Me.pln2.Controls.Add(Me.Label7)
        Me.pln2.Controls.Add(Me.Label6)
        Me.pln2.Controls.Add(Me.btnSalto)
        Me.pln2.Controls.Add(Me.gpbValidez)
        Me.pln2.Controls.Add(Me.lstSalto3)
        Me.pln2.Controls.Add(Me.lstSalto2)
        Me.pln2.Controls.Add(Me.lstSalto1)
        Me.pln2.Controls.Add(Me.Label5)
        Me.pln2.Controls.Add(Me.Label4)
        Me.pln2.Controls.Add(Me.Label3)
        Me.pln2.Location = New System.Drawing.Point(6, 112)
        Me.pln2.Name = "pln2"
        Me.pln2.Size = New System.Drawing.Size(641, 419)
        Me.pln2.TabIndex = 1
        '
        'lblMejorSsalto
        '
        Me.lblMejorSsalto.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblMejorSsalto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMejorSsalto.ForeColor = System.Drawing.Color.Black
        Me.lblMejorSsalto.Location = New System.Drawing.Point(462, 349)
        Me.lblMejorSsalto.Name = "lblMejorSsalto"
        Me.lblMejorSsalto.Size = New System.Drawing.Size(68, 20)
        Me.lblMejorSsalto.TabIndex = 14
        '
        'lblMesjorSaltador
        '
        Me.lblMesjorSaltador.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblMesjorSaltador.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMesjorSaltador.ForeColor = System.Drawing.Color.Crimson
        Me.lblMesjorSaltador.Location = New System.Drawing.Point(121, 349)
        Me.lblMesjorSaltador.Name = "lblMesjorSaltador"
        Me.lblMesjorSaltador.Size = New System.Drawing.Size(312, 20)
        Me.lblMesjorSaltador.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(10, 349)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 20)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Mejor Salto:"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(3, 391)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(629, 23)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(323, 219)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 59)
        Me.Label7.TabIndex = 9
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(307, 193)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Total saltos nulos:"
        '
        'btnSalto
        '
        Me.btnSalto.Location = New System.Drawing.Point(307, 124)
        Me.btnSalto.Name = "btnSalto"
        Me.btnSalto.Size = New System.Drawing.Size(278, 48)
        Me.btnSalto.TabIndex = 7
        Me.btnSalto.Text = "&Entrar Salto"
        Me.btnSalto.UseVisualStyleBackColor = True
        '
        'gpbValidez
        '
        Me.gpbValidez.Controls.Add(Me.RadioButton1)
        Me.gpbValidez.Controls.Add(Me.rbtNulo)
        Me.gpbValidez.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbValidez.Location = New System.Drawing.Point(307, 30)
        Me.gpbValidez.Name = "gpbValidez"
        Me.gpbValidez.Size = New System.Drawing.Size(278, 87)
        Me.gpbValidez.TabIndex = 6
        Me.gpbValidez.TabStop = False
        Me.gpbValidez.Text = "Validez del salto"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(159, 39)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(65, 21)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.Text = "Valido"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'rbtNulo
        '
        Me.rbtNulo.AutoSize = True
        Me.rbtNulo.Checked = True
        Me.rbtNulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtNulo.Location = New System.Drawing.Point(16, 39)
        Me.rbtNulo.Name = "rbtNulo"
        Me.rbtNulo.Size = New System.Drawing.Size(55, 21)
        Me.rbtNulo.TabIndex = 0
        Me.rbtNulo.TabStop = True
        Me.rbtNulo.Text = "Nulo"
        Me.rbtNulo.UseVisualStyleBackColor = True
        '
        'lstSalto3
        '
        Me.lstSalto3.Enabled = False
        Me.lstSalto3.FormattingEnabled = True
        Me.lstSalto3.Location = New System.Drawing.Point(170, 30)
        Me.lstSalto3.Name = "lstSalto3"
        Me.lstSalto3.Size = New System.Drawing.Size(67, 212)
        Me.lstSalto3.TabIndex = 5
        '
        'lstSalto2
        '
        Me.lstSalto2.Enabled = False
        Me.lstSalto2.FormattingEnabled = True
        Me.lstSalto2.Location = New System.Drawing.Point(89, 30)
        Me.lstSalto2.Name = "lstSalto2"
        Me.lstSalto2.Size = New System.Drawing.Size(67, 212)
        Me.lstSalto2.TabIndex = 4
        '
        'lstSalto1
        '
        Me.lstSalto1.Enabled = False
        Me.lstSalto1.FormattingEnabled = True
        Me.lstSalto1.Location = New System.Drawing.Point(10, 30)
        Me.lstSalto1.Name = "lstSalto1"
        Me.lstSalto1.Size = New System.Drawing.Size(67, 212)
        Me.lstSalto1.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(167, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Salto 3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(86, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Salto 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Salto 1"
        '
        'frnAtletas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 543)
        Me.Controls.Add(Me.pln2)
        Me.Controls.Add(Me.pln1)
        Me.Name = "frnAtletas"
        Me.Text = "CAMPEONATO DE TRIPLE SALTO DE ESTOCOLMO"
        Me.pln1.ResumeLayout(False)
        Me.pln1.PerformLayout()
        Me.pln2.ResumeLayout(False)
        Me.pln2.PerformLayout()
        Me.gpbValidez.ResumeLayout(False)
        Me.gpbValidez.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pln1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAtletaNuevo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbAtletas As System.Windows.Forms.ComboBox
    Friend WithEvents btnNuevoAtleta As System.Windows.Forms.Button
    Friend WithEvents pln2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents gpbValidez As System.Windows.Forms.GroupBox
    Friend WithEvents rbtNulo As System.Windows.Forms.RadioButton
    Friend WithEvents lstSalto3 As System.Windows.Forms.ListBox
    Friend WithEvents lstSalto2 As System.Windows.Forms.ListBox
    Friend WithEvents lstSalto1 As System.Windows.Forms.ListBox
    Friend WithEvents btnSalto As System.Windows.Forms.Button
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblMesjorSaltador As System.Windows.Forms.Label
    Friend WithEvents lblMejorSsalto As System.Windows.Forms.Label

End Class
