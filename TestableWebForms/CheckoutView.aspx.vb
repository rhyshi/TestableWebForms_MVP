Imports Telerik.Web.UI

Partial Class _Default
    Inherits System.Web.UI.Page
    Implements ICheckoutView

    Private _presenter As CheckoutPresenter

    Public ReadOnly Property CardNumber As String Implements ICheckoutView.CardNumber
        Get
            Return Me.uxCardNumber.Text
        End Get
    End Property

    Public ReadOnly Property CustomerName As String Implements ICheckoutView.CustomerName
        Get
            Return Me.uxCustomerName.Text
        End Get
    End Property

    Public Property Discount As String Implements ICheckoutView.Discount
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As String)
            Throw New NotImplementedException()
        End Set
    End Property

    Public Property Products As IEnumerable(Of String) Implements ICheckoutView.Products
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As IEnumerable(Of String))
            Throw New NotImplementedException()
        End Set
    End Property

    Public ReadOnly Property SessionID As String Implements ICheckoutView.SessionID
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Public Property SubTotal As String Implements ICheckoutView.SubTotal
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As String)
            Throw New NotImplementedException()
        End Set
    End Property

    Public Property Total As String Implements ICheckoutView.Total
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As String)
            Throw New NotImplementedException()
        End Set
    End Property

    Public Sub New()
        _presenter = New CheckoutPresenter(Me, New Core.StubCheckoutService())
    End Sub


    Private Sub _Default_Load(sender As Object, e As EventArgs) Handles Me.Load
        _presenter.Initialize()
    End Sub
    Protected Sub uxCheckout_Click(sender As Object, e As EventArgs)
        _presenter.Checkout()
    End Sub
End Class
