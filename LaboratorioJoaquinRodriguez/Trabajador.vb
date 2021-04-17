Public Class Trabajador
    Inherits Persona

    Private afp As Integer
    Private salario As Integer
    Private contratar As String

    Public Sub New(nombre As String, apellido As String, dui As Integer, estado As String, fechainicio As Integer, sexo As String, afp As Integer, salario As Integer, contratar As String)
        MyBase.New(nombre, apellido, dui, estado, fechainicio, sexo)
        Me.afp = afp
        Me.salario = salario
        Me.contratar = contratar
    End Sub

    Public Property Propafp As Integer
        Get
            Return afp
        End Get
        Set(value As Integer)
            afp = value
        End Set
    End Property

    Public Property Propsalario As Integer
        Get
            Return salario
        End Get
        Set(value As Integer)
            salario = value
        End Set
    End Property

    Public Property Propcontratar As String
        Get
            Return contratar
        End Get
        Set(value As String)
            contratar = value
        End Set
    End Property

End Class


