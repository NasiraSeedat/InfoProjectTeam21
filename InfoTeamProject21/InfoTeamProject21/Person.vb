Option Strict On
Option Explicit On
Option Infer Off
Public Class Person
    '<<Attributes>>
    Private _Name As String
    Private _Age As Integer

    '<<Property>>
    Public Property Name As String
        Get
            Return _Name
        End Get
        Set(value As String)
            _Name = value
        End Set
    End Property

    Public Property Age As Integer
        Get
            Return _Age
        End Get
        Set(value As Integer)
            _Age = value
        End Set
    End Property

    '<<Methoods>>
    Public Function SurvivalRate(age As Integer) As Double 'Calculate survival rate if person has Maleria
        If age < 5 Then
            Return 3.13
        Else
            Return 3.05
        End If
    End Function


End Class
