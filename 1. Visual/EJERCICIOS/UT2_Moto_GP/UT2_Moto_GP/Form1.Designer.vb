<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frnPilotos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frnPilotos))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AñadirResultadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerEquiposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstCarrera1 = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lstCarrera2 = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lstCarrera3 = New System.Windows.Forms.ListBox()
        Me.pbPiloto = New System.Windows.Forms.PictureBox()
        Me.lblPos1 = New System.Windows.Forms.Label()
        Me.lblPos2 = New System.Windows.Forms.Label()
        Me.lblPos3 = New System.Windows.Forms.Label()
        Me.lblTotalPuntos = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPiloto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(384, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AñadirResultadoToolStripMenuItem, Me.VerEquiposToolStripMenuItem, Me.ToolStripMenuItem1, Me.SalirToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OpcionesToolStripMenuItem.Text = "&Opciones"
        '
        'AñadirResultadoToolStripMenuItem
        '
        Me.AñadirResultadoToolStripMenuItem.Name = "AñadirResultadoToolStripMenuItem"
        Me.AñadirResultadoToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.AñadirResultadoToolStripMenuItem.Text = "Añadir Resultados"
        '
        'VerEquiposToolStripMenuItem
        '
        Me.VerEquiposToolStripMenuItem.Name = "VerEquiposToolStripMenuItem"
        Me.VerEquiposToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.VerEquiposToolStripMenuItem.Text = "Ver Equipos"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(166, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(360, 82)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 194)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 178)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Pilotos"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(174, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 53)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "PUESTO"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(171, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "1º  carrera"
        '
        'lstCarrera1
        '
        Me.lstCarrera1.Enabled = False
        Me.lstCarrera1.FormattingEnabled = True
        Me.lstCarrera1.Location = New System.Drawing.Point(192, 194)
        Me.lstCarrera1.Name = "lstCarrera1"
        Me.lstCarrera1.Size = New System.Drawing.Size(22, 95)
        Me.lstCarrera1.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(242, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "2º  carrera"
        '
        'lstCarrera2
        '
        Me.lstCarrera2.Enabled = False
        Me.lstCarrera2.FormattingEnabled = True
        Me.lstCarrera2.Location = New System.Drawing.Point(262, 194)
        Me.lstCarrera2.Name = "lstCarrera2"
        Me.lstCarrera2.Size = New System.Drawing.Size(22, 95)
        Me.lstCarrera2.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(310, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "3º  carrera"
        '
        'lstCarrera3
        '
        Me.lstCarrera3.Enabled = False
        Me.lstCarrera3.FormattingEnabled = True
        Me.lstCarrera3.Location = New System.Drawing.Point(330, 194)
        Me.lstCarrera3.Name = "lstCarrera3"
        Me.lstCarrera3.Size = New System.Drawing.Size(22, 95)
        Me.lstCarrera3.TabIndex = 9
        '
        'pbPiloto
        '
        Me.pbPiloto.Location = New System.Drawing.Point(12, 311)
        Me.pbPiloto.Name = "pbPiloto"
        Me.pbPiloto.Size = New System.Drawing.Size(146, 84)
        Me.pbPiloto.TabIndex = 11
        Me.pbPiloto.TabStop = False
        '
        'lblPos1
        '
        Me.lblPos1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPos1.Location = New System.Drawing.Point(192, 311)
        Me.lblPos1.Name = "lblPos1"
        Me.lblPos1.Size = New System.Drawing.Size(44, 36)
        Me.lblPos1.TabIndex = 12
        '
        'lblPos2
        '
        Me.lblPos2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPos2.Location = New System.Drawing.Point(262, 311)
        Me.lblPos2.Name = "lblPos2"
        Me.lblPos2.Size = New System.Drawing.Size(44, 36)
        Me.lblPos2.TabIndex = 13
        '
        'lblPos3
        '
        Me.lblPos3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPos3.Location = New System.Drawing.Point(328, 311)
        Me.lblPos3.Name = "lblPos3"
        Me.lblPos3.Size = New System.Drawing.Size(44, 36)
        Me.lblPos3.TabIndex = 14
        '
        'lblTotalPuntos
        '
        Me.lblTotalPuntos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalPuntos.Location = New System.Drawing.Point(192, 359)
        Me.lblTotalPuntos.Name = "lblTotalPuntos"
        Me.lblTotalPuntos.Size = New System.Drawing.Size(180, 36)
        Me.lblTotalPuntos.TabIndex = 15
        '
        'frnPilotos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 416)
        Me.Controls.Add(Me.lblTotalPuntos)
        Me.Controls.Add(Me.lblPos3)
        Me.Controls.Add(Me.lblPos2)
        Me.Controls.Add(Me.lblPos1)
        Me.Controls.Add(Me.pbPiloto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lstCarrera3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lstCarrera2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstCarrera1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frnPilotos"
        Me.Text = "frnPilotos"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPiloto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AñadirResultadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerEquiposToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lstCarrera1 As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lstCarrera2 As System.Windows.Forms.ListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lstCarrera3 As System.Windows.Forms.ListBox
    Friend WithEvents pbPiloto As System.Windows.Forms.PictureBox
    Friend WithEvents lblPos1 As System.Windows.Forms.Label
    Friend WithEvents lblPos2 As System.Windows.Forms.Label
    Friend WithEvents lblPos3 As System.Windows.Forms.Label
    Friend WithEvents lblTotalPuntos As System.Windows.Forms.Label

End Class
