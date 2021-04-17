Public Class Obrero
    Inherits Persona

    Private costohora As Integer
    Private costohoraextra As Integer
    Private horasextras As Integer
    Private horas As Integer

    Public Sub New(nombre As String, apellido As String, dui As Integer, estado As String, fechainicio As Integer, sexo As String, afp As Integer, salario As Integer, contratar As String, costohora As Integer, costohoraextra As Integer, horasextras As Integer, horas As Integer)
        MyBase.New(nombre, apellido, dui, estado, fechainicio, sexo)
        Me.costohora = costohora
        Me.costohoraextra = costohoraextra
        Me.horasextras = horasextras
        Me.horas = horas
    End Sub

    Public Property Propcostohora As Integer
        Get
            Return costohora
        End Get
        Set(value As Integer)
            costohora = value
        End Set
    End Property

    Public Property Propcostohoraextra As Integer
        Get
            Return costohoraextra
        End Get
        Set(value As Integer)
            costohoraextra = value
        End Set
    End Property

    Public Property Prophoraextras As Integer
        Get
            Return horasextras
        End Get
        Set(value As Integer)
            horasextras = value
        End Set
    End Property
    Public Property Prophoras As Integer
        Get
            Return horas
        End Get
        Set(value As Integer)
            horas = value
        End Set
    End Property

End Class

