<<<<<<< Updated upstream
﻿Public Class Malaria
=======
﻿Option Strict On
Option Explicit On
Option Infer Off
Public Class Malaria
    Inherits Disease
    'ATTRIBUTES
    Private _ParasiteType As Integer
    Private _NumSymptoms As Integer 'set as integer to make it easier to determine whether on should see a doctor
    Private _SeeDoc As Boolean

    'PROPERTY METHODS
    Public Property ParasiteType() As Integer
        Get
            Return _ParasiteType
        End Get
        Set(value As Integer)
            _ParasiteType = value
        End Set
    End Property

    Public Property NumSymptoms() As Integer
        Get
            Return _NumSymptoms
        End Get
        Set(value As Integer)
            _NumSymptoms = value
        End Set
    End Property

    'CONSTRUCTORS

    Public Sub New(n As Integer, d As Double, name As String)
        MyBase.New()
    End Sub

    Public Sub New(NumSymptoms As Integer)
        NumSymptoms = _NumSymptoms
    End Sub

    'CLASS METHODS
    'Function to determine whether the person should see a doctor
    'If the person has a specific type of parasite and a certain number of symptoms they will either need to see a doctor or not see a doctor 
    Public Overloads Function SeeDoctor(ByVal _ParasiteType As Integer, ByVal _NumSymptoms As Integer, ByRef _SeeDoc As Boolean) As Boolean
        Select Case (_ParasiteType)
            Case 1
                If _NumSymptoms < 5 Then
                    _SeeDoc = False
                Else
                    _SeeDoc = True
                End If
            Case 2
                If _NumSymptoms < 6 Then
                    _SeeDoc = False
                Else
                    _SeeDoc = True
                End If
            Case 3
                If _NumSymptoms < 4 Then
                    _SeeDoc = False
                Else
                    _SeeDoc = True
                End If
            Case 4
                If _NumSymptoms < 2 Then
                    _SeeDoc = False
                Else
                    _SeeDoc = True
                End If
        End Select
        Return _SeeDoc
    End Function
>>>>>>> Stashed changes

    Public Overrides Function TransmitionRates(DiseasesPrevalence As Double) As Double
        Return NumberInfected / DiseasesPrevalence
    End Function

End Class
