<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frnClientes
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
        Me.lstClientes = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuClientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAltas = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBajas = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuModificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstClientes
        '
        Me.lstClientes.FormattingEnabled = True
        Me.lstClientes.Items.AddRange(New Object() {"AAA", "BBB", "ZZZ", "QQQQ", "XXDS", "FFDFD", "RRDFD", "POLOI"})
        Me.lstClientes.Location = New System.Drawing.Point(12, 38)
        Me.lstClientes.Name = "lstClientes"
        Me.lstClientes.Size = New System.Drawing.Size(260, 212)
        Me.lstClientes.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClientes})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuClientes
        '
        Me.mnuClientes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAltas, Me.mnuBajas, Me.MnuModificar, Me.ToolStripMenuItem1, Me.mnuSalir})
        Me.mnuClientes.MergeAction = System.Windows.Forms.MergeAction.Insert
        Me.mnuClientes.MergeIndex = 1
        Me.mnuClientes.Name = "mnuClientes"
        Me.mnuClientes.Size = New System.Drawing.Size(61, 20)
        Me.mnuClientes.Text = "Clientes"
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
        'frnClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lstClientes)
        Me.Name = "frnClientes"
        Me.Text = "frnClientes"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstClientes As System.Windows.Forms.ListBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuClientes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAltas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBajas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuModificar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSalir As System.Windows.Forms.ToolStripMenuItem
End Class
