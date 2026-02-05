using POLYMOPHISM.Enum;
using POLYMOPHISM.Models;
using POLYMOPHISM.Orders;
using POLYMOPHISM.Payments;
using POLYMOPHISM.Services;

internal class Program
{
    static void Main()
    {
        var product = CreateDefaultProduct();

        while (true)
        {
            ShowMainMenu();

            int menu = ReadIntInput("Chọn: ");

            if(menu == 3)
            {
                ShowExitMessage();
                break;
            }

            var orderType = GetOrderType(menu);
            if (orderType == null) continue;

            int quantity = ReadIntInput("Nhập số lượng: ");

            var payment = GetPayment();
            if (payment == null) continue;

            ProcessOrder(product, orderType, payment, quantity);
        }
    }

    #region HELPER FUNCTION
    static Product CreateDefaultProduct()
    {
        return new Product
        {
            Id = 1,
            Name = "Máy khoan",
            Price = 1000000
        };
    }

    static void ShowMainMenu()
    {
        Console.WriteLine("\n=== CỬA HÀNG TIỆN LỢI ===");
        Console.WriteLine("1. Mua đồ");
        Console.WriteLine("2. Thuê đồ");
        Console.WriteLine("3. Exit");
    }

    static int ReadIntInput(string message)
    {
        Console.Write(message);
        int.TryParse(Console.ReadLine(), out int value);
        return value;
    }

    static IOrderType? GetOrderType(int menu)
    {
        if(!Enum.IsDefined(typeof(OrderType), menu))
        {
            Console.WriteLine("Lựa chọn không hợp lệ");
            return null;
        }

        return OrderTypeFactory.Create((OrderType)menu);
    }

    static IPayment? GetPayment()
    {
        Console.WriteLine("\nChọn hình thức thanh toán:");
        Console.WriteLine("1. Tiền mặt");
        Console.WriteLine("2. Chuyển khoản");

        int paymentInput = ReadIntInput("Chọn: ");

        if (!Enum.IsDefined(typeof(PaymentType), paymentInput))
        {
            Console.WriteLine("Thanh toán không hợp lệ");
            return null;
        }

        return PaymentFactory.Create((PaymentType)paymentInput);
    }

    static void ProcessOrder(
            Product product,
            IOrderType orderType,
            IPayment payment,
            int quantity)
    {
        var service = new OrderService(orderType, payment);
        service.Process(product, quantity);
    }

    static void ShowExitMessage()
    {
        Console.WriteLine("🙏 Cảm ơn bạn đã sử dụng dịch vụ!");
    }
    #endregion
}