<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frnEjercicio14
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuLista = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAñadir = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFinal = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPosicion = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBorrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuImagenes = New System.Windows.Forms.ToolStripMenuItem()
        Me.IcoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JpgToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstLista = New System.Windows.Forms.ListBox()
        Me.picImagen = New System.Windows.Forms.PictureBox()
        Me.gpbAltasFinal = New System.Windows.Forms.GroupBox()
        Me.gpbAltasPosi = New System.Windows.Forms.GroupBox()
        Me.cmbPosiciones = New System.Windows.Forms.ComboBox()
        Me.Posición = New System.Windows.Forms.Label()
        Me.btnSalirPosi = New System.Windows.Forms.Button()
        Me.btnAñaPosi = New System.Windows.Forms.Button()
        Me.txtAñaPosi = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSalir1 = New System.Windows.Forms.Button()
        Me.btnAñadirFin = New System.Windows.Forms.Button()
        Me.txtAltaFin = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gpbBajas = New System.Windows.Forms.GroupBox()
        Me.cmbBajas = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSalirBajas = New System.Windows.Forms.Button()
        Me.btnBajas = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbAltasFinal.SuspendLayout()
        Me.gpbAltasPosi.SuspendLayout()
        Me.gpbBajas.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuLista, Me.mnuImagenes, Me.AcercadeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(491, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuLista
        '
        Me.mnuLista.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAñadir, Me.mnuBorrar, Me.ToolStripMenuItem1, Me.mnuSalir})
        Me.mnuLista.Name = "mnuLista"
        Me.mnuLista.Size = New System.Drawing.Size(43, 20)
        Me.mnuLista.Text = "&Lista"
        '
        'mnuAñadir
        '
        Me.mnuAñadir.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFinal, Me.mnuPosicion})
        Me.mnuAñadir.Name = "mnuAñadir"
        Me.mnuAñadir.Size = New System.Drawing.Size(152, 22)
        Me.mnuAñadir.Text = "&Añadir"
        '
        'mnuFinal
        '
        Me.mnuFinal.Name = "mnuFinal"
        Me.mnuFinal.Size = New System.Drawing.Size(152, 22)
        Me.mnuFinal.Text = "Al &Final"
        '
        'mnuPosicion
        '
        Me.mnuPosicion.Name = "mnuPosicion"
        Me.mnuPosicion.Size = New System.Drawing.Size(152, 22)
        Me.mnuPosicion.Text = "En &Posición"
        '
        'mnuBorrar
        '
        Me.mnuBorrar.Name = "mnuBorrar"
        Me.mnuBorrar.Size = New System.Drawing.Size(152, 22)
        Me.mnuBorrar.Text = "&Borrar"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(149, 6)
        '
        'mnuSalir
        '
        Me.mnuSalir.Name = "mnuSalir"
        Me.mnuSalir.Size = New System.Drawing.Size(152, 22)
        Me.mnuSalir.Text = "&Salir"
        '
        'mnuImagenes
        '
        Me.mnuImagenes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IcoToolStripMenuItem, Me.JpgToolStripMenuItem})
        Me.mnuImagenes.Name = "mnuImagenes"
        Me.mnuImagenes.Size = New System.Drawing.Size(70, 20)
        Me.mnuImagenes.Text = "&Imagenes"
        '
        'IcoToolStripMenuItem
        '
        Me.IcoToolStripMenuItem.Name = "IcoToolStripMenuItem"
        Me.IcoToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.IcoToolStripMenuItem.Text = "*.ico"
        '
        'JpgToolStripMenuItem
        '
        Me.JpgToolStripMenuItem.Name = "JpgToolStripMenuItem"
        Me.JpgToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.JpgToolStripMenuItem.Text = "*.jpg"
        '
        'AcercadeToolStripMenuItem
        '
        Me.AcercadeToolStripMenuItem.Name = "AcercadeToolStripMenuItem"
        Me.AcercadeToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.AcercadeToolStripMenuItem.Text = "Acerca &de"
        '
        'lstLista
        '
        Me.lstLista.FormattingEnabled = True
        Me.lstLista.Items.AddRange(New Object() {"HIPOTALAMO", "PSICODREAMER", "IMAGEN", "BELFOS"})
        Me.lstLista.Location = New System.Drawing.Point(12, 27)
        Me.lstLista.Name = "lstLista"
        Me.lstLista.Size = New System.Drawing.Size(165, 290)
        Me.lstLista.TabIndex = 1
        '
        'picImagen
        '
        Me.picImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picImagen.Location = New System.Drawing.Point(236, 27)
        Me.picImagen.Name = "picImagen"
        Me.picImagen.Size = New System.Drawing.Size(223, 290)
        Me.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picImagen.TabIndex = 2
        Me.picImagen.TabStop = False
        '
        'gpbAltasFinal
        '
        Me.gpbAltasFinal.Controls.Add(Me.btnSalir1)
        Me.gpbAltasFinal.Controls.Add(Me.btnAñadirFin)
        Me.gpbAltasFinal.Controls.Add(Me.txtAltaFin)
        Me.gpbAltasFinal.Controls.Add(Me.Label1)
        Me.gpbAltasFinal.Location = New System.Drawing.Point(238, 27)
        Me.gpbAltasFinal.Name = "gpbAltasFinal"
        Me.gpbAltasFinal.Size = New System.Drawing.Size(238, 291)
        Me.gpbAltasFinal.TabIndex = 3
        Me.gpbAltasFinal.TabStop = False
        Me.gpbAltasFinal.Visible = False
        '
        'gpbAltasPosi
        '
        Me.gpbAltasPosi.Controls.Add(Me.cmbPosiciones)
        Me.gpbAltasPosi.Controls.Add(Me.Posición)
        Me.gpbAltasPosi.Controls.Add(Me.btnSalirPosi)
        Me.gpbAltasPosi.Controls.Add(Me.btnAñaPosi)
        Me.gpbAltasPosi.Controls.Add(Me.txtAñaPosi)
        Me.gpbAltasPosi.Controls.Add(Me.Label2)
        Me.gpbAltasPosi.Location = New System.Drawing.Point(233, 31)
        Me.gpbAltasPosi.Name = "gpbAltasPosi"
        Me.gpbAltasPosi.Size = New System.Drawing.Size(232, 291)
        Me.gpbAltasPosi.TabIndex = 4
        Me.gpbAltasPosi.TabStop = False
        Me.gpbAltasPosi.Visible = False
        '
        'cmbPosiciones
        '
        Me.cmbPosiciones.FormattingEnabled = True
        Me.cmbPosiciones.Location = New System.Drawing.Point(70, 148)
        Me.cmbPosiciones.Name = "cmbPosiciones"
        Me.cmbPosiciones.Size = New System.Drawing.Size(121, 21)
        Me.cmbPosiciones.TabIndex = 5
        '
        'Posición
        '
        Me.Posición.AutoSize = True
        Me.Posición.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Posición.Location = New System.Drawing.Point(90, 128)
        Me.Posición.Name = "Posición"
        Me.Posición.Size = New System.Drawing.Size(69, 17)
        Me.Posición.TabIndex = 4
        Me.Posición.Text = "Posición"
        '
        'btnSalirPosi
        '
        Me.btnSalirPosi.Location = New System.Drawing.Point(46, 249)
        Me.btnSalirPosi.Name = "btnSalirPosi"
        Me.btnSalirPosi.Size = New System.Drawing.Size(145, 36)
        Me.btnSalirPosi.TabIndex = 3
        Me.btnSalirPosi.Text = "&Salir de Altas"
        Me.btnSalirPosi.UseVisualStyleBackColor = True
        '
        'btnAñaPosi
        '
        Me.btnAñaPosi.Location = New System.Drawing.Point(46, 65)
        Me.btnAñaPosi.Name = "btnAñaPosi"
        Me.btnAñaPosi.Size = New System.Drawing.Size(145, 47)
        Me.btnAñaPosi.TabIndex = 2
        Me.btnAñaPosi.Text = "&Altas en posición"
        Me.btnAñaPosi.UseVisualStyleBackColor = True
        '
        'txtAñaPosi
        '
        Me.txtAñaPosi.Location = New System.Drawing.Point(10, 39)
        Me.txtAñaPosi.Name = "txtAñaPosi"
        Me.txtAñaPosi.Size = New System.Drawing.Size(216, 20)
        Me.txtAñaPosi.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(89, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Altas"
        '
        'btnSalir1
        '
        Me.btnSalir1.Location = New System.Drawing.Point(46, 249)
        Me.btnSalir1.Name = "btnSalir1"
        Me.btnSalir1.Size = New System.Drawing.Size(145, 36)
        Me.btnSalir1.TabIndex = 3
        Me.btnSalir1.Text = "&Salir de Altas"
        Me.btnSalir1.UseVisualStyleBackColor = True
        '
        'btnAñadirFin
        '
        Me.btnAñadirFin.Location = New System.Drawing.Point(46, 65)
        Me.btnAñadirFin.Name = "btnAñadirFin"
        Me.btnAñadirFin.Size = New System.Drawing.Size(145, 47)
        Me.btnAñadirFin.TabIndex = 2
        Me.btnAñadirFin.Text = "&Altas al final"
        Me.btnAñadirFin.UseVisualStyleBackColor = True
        '
        'txtAltaFin
        '
        Me.txtAltaFin.Location = New System.Drawing.Point(10, 39)
        Me.txtAltaFin.Name = "txtAltaFin"
        Me.txtAltaFin.Size = New System.Drawing.Size(216, 20)
        Me.txtAltaFin.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(89, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Altas"
        '
        'gpbBajas
        '
        Me.gpbBajas.Controls.Add(Me.cmbBajas)
        Me.gpbBajas.Controls.Add(Me.Label3)
        Me.gpbBajas.Controls.Add(Me.btnSalirBajas)
        Me.gpbBajas.Controls.Add(Me.btnBajas)
        Me.gpbBajas.Controls.Add(Me.Label4)
        Me.gpbBajas.Location = New System.Drawing.Point(240, 31)
        Me.gpbBajas.Name = "gpbBajas"
        Me.gpbBajas.Size = New System.Drawing.Size(232, 291)
        Me.gpbBajas.TabIndex = 5
        Me.gpbBajas.TabStop = False
        Me.gpbBajas.Visible = False
        '
        'cmbBajas
        '
        Me.cmbBajas.FormattingEnabled = True
        Me.cmbBajas.Location = New System.Drawing.Point(70, 148)
        Me.cmbBajas.Name = "cmbBajas"
        Me.cmbBajas.Size = New System.Drawing.Size(121, 21)
        Me.cmbBajas.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(90, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Posición"
        '
        'btnSalirBajas
        '
        Me.btnSalirBajas.Location = New System.Drawing.Point(46, 249)
        Me.btnSalirBajas.Name = "btnSalirBajas"
        Me.btnSalirBajas.Size = New System.Drawing.Size(145, 36)
        Me.btnSalirBajas.TabIndex = 3
        Me.btnSalirBajas.Text = "&Salir de Bajas"
        Me.btnSalirBajas.UseVisualStyleBackColor = True
        '
        'btnBajas
        '
        Me.btnBajas.Location = New System.Drawing.Point(46, 65)
        Me.btnBajas.Name = "btnBajas"
        Me.btnBajas.Size = New System.Drawing.Size(145, 47)
        Me.btnBajas.TabIndex = 2
        Me.btnBajas.Text = "&Bajas en posición"
        Me.btnBajas.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(89, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Bajas"
        '
        'frnEjercicio14
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 357)
        Me.Controls.Add(Me.gpbBajas)
        Me.Controls.Add(Me.gpbAltasPosi)
        Me.Controls.Add(Me.gpbAltasFinal)
        Me.Controls.Add(Me.picImagen)
        Me.Controls.Add(Me.lstLista)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frnEjercicio14"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbAltasFinal.ResumeLayout(False)
        Me.gpbAltasFinal.PerformLayout()
        Me.gpbAltasPosi.ResumeLayout(False)
        Me.gpbAltasPosi.PerformLayout()
        Me.gpbBajas.ResumeLayout(False)
        Me.gpbBajas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuLista As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAñadir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFinal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPosicion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBorrar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuImagenes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IcoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JpgToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercadeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lstLista As System.Windows.Forms.ListBox
    Friend WithEvents picImagen As System.Windows.Forms.PictureBox
    Friend WithEvents gpbAltasFinal As System.Windows.Forms.GroupBox
    Friend WithEvents btnSalir1 As System.Windows.Forms.Button
    Friend WithEvents btnAñadirFin As System.Windows.Forms.Button
    Friend WithEvents txtAltaFin As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gpbAltasPosi As System.Windows.Forms.GroupBox
    Friend WithEvents cmbPosiciones As System.Windows.Forms.ComboBox
    Friend WithEvents Posición As System.Windows.Forms.Label
    Friend WithEvents btnSalirPosi As System.Windows.Forms.Button
    Friend WithEvents btnAñaPosi As System.Windows.Forms.Button
    Friend WithEvents txtAñaPosi As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gpbBajas As System.Windows.Forms.GroupBox
    Friend WithEvents cmbBajas As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSalirBajas As System.Windows.Forms.Button
    Friend WithEvents btnBajas As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
