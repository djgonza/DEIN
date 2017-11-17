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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstDeporte = New System.Windows.Forms.ListBox()
        Me.lstGanador = New System.Windows.Forms.ListBox()
        Me.cmbPais = New System.Windows.Forms.ComboBox()
        Me.btnIntroducir = New System.Windows.Forms.Button()
        Me.btnMedallero = New System.Windows.Forms.Button()
        Me.btnTerminar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Deporte"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(160, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PAÍS GANADOR"
        '
        'lstDeporte
        '
        Me.lstDeporte.FormattingEnabled = True
        Me.lstDeporte.Items.AddRange(New Object() {"BÁDMINTON", "BALONCESTO", "BOXEO", "TIRO CON ARCO", "TENIS", "VELA"})
        Me.lstDeporte.Location = New System.Drawing.Point(12, 29)
        Me.lstDeporte.Name = "lstDeporte"
        Me.lstDeporte.Size = New System.Drawing.Size(120, 82)
        Me.lstDeporte.TabIndex = 2
        '
        'lstGanador
        '
        Me.lstGanador.FormattingEnabled = True
        Me.lstGanador.Items.AddRange(New Object() {"*****", "*****", "*****", "*****", "*****", "*****"})
        Me.lstGanador.Location = New System.Drawing.Point(163, 29)
        Me.lstGanador.Name = "lstGanador"
        Me.lstGanador.Size = New System.Drawing.Size(120, 82)
        Me.lstGanador.TabIndex = 3
        '
        'cmbPais
        '
        Me.cmbPais.FormattingEnabled = True
        Me.cmbPais.Items.AddRange(New Object() {"ARGENTINA", "CANADA", "DINAMARCA", "FRANCIA", "ITALIA", "GRECIA", "BRASIL", "KENIA", "AUSTRALIA"})
        Me.cmbPais.Location = New System.Drawing.Point(289, 29)
        Me.cmbPais.Name = "cmbPais"
        Me.cmbPais.Size = New System.Drawing.Size(143, 21)
        Me.cmbPais.TabIndex = 4
        Me.cmbPais.Text = "--- SELECCIONE PAÍS ---"
        '
        'btnIntroducir
        '
        Me.btnIntroducir.Location = New System.Drawing.Point(12, 117)
        Me.btnIntroducir.Name = "btnIntroducir"
        Me.btnIntroducir.Size = New System.Drawing.Size(271, 59)
        Me.btnIntroducir.TabIndex = 5
        Me.btnIntroducir.Text = "&Introducir país"
        Me.btnIntroducir.UseVisualStyleBackColor = True
        '
        'btnMedallero
        '
        Me.btnMedallero.Location = New System.Drawing.Point(12, 199)
        Me.btnMedallero.Name = "btnMedallero"
        Me.btnMedallero.Size = New System.Drawing.Size(215, 51)
        Me.btnMedallero.TabIndex = 6
        Me.btnMedallero.Text = "Medallero"
        Me.btnMedallero.UseVisualStyleBackColor = True
        '
        'btnTerminar
        '
        Me.btnTerminar.Location = New System.Drawing.Point(233, 199)
        Me.btnTerminar.Name = "btnTerminar"
        Me.btnTerminar.Size = New System.Drawing.Size(205, 51)
        Me.btnTerminar.TabIndex = 7
        Me.btnTerminar.Text = "Terminar"
        Me.btnTerminar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(12, 179)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(403, 10)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Label7"
        '
        'frnPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 262)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnTerminar)
        Me.Controls.Add(Me.btnMedallero)
        Me.Controls.Add(Me.btnIntroducir)
        Me.Controls.Add(Me.cmbPais)
        Me.Controls.Add(Me.lstGanador)
        Me.Controls.Add(Me.lstDeporte)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frnPrincipal"
        Me.Text = "Juegos Olímpicos - DePoRTeS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lstDeporte As System.Windows.Forms.ListBox
    Friend WithEvents lstGanador As System.Windows.Forms.ListBox
    Friend WithEvents cmbPais As System.Windows.Forms.ComboBox
    Friend WithEvents btnIntroducir As System.Windows.Forms.Button
    Friend WithEvents btnMedallero As System.Windows.Forms.Button
    Friend WithEvents btnTerminar As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label

End Class
