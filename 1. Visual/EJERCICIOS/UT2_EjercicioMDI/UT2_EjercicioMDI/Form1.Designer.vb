<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frnMdi
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
        Me.mnuVer = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuVentana = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAcercade = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuArticulos = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPedidos = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHorizontal = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuVertical = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuVer, Me.mnuVentana, Me.mnuAcercade})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(600, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuVer
        '
        Me.mnuVer.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClientes, Me.mnuArticulos, Me.mnuPedidos, Me.ToolStripMenuItem1, Me.mnuSalir})
        Me.mnuVer.Name = "mnuVer"
        Me.mnuVer.Size = New System.Drawing.Size(35, 20)
        Me.mnuVer.Text = "Ver"
        '
        'mnuVentana
        '
        Me.mnuVentana.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHorizontal, Me.mnuVertical})
        Me.mnuVentana.MergeIndex = 2
        Me.mnuVentana.Name = "mnuVentana"
        Me.mnuVentana.Size = New System.Drawing.Size(61, 20)
        Me.mnuVentana.Text = "Ventana"
        '
        'mnuAcercade
        '
        Me.mnuAcercade.MergeIndex = 3
        Me.mnuAcercade.Name = "mnuAcercade"
        Me.mnuAcercade.Size = New System.Drawing.Size(83, 20)
        Me.mnuAcercade.Text = "Acerca de ..."
        '
        'mnuClientes
        '
        Me.mnuClientes.Name = "mnuClientes"
        Me.mnuClientes.Size = New System.Drawing.Size(152, 22)
        Me.mnuClientes.Text = "Clientes"
        '
        'mnuArticulos
        '
        Me.mnuArticulos.Name = "mnuArticulos"
        Me.mnuArticulos.Size = New System.Drawing.Size(152, 22)
        Me.mnuArticulos.Text = "Articulos"
        '
        'mnuPedidos
        '
        Me.mnuPedidos.Name = "mnuPedidos"
        Me.mnuPedidos.Size = New System.Drawing.Size(152, 22)
        Me.mnuPedidos.Text = "Pedidos"
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
        'mnuHorizontal
        '
        Me.mnuHorizontal.Name = "mnuHorizontal"
        Me.mnuHorizontal.Size = New System.Drawing.Size(152, 22)
        Me.mnuHorizontal.Text = "Horizontal"
        '
        'mnuVertical
        '
        Me.mnuVertical.Name = "mnuVertical"
        Me.mnuVertical.Size = New System.Drawing.Size(152, 22)
        Me.mnuVertical.Text = "Vertical"
        '
        'frnMdi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 492)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frnMdi"
        Me.Text = "MDI_ejercicio"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuVer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuClientes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuArticulos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPedidos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuVentana As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHorizontal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuVertical As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAcercade As System.Windows.Forms.ToolStripMenuItem

End Class
