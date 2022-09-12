Option Strict On
Option Explicit On
Option Infer Off
Public Class HIVandAIDS
    'ATTRIBUTES
    Private _YearsWith As Double
    Private _TypefARV As String
    Private _SeeDoc As Boolean

    'PROPERTY METHODS
    Public Property YearsWith() As Double
        Get
            Return _YearsWith
        End Get
        Set(value As Double)
            _YearsWith = value
        End Set
    End Property

    Public Property TypefARV() As String
        Get
            Return _TypefARV
        End Get
        Set(value As String)
            _TypefARV = value
        End Set
    End Property

    'CONSTRUCTORS
    'Parameter-less
    Public Sub New()

    End Sub
    'Parameterised
    Public Sub New(YearsWith As Double)
        _YearsWith = YearsWith
    End Sub

    'CLASS METHODS
    'Function to determine the type of ARV the person will have to use 
    Public Function CalcTypefARV(YearsWith As Double) As String
        Select Case (YearsWith)
            Case <= 2
                _TypefARV = "Single Tablet Regimens"
            Case 2 To 8
                _TypefARV = "Protease Inhibitors"
            Case > 8
                _TypefARV = "Nucleoside reverse transcriptase inhibitors"
        End Select

        Return _TypefARV
    End Function

    'Function to determine whether the person should see a doctor or not 
    Public Function SeeDoctor() As Boolean
        If (_YearsWith < 5) Then
            _SeeDoc = False
        Else
            _SeeDoc = True
        End If

        Return (_SeeDoc)
    End Function



End Class
