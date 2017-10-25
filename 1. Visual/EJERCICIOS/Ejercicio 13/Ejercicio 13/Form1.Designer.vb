<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frnMulticines
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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPeli1 = New System.Windows.Forms.TextBox()
        Me.txtPeli2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPeli3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPeli4 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lstSala1 = New System.Windows.Forms.ListBox()
        Me.lstSala2 = New System.Windows.Forms.ListBox()
        Me.lstSala3 = New System.Windows.Forms.ListBox()
        Me.lstSala4 = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.gpbSala = New System.Windows.Forms.GroupBox()
        Me.rbtSala4 = New System.Windows.Forms.RadioButton()
        Me.rbtSala3 = New System.Windows.Forms.RadioButton()
        Me.rbtSala2 = New System.Windows.Forms.RadioButton()
        Me.rbtSala1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtDiez = New System.Windows.Forms.RadioButton()
        Me.rbtSiete = New System.Windows.Forms.RadioButton()
        Me.rbtCinco = New System.Windows.Forms.RadioButton()
        Me.lblEntradas = New System.Windows.Forms.Label()
        Me.txtEntradas = New System.Windows.Forms.TextBox()
        Me.btnVenta = New System.Windows.Forms.Button()
        Me.btnDevolucion = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.gpbSala.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblTitulo.Location = New System.Drawing.Point(245, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(196, 48)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Multicines"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(153, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sala 1"
        '
        'txtPeli1
        '
        Me.txtPeli1.Enabled = False
        Me.txtPeli1.Location = New System.Drawing.Point(117, 103)
        Me.txtPeli1.Name = "txtPeli1"
        Me.txtPeli1.Size = New System.Drawing.Size(127, 26)
        Me.txtPeli1.TabIndex = 2
        Me.txtPeli1.Text = "IT"
        Me.txtPeli1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPeli2
        '
        Me.txtPeli2.Enabled = False
        Me.txtPeli2.Location = New System.Drawing.Point(250, 103)
        Me.txtPeli2.Name = "txtPeli2"
        Me.txtPeli2.Size = New System.Drawing.Size(154, 26)
        Me.txtPeli2.TabIndex = 4
        Me.txtPeli2.Text = "El guardián invisible"
        Me.txtPeli2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(303, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Sala 2"
        '
        'txtPeli3
        '
        Me.txtPeli3.Enabled = False
        Me.txtPeli3.Location = New System.Drawing.Point(417, 103)
        Me.txtPeli3.Name = "txtPeli3"
        Me.txtPeli3.Size = New System.Drawing.Size(145, 26)
        Me.txtPeli3.TabIndex = 6
        Me.txtPeli3.Text = "Blade Runner 2049"
        Me.txtPeli3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(453, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Sala 3"
        '
        'txtPeli4
        '
        Me.txtPeli4.Enabled = False
        Me.txtPeli4.Location = New System.Drawing.Point(575, 103)
        Me.txtPeli4.Name = "txtPeli4"
        Me.txtPeli4.Size = New System.Drawing.Size(223, 26)
        Me.txtPeli4.TabIndex = 8
        Me.txtPeli4.Text = "Kingsman: El circulo de oro"
        Me.txtPeli4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(652, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Sala 4"
        '
        'lstSala1
        '
        Me.lstSala1.Enabled = False
        Me.lstSala1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSala1.FormattingEnabled = True
        Me.lstSala1.ItemHeight = 31
        Me.lstSala1.Location = New System.Drawing.Point(143, 157)
        Me.lstSala1.Name = "lstSala1"
        Me.lstSala1.Size = New System.Drawing.Size(76, 97)
        Me.lstSala1.TabIndex = 9
        '
        'lstSala2
        '
        Me.lstSala2.Enabled = False
        Me.lstSala2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSala2.FormattingEnabled = True
        Me.lstSala2.ItemHeight = 31
        Me.lstSala2.Location = New System.Drawing.Point(290, 157)
        Me.lstSala2.Name = "lstSala2"
        Me.lstSala2.Size = New System.Drawing.Size(76, 97)
        Me.lstSala2.TabIndex = 10
        '
        'lstSala3
        '
        Me.lstSala3.Enabled = False
        Me.lstSala3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSala3.FormattingEnabled = True
        Me.lstSala3.ItemHeight = 31
        Me.lstSala3.Location = New System.Drawing.Point(443, 157)
        Me.lstSala3.Name = "lstSala3"
        Me.lstSala3.Size = New System.Drawing.Size(76, 97)
        Me.lstSala3.TabIndex = 11
        '
        'lstSala4
        '
        Me.lstSala4.Enabled = False
        Me.lstSala4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSala4.FormattingEnabled = True
        Me.lstSala4.ItemHeight = 31
        Me.lstSala4.Location = New System.Drawing.Point(639, 157)
        Me.lstSala4.Name = "lstSala4"
        Me.lstSala4.Size = New System.Drawing.Size(76, 97)
        Me.lstSala4.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(88, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "17:30"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(88, 194)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 20)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "19:30"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(88, 228)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 20)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "22:30"
        '
        'gpbSala
        '
        Me.gpbSala.Controls.Add(Me.rbtSala4)
        Me.gpbSala.Controls.Add(Me.rbtSala3)
        Me.gpbSala.Controls.Add(Me.rbtSala2)
        Me.gpbSala.Controls.Add(Me.rbtSala1)
        Me.gpbSala.Location = New System.Drawing.Point(191, 310)
        Me.gpbSala.Name = "gpbSala"
        Me.gpbSala.Size = New System.Drawing.Size(213, 129)
        Me.gpbSala.TabIndex = 16
        Me.gpbSala.TabStop = False
        Me.gpbSala.Text = "Sala"
        '
        'rbtSala4
        '
        Me.rbtSala4.AutoSize = True
        Me.rbtSala4.Location = New System.Drawing.Point(121, 84)
        Me.rbtSala4.Name = "rbtSala4"
        Me.rbtSala4.Size = New System.Drawing.Size(72, 24)
        Me.rbtSala4.TabIndex = 3
        Me.rbtSala4.Text = "Sala 4"
        Me.rbtSala4.UseVisualStyleBackColor = True
        '
        'rbtSala3
        '
        Me.rbtSala3.AutoSize = True
        Me.rbtSala3.Location = New System.Drawing.Point(122, 40)
        Me.rbtSala3.Name = "rbtSala3"
        Me.rbtSala3.Size = New System.Drawing.Size(72, 24)
        Me.rbtSala3.TabIndex = 2
        Me.rbtSala3.Text = "Sala 3"
        Me.rbtSala3.UseVisualStyleBackColor = True
        '
        'rbtSala2
        '
        Me.rbtSala2.AutoSize = True
        Me.rbtSala2.Location = New System.Drawing.Point(6, 84)
        Me.rbtSala2.Name = "rbtSala2"
        Me.rbtSala2.Size = New System.Drawing.Size(72, 24)
        Me.rbtSala2.TabIndex = 1
        Me.rbtSala2.Text = "Sala 2"
        Me.rbtSala2.UseVisualStyleBackColor = True
        '
        'rbtSala1
        '
        Me.rbtSala1.AutoSize = True
        Me.rbtSala1.Checked = True
        Me.rbtSala1.Location = New System.Drawing.Point(7, 40)
        Me.rbtSala1.Name = "rbtSala1"
        Me.rbtSala1.Size = New System.Drawing.Size(72, 24)
        Me.rbtSala1.TabIndex = 0
        Me.rbtSala1.TabStop = True
        Me.rbtSala1.Text = "Sala 1"
        Me.rbtSala1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtDiez)
        Me.GroupBox1.Controls.Add(Me.rbtSiete)
        Me.GroupBox1.Controls.Add(Me.rbtCinco)
        Me.GroupBox1.Location = New System.Drawing.Point(443, 310)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 129)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Horario"
        '
        'rbtDiez
        '
        Me.rbtDiez.AutoSize = True
        Me.rbtDiez.Location = New System.Drawing.Point(63, 86)
        Me.rbtDiez.Name = "rbtDiez"
        Me.rbtDiez.Size = New System.Drawing.Size(67, 24)
        Me.rbtDiez.TabIndex = 2
        Me.rbtDiez.Text = "22:30"
        Me.rbtDiez.UseVisualStyleBackColor = True
        '
        'rbtSiete
        '
        Me.rbtSiete.AutoSize = True
        Me.rbtSiete.Location = New System.Drawing.Point(63, 56)
        Me.rbtSiete.Name = "rbtSiete"
        Me.rbtSiete.Size = New System.Drawing.Size(67, 24)
        Me.rbtSiete.TabIndex = 1
        Me.rbtSiete.Text = "19:30"
        Me.rbtSiete.UseVisualStyleBackColor = True
        '
        'rbtCinco
        '
        Me.rbtCinco.AutoSize = True
        Me.rbtCinco.Checked = True
        Me.rbtCinco.Location = New System.Drawing.Point(63, 26)
        Me.rbtCinco.Name = "rbtCinco"
        Me.rbtCinco.Size = New System.Drawing.Size(67, 24)
        Me.rbtCinco.TabIndex = 0
        Me.rbtCinco.TabStop = True
        Me.rbtCinco.Text = "17:30"
        Me.rbtCinco.UseVisualStyleBackColor = True
        '
        'lblEntradas
        '
        Me.lblEntradas.AutoSize = True
        Me.lblEntradas.Location = New System.Drawing.Point(169, 473)
        Me.lblEntradas.Name = "lblEntradas"
        Me.lblEntradas.Size = New System.Drawing.Size(115, 20)
        Me.lblEntradas.TabIndex = 18
        Me.lblEntradas.Text = "Nº de entradas"
        '
        'txtEntradas
        '
        Me.txtEntradas.Location = New System.Drawing.Point(176, 497)
        Me.txtEntradas.Name = "txtEntradas"
        Me.txtEntradas.Size = New System.Drawing.Size(100, 26)
        Me.txtEntradas.TabIndex = 19
        Me.txtEntradas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnVenta
        '
        Me.btnVenta.Location = New System.Drawing.Point(310, 473)
        Me.btnVenta.Name = "btnVenta"
        Me.btnVenta.Size = New System.Drawing.Size(122, 84)
        Me.btnVenta.TabIndex = 20
        Me.btnVenta.Text = "&Venta"
        Me.btnVenta.UseVisualStyleBackColor = True
        '
        'btnDevolucion
        '
        Me.btnDevolucion.Location = New System.Drawing.Point(438, 473)
        Me.btnDevolucion.Name = "btnDevolucion"
        Me.btnDevolucion.Size = New System.Drawing.Size(122, 84)
        Me.btnDevolucion.TabIndex = 21
        Me.btnDevolucion.Text = "&Devolucion"
        Me.btnDevolucion.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(12, 605)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(786, 45)
        Me.btnSalir.TabIndex = 22
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frnMulticines
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(810, 666)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnDevolucion)
        Me.Controls.Add(Me.btnVenta)
        Me.Controls.Add(Me.txtEntradas)
        Me.Controls.Add(Me.lblEntradas)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gpbSala)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lstSala4)
        Me.Controls.Add(Me.lstSala3)
        Me.Controls.Add(Me.lstSala2)
        Me.Controls.Add(Me.lstSala1)
        Me.Controls.Add(Me.txtPeli4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPeli3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPeli2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPeli1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frnMulticines"
        Me.Text = "Form1"
        Me.gpbSala.ResumeLayout(False)
        Me.gpbSala.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPeli1 As System.Windows.Forms.TextBox
    Friend WithEvents txtPeli2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPeli3 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPeli4 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lstSala1 As System.Windows.Forms.ListBox
    Friend WithEvents lstSala2 As System.Windows.Forms.ListBox
    Friend WithEvents lstSala3 As System.Windows.Forms.ListBox
    Friend WithEvents lstSala4 As System.Windows.Forms.ListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents gpbSala As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtSala4 As System.Windows.Forms.RadioButton
    Friend WithEvents rbtSala3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbtSala2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbtSala1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbtDiez As System.Windows.Forms.RadioButton
    Friend WithEvents rbtSiete As System.Windows.Forms.RadioButton
    Friend WithEvents rbtCinco As System.Windows.Forms.RadioButton
    Friend WithEvents lblEntradas As System.Windows.Forms.Label
    Friend WithEvents txtEntradas As System.Windows.Forms.TextBox
    Friend WithEvents btnVenta As System.Windows.Forms.Button
    Friend WithEvents btnDevolucion As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button

End Class
