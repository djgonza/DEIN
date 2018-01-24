<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TextBoxExtendido1 = New UT2_ProyectoVacio.TextBoxExtendido()
        Me.TextBoxExtendido2 = New UT2_ProyectoVacio.TextBoxExtendido()
        Me.TextBoxExtendido3 = New UT2_ProyectoVacio.TextBoxExtendido()
        Me.TextBoxExtendido4 = New UT2_ProyectoVacio.TextBoxExtendido()
        Me.TextBoxExtendido5 = New UT2_ProyectoVacio.TextBoxExtendido()
        Me.TextBoxExtendido6 = New UT2_ProyectoVacio.TextBoxExtendido()
        Me.SuspendLayout()
        '
        'TextBoxExtendido1
        '
        Me.TextBoxExtendido1.AplicarColorFoco = True
        Me.TextBoxExtendido1.ColorControlDeDesenfocado = System.Drawing.Color.Coral
        Me.TextBoxExtendido1.ColorControlEnfocado = System.Drawing.Color.LightSeaGreen
        Me.TextBoxExtendido1.Location = New System.Drawing.Point(12, 12)
        Me.TextBoxExtendido1.Name = "TextBoxExtendido1"
        Me.TextBoxExtendido1.Size = New System.Drawing.Size(108, 20)
        Me.TextBoxExtendido1.TabIndex = 0
        '
        'TextBoxExtendido2
        '
        Me.TextBoxExtendido2.AplicarColorFoco = True
        Me.TextBoxExtendido2.ColorControlDeDesenfocado = System.Drawing.Color.Coral
        Me.TextBoxExtendido2.ColorControlEnfocado = System.Drawing.Color.Azure
        Me.TextBoxExtendido2.Location = New System.Drawing.Point(12, 38)
        Me.TextBoxExtendido2.Name = "TextBoxExtendido2"
        Me.TextBoxExtendido2.Size = New System.Drawing.Size(108, 20)
        Me.TextBoxExtendido2.TabIndex = 2
        '
        'TextBoxExtendido3
        '
        Me.TextBoxExtendido3.AplicarColorFoco = True
        Me.TextBoxExtendido3.ColorControlDeDesenfocado = System.Drawing.Color.Coral
        Me.TextBoxExtendido3.ColorControlEnfocado = System.Drawing.Color.Azure
        Me.TextBoxExtendido3.Location = New System.Drawing.Point(12, 64)
        Me.TextBoxExtendido3.Name = "TextBoxExtendido3"
        Me.TextBoxExtendido3.Size = New System.Drawing.Size(108, 20)
        Me.TextBoxExtendido3.TabIndex = 3
        '
        'TextBoxExtendido4
        '
        Me.TextBoxExtendido4.AplicarColorFoco = True
        Me.TextBoxExtendido4.ColorControlDeDesenfocado = System.Drawing.Color.Coral
        Me.TextBoxExtendido4.ColorControlEnfocado = System.Drawing.Color.Azure
        Me.TextBoxExtendido4.Location = New System.Drawing.Point(126, 64)
        Me.TextBoxExtendido4.Name = "TextBoxExtendido4"
        Me.TextBoxExtendido4.Size = New System.Drawing.Size(108, 20)
        Me.TextBoxExtendido4.TabIndex = 6
        '
        'TextBoxExtendido5
        '
        Me.TextBoxExtendido5.AplicarColorFoco = True
        Me.TextBoxExtendido5.ColorControlDeDesenfocado = System.Drawing.Color.Coral
        Me.TextBoxExtendido5.ColorControlEnfocado = System.Drawing.Color.Azure
        Me.TextBoxExtendido5.Location = New System.Drawing.Point(126, 38)
        Me.TextBoxExtendido5.Name = "TextBoxExtendido5"
        Me.TextBoxExtendido5.Size = New System.Drawing.Size(108, 20)
        Me.TextBoxExtendido5.TabIndex = 5
        '
        'TextBoxExtendido6
        '
        Me.TextBoxExtendido6.AplicarColorFoco = True
        Me.TextBoxExtendido6.ColorControlDeDesenfocado = System.Drawing.Color.Coral
        Me.TextBoxExtendido6.ColorControlEnfocado = System.Drawing.Color.Azure
        Me.TextBoxExtendido6.Location = New System.Drawing.Point(126, 12)
        Me.TextBoxExtendido6.Name = "TextBoxExtendido6"
        Me.TextBoxExtendido6.Size = New System.Drawing.Size(108, 20)
        Me.TextBoxExtendido6.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(243, 102)
        Me.Controls.Add(Me.TextBoxExtendido4)
        Me.Controls.Add(Me.TextBoxExtendido5)
        Me.Controls.Add(Me.TextBoxExtendido6)
        Me.Controls.Add(Me.TextBoxExtendido3)
        Me.Controls.Add(Me.TextBoxExtendido2)
        Me.Controls.Add(Me.TextBoxExtendido1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxExtendido1 As UT2_ProyectoVacio.TextBoxExtendido
    Friend WithEvents TextBoxExtendido2 As UT2_ProyectoVacio.TextBoxExtendido
    Friend WithEvents TextBoxExtendido3 As UT2_ProyectoVacio.TextBoxExtendido
    Friend WithEvents TextBoxExtendido4 As UT2_ProyectoVacio.TextBoxExtendido
    Friend WithEvents TextBoxExtendido5 As UT2_ProyectoVacio.TextBoxExtendido
    Friend WithEvents TextBoxExtendido6 As UT2_ProyectoVacio.TextBoxExtendido

End Class
