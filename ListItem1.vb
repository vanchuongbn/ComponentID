Option Strict On
Option Explicit On
Public Class ListItem1
    Private mvalue As String
    Private mID As String
    Private mID1 As String
    Public Sub New(ByVal strvalue As String, ByVal intID As String, ByVal intID1 As String)
        mvalue = strvalue
        mID = intID
        mID1 = intID1
    End Sub

    Public Sub New()
        mvalue = ""
        mID = ""
        mID1 = ""
    End Sub
    Property ID() As String
        Get
            Return mID
        End Get
        Set(ByVal Value As String)
            mID = Value
        End Set
    End Property
    Property ID1() As String
        Get
            Return mID1
        End Get
        Set(ByVal Value As String)
            mID1 = Value
        End Set
    End Property
    Property value() As String
        Get
            Return mvalue
        End Get
        Set(ByVal Value As String)
            mvalue = Value
        End Set
    End Property

    Public Overrides Function tostring() As String
        Return mvalue
    End Function
End Class
