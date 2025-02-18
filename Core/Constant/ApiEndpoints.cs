/// <summary>
/// Represents the constants required for API configuration.
/// </summary>
namespace Core.Constant
{
    /// <summary>
    /// Provides API endpoint constants for various resources.
    /// </summary>
    public static class ApiEndpoints
    {
        /// <summary>
        /// Endpoint for product-related operations.
        /// </summary>
        public const string PRODUCT = "Product";

        /// <summary>
        /// Endpoint for category-related operations.
        /// </summary>
        public const string CATEGORY = "Category";

        /// <summary>
        /// Endpoint for retrieving a product by its ID.
        /// /// </summary>
        public const string PRODUCT_BY_ID = "Product/id?id=";

        public const string NOTIFICATION = "Notification";
        public const string NOTIFICATION_BY_ID = "Notification/id?id=";

        public const string CUSTOMER = "Customer";
        public const string CUSTOMER_BY_ID = "Customer/id?id=";
        public const string CUSTOMER_FORGET_PASSWORD = "Customer/forgetpassword?email=";
        public const string CUSTOMER_CHECK_USERNAME = "Customer/username?username=";
        public static string GetCustomerCheckLoginUrl(string username, string password)
        {
            return $"Customer/checklogin?username={username}&password={password}";
        }

        public const string BLOG = "Post";

        public const string ORDER = "Order";
        public const string ORDER_BY_ID = "Order/id?id=";
        public const string ORDER_BY_CUSTOMER = "Order/GetCusId?customerID=";

        public const string PAYMENT_BY_ID = "Payment/GetCusIdPayment?CustomerID=";

        public const string CART = "Cart";
        public const string CART_BY_CUSID = "Cart/CustomerID?CustomerID=";
        public const string CART_BY_ID = "Order/id?id=";
    }
}