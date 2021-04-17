Public Class Persona

    Private nombre As String
    Private apellido As String
    Private dui As Integer
    Private estado As String
    Private fechainicio As Integer
    Private sexo As String

    Public Sub New(nombre As String, apellido As String, dui As Integer, estado As String, fechainicio As Integer, sexo As String)
        Me.nombre = nombre
        Me.apellido = apellido
        Me.dui = dui
        Me.estado = estado
        Me.fechainicio = fechainicio
        Me.sexo = sexo
    End Sub

    Public Property propnombre() As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property propapellido() As String
        Get
            Return apellido
        End Get
        Set(value As String)
            apellido = value
        End Set
    End Property

    Public Property propdui() As Integer
        Get
            Return dui
        End Get
        Set(value As Integer)
            dui = value
        End Set
    End Property

    Public Property proestado() As String
        Get
            Return estado
        End Get
        Set(value As String)
            estado = value
        End Set
    End Property

    Public Property propfechainicio() As Integer
        Get
            Return fechainicio
        End Get
        Set(value As Integer)
            fechainicio = value
        End Set
    End Property

    Public Property propsexo() As String
        Get
            Return sexo
        End Get
        Set(value As String)
            sexo = value
        End Set
    End Property

End Class
