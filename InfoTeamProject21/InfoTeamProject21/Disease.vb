Option Strict On
Option Explicit On
Option Infer Off
Public Class Disease
    '<<Attributes>>
    Private _NumberInfected As Integer
    Private _Name As String
    Private _Persons() As PersonInfected

    '<<Property>>
    Public Property NumberInfected As Integer
        Get
            Return _NumberInfected
        End Get
        Set(value As Integer)
            _NumberInfected = value
        End Set
    End Property

    Public Property Name As String
        Get
            Return _Name
        End Get
        Set(value As String)
            _Name = value
        End Set
    End Property

    Public Property Persons(index As Integer) As PersonInfected
        Get
            Return _Persons(index)
        End Get
        Set(value As PersonInfected)
            _Persons(index) = value
        End Set
    End Property

    Public Property Persons() As PersonInfected()
        Get
            Return _Persons
        End Get
        Set(value() As PersonInfected)
            _Persons = value
        End Set
    End Property

    '<<Methoods>>
    'Public Sub New(size As Integer) 'resize the Array
    '    ReDim _Persons(size)
    'End Sub

    Public Sub New() 'resize the Array

    End Sub

    'Public Sub New(Number As Integer)
    '    _NumberInfected = Number
    'End Sub

    'calclulate the TransmitionRates of the diseases
    Public Function TransmitionRates(DiseasesPrevalence As Double) As Double
        Return (_NumberInfected / DiseasesPrevalence) * 100
    End Function

End Class
