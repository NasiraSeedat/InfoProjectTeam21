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

    Public Function SurvivalRate(HAART As Boolean, TimeInfected As Integer) As Double 'Calculate survival rate if person has HIV/AIDS
        'HAART is a treatment for HIV/AIDS
        'TimeInfected is the time that the patient has had the disease

        If HAART = True Then
            Select Case TimeInfected
                Case <= 2
                    Return 87
                Case 2 To 4
                    Return 86
                Case 4 To 8
                    Return 78
                Case > 8
                    Return 61
            End Select
        Else
            Select Case TimeInfected
                Case <= 2
                    Return 48
                Case 2 To 4
                    Return 26
                Case > 4
                    Return 18
            End Select
        End If
    End Function
End Class
