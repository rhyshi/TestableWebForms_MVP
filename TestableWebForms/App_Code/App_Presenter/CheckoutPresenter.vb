Imports Microsoft.VisualBasic
Imports Core

Public Class CheckoutPresenter

    Private ReadOnly _checkoutService As ICheckoutService

    Private _view As ICheckoutView

    'Private ReadOnly INavigationService _navigation;

    Public Sub New(view As ICheckoutView, checkoutService As ICheckoutService)
        _view = view

        _checkoutService = checkoutService
    End Sub

    Public Sub Initialize()
        ' get the checkout summary from the Model
        Dim summary As CheckoutSummaryModel = _checkoutService.GetSummary(_view.SessionID)

        If (summary IsNot Nothing) Then
            Dim productItems = New List(Of String)

            For Each item In summary.Products
                productItems.Add(item)
            Next

            _view.Products = productItems
            _view.SubTotal = 10
            _view.Discount = 10
            _view.Total = 9

        End If
        '            {
        '    IList<ProductItem> productItems = New List<ProductItem>();

        '    foreach (Product item in summary.Products)
        '    {
        '        productItems.Add(New ProductItem() { ProductName = item.ProductName, UnitPrice = item.UnitPrice });
        '    }

        '    // set the properties to be displayed to the View
        '    _view.Products = productItems;
        '    _view.SubTotal = summary.SubTotal;
        '    _view.Discount = summary.Discount;
        '    _view.Total = summary.Total;

        'Else

        '    _navigation.GoTo(ViewPages.SessionNotFound);


    End Sub

    Public Sub Checkout()

    End Sub

    'Public void Checkout()
    '{
    '    // take payment And authorise
    '    CheckoutPaymentDetail checkoutDetail = New CheckoutPaymentDetail();
    '    checkoutDetail.CardNumber = _view.CardNumber;
    '    checkoutDetail.CustomerName = _view.CustomerName;

    '    _checkoutService.Checkout(checkoutDetail);

    '    // redirect to confirmation page
    '    _navigation.GoTo(ViewPages.Confirmation);
    '}


End Class
