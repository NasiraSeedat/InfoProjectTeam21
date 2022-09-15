Option Strict On
Option Explicit On
Option Infer Off
Public MustInherit Class PersonInfected
    '<<Attributes>>
    Private _Name As String
    Private _Age As Integer
    Private _SeeDoc As Boolean

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


    Public Property SeeDoc As Boolean
        Get
            Return _SeeDoc
        End Get
        Set(value As Boolean)
            _SeeDoc = value
        End Set
    End Property
    '<<Methoods>>

    Public MustOverride Function SeeDoctor() As Boolean

End Class
