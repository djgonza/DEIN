Imports System.Windows.Forms
Imports System.ComponentModel
Imports System.Drawing

Public Class TextBoxExtendido
    Inherits TextBox

    Private _ColorControlEnfocado As Color = Color.Red
    <Category("Apariencia"),
    Description("Almacena el color que muestra el control " & _
        "cuando reciba el foco, solo si la propiedad " & _
        "Aplicar el foco es True")> _
    Public Property ColorControlEnfocado() As Color
        Get
            Return _ColorControlEnfocado
        End Get
        Set(ByVal value As Color)
            _ColorControlEnfocado = value
        End Set
    End Property

    Private _ColorControlDeDesenfocado As Color = Color.Coral
    <Category("Apariencia"),
    Description("Almacena el color que muestra el control " & _
        "cuando pierda el foco, solo si la propiedad " & _
        "Aplicar el foco es True")> _
    Public Property ColorControlDeDesenfocado() As Color
        Get
            Return _ColorControlDeDesenfocado
        End Get
        Set(ByVal value As Color)
            _ColorControlDeDesenfocado = value
        End Set
    End Property

    Private _AplicarColorFoco As Boolean = False
    <Category("Apariencia"),
    Description("Cuando su valor es True " & _
        "habilita las propiedades " & _
        "ColorControlEnfocado y ColorControlDesenfocado")> _
    Public Property AplicarColorFoco() As Boolean
        Get
            Return _AplicarColorFoco
        End Get
        Set(ByVal value As Boolean)
            _AplicarColorFoco = value
        End Set
    End Property

    Private Sub TextBoxExtendido1_Enter(sender As Object, e As System.EventArgs) Handles MyBase.Enter
        If Not AplicarColorFoco Then Return
        Me.BackColor = ColorControlEnfocado
    End Sub

    Private Sub TextBoxExtendido1_Leave(sender As Object, e As System.EventArgs) Handles MyBase.Leave
        If Not AplicarColorFoco Then Return
        Me.BackColor = ColorControlDeDesenfocado
    End Sub


End Class

