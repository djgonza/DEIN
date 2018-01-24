<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frnArticulos
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
        Me.lstArticulo = New System.Windows.Forms.ListBox()
        Me.lstPrecio = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuArticulos = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAltas = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBajas = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuModificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstArticulo
        '
        Me.lstArticulo.FormattingEnabled = True
        Me.lstArticulo.Items.AddRange(New Object() {"Lápiz negro", "Lápiz corrector", "Regla 20 cm.", "Sacapuntas", "Transportador", "Aros de carpeta"})
        Me.lstArticulo.Location = New System.Drawing.Point(12, 27)
        Me.lstArticulo.Name = "lstArticulo"
        Me.lstArticulo.Size = New System.Drawing.Size(146, 277)
        Me.lstArticulo.TabIndex = 0
        '
        'lstPrecio
        '
        Me.lstPrecio.FormattingEnabled = True
        Me.lstPrecio.Items.AddRange(New Object() {"2,00", "2,50", "3,00", "1,75", "4,20", "0,20"})
        Me.lstPrecio.Location = New System.Drawing.Point(201, 27)
        Me.lstPrecio.Name = "lstPrecio"
        Me.lstPrecio.Size = New System.Drawing.Size(146, 277)
        Me.lstPrecio.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuArticulos})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(359, 24)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuArticulos
        '
        Me.mnuArticulos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAltas, Me.mnuBajas, Me.MnuModificar, Me.ToolStripMenuItem1, Me.mnuSalir})
        Me.mnuArticulos.MergeAction = System.Windows.Forms.MergeAction.Insert
        Me.mnuArticulos.MergeIndex = 1
        Me.mnuArticulos.Name = "mnuArticulos"
        Me.mnuArticulos.Size = New System.Drawing.Size(66, 20)
        Me.mnuArticulos.Text = "Articulos"
        '
        'mnuAltas
        '
        Me.mnuAltas.Name = "mnuAltas"
        Me.mnuAltas.Size = New System.Drawing.Size(152, 22)
        Me.mnuAltas.Text = "Altas"
        '
        'mnuBajas
        '
        Me.mnuBajas.Name = "mnuBajas"
        Me.mnuBajas.Size = New System.Drawing.Size(152, 22)
        Me.mnuBajas.Text = "Bajas"
        '
        'MnuModificar
        '
        Me.MnuModificar.Name = "MnuModificar"
        Me.MnuModificar.Size = New System.Drawing.Size(152, 22)
        Me.MnuModificar.Text = "Modificar"
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
        Me.mnuSalir.Text = "Salir"
        '
        'frnArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 348)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lstPrecio)
        Me.Controls.Add(Me.lstArticulo)
        Me.Name = "frnArticulos"
        Me.Text = "MDIArticulos"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstArticulo As System.Windows.Forms.ListBox
    Friend WithEvents lstPrecio As System.Windows.Forms.ListBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuArticulos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAltas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBajas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuModificar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSalir As System.Windows.Forms.ToolStripMenuItem
End Class
