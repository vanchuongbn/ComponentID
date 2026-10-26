Imports System

Public Enum ComponentCheckStatus
    Valid
    WrongUgpn
    NotFound
    Duplicate
    InvalidQuantity
End Enum

Public Class ComponentItem
    Public Property Sequence As Integer
    Public Property ComponentId As String = String.Empty
    Public Property ControlId As Long
    Public Property Ugpn As String = String.Empty
    Public Property CurrentLocation As String = String.Empty
    Public Property Quantity As Decimal
    Public Property Status As ComponentCheckStatus
    Public Property StatusText As String = String.Empty
    Public Property Detail As String = String.Empty
End Class
