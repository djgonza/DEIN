<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frnPedidos
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
        Me.btnCliente = New System.Windows.Forms.Button()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.txtArticulo = New System.Windows.Forms.TextBox()
        Me.btnArticulo = New System.Windows.Forms.Button()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nudUnidades = New System.Windows.Forms.NumericUpDown()
        Me.btnAñadir = New System.Windows.Forms.Button()
        Me.lstCarro = New System.Windows.Forms.ListBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.nudUnidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCliente
        '
        Me.btnCliente.Location = New System.Drawing.Point(12, 37)
        Me.btnCliente.Name = "btnCliente"
        Me.btnCliente.Size = New System.Drawing.Size(113, 23)
        Me.btnCliente.TabIndex = 0
        Me.btnCliente.Text = "Obtener Cliente"
        Me.btnCliente.UseVisualStyleBackColor = True
        '
        'txtCliente
        '
        Me.txtCliente.Enabled = False
        Me.txtCliente.Location = New System.Drawing.Point(131, 36)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(171, 20)
        Me.txtCliente.TabIndex = 1
        '
        'txtArticulo
        '
        Me.txtArticulo.Enabled = False
        Me.txtArticulo.Location = New System.Drawing.Point(85, 72)
        Me.txtArticulo.Name = "txtArticulo"
        Me.txtArticulo.Size = New System.Drawing.Size(127, 20)
        Me.txtArticulo.TabIndex = 3
        '
        'btnArticulo
        '
        Me.btnArticulo.Enabled = False
        Me.btnArticulo.Location = New System.Drawing.Point(12, 72)
        Me.btnArticulo.Name = "btnArticulo"
        Me.btnArticulo.Size = New System.Drawing.Size(67, 23)
        Me.btnArticulo.TabIndex = 2
        Me.btnArticulo.Text = "Articulo"
        Me.btnArticulo.UseVisualStyleBackColor = True
        '
        'txtPrecio
        '
        Me.txtPrecio.Enabled = False
        Me.txtPrecio.Location = New System.Drawing.Point(284, 72)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(127, 20)
        Me.txtPrecio.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Unidades a comprar:"
        '
        'nudUnidades
        '
        Me.nudUnidades.Location = New System.Drawing.Point(178, 108)
        Me.nudUnidades.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudUnidades.Name = "nudUnidades"
        Me.nudUnidades.Size = New System.Drawing.Size(56, 20)
        Me.nudUnidades.TabIndex = 7
        Me.nudUnidades.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnAñadir
        '
        Me.btnAñadir.Enabled = False
        Me.btnAñadir.Location = New System.Drawing.Point(12, 143)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(399, 29)
        Me.btnAñadir.TabIndex = 8
        Me.btnAñadir.Text = "Añadir al carro"
        Me.btnAñadir.UseVisualStyleBackColor = True
        '
        'lstCarro
        '
        Me.lstCarro.FormattingEnabled = True
        Me.lstCarro.Location = New System.Drawing.Point(12, 178)
        Me.lstCarro.Name = "lstCarro"
        Me.lstCarro.Size = New System.Drawing.Size(399, 160)
        Me.lstCarro.TabIndex = 9
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Enabled = False
        Me.lblTotal.Location = New System.Drawing.Point(296, 357)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(34, 13)
        Me.lblTotal.TabIndex = 10
        Me.lblTotal.Text = "Total:"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(336, 354)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(75, 20)
        Me.txtTotal.TabIndex = 11
        Me.txtTotal.Text = "0"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(238, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Precio:"
        '
        'frnPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 425)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lstCarro)
        Me.Controls.Add(Me.btnAñadir)
        Me.Controls.Add(Me.nudUnidades)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtArticulo)
        Me.Controls.Add(Me.btnArticulo)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.btnCliente)
        Me.Name = "frnPedidos"
        Me.Text = "frnPedidos"
        CType(Me.nudUnidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCliente As System.Windows.Forms.Button
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents txtArticulo As System.Windows.Forms.TextBox
    Friend WithEvents btnArticulo As System.Windows.Forms.Button
    Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nudUnidades As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnAñadir As System.Windows.Forms.Button
    Friend WithEvents lstCarro As System.Windows.Forms.ListBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
