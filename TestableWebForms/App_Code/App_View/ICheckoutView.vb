Imports Microsoft.VisualBasic

Public Interface ICheckoutView

    ReadOnly Property SessionID() As String
    Property Products() As IEnumerable(Of String)
    ReadOnly Property CardNumber() As String
    ReadOnly Property CustomerName() As String
    Property SubTotal() As String
    Property Discount() As String
    Property Total() As String

End Interface
