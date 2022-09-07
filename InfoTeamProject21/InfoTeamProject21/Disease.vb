Option Strict On
Option Explicit On
Option Infer Off
Public Class Disease
    '<<Attributes>>
    Private _NumberInfected As Integer
    Private _DeathRate As Integer
    Private _Name As String

    '<<Property>>
    Public Property NumberInfected() As Integer
        Get
            Return _NumberInfected
        End Get
        Set(value As Integer)
            _NumberInfected = value
        End Set
    End Property

    Public Property DeathRate As Integer
        Get
            Return _DeathRate
        End Get
        Set(value As Integer)
            _DeathRate = value
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

    '<<Methoods>>
    'calclulate the TransmitionRates of the diseases
    Public Overridable Function TransmitionRates(DiseasesPrevalence As Double) As Double
        Return NumberInfected / DiseasesPrevalence
    End Function
End Class
