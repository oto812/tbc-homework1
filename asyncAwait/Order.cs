namespace homework1.asyncAwait;

public enum OrderStatus {Processing,Failed,Shipped}
public class Order
{
    public int OrderId { get;  }
    public OrderStatus OrderStatus { get; set; }

    public Order(int orderId, OrderStatus orderStatus = OrderStatus.Processing)
    {
        OrderId = orderId;
    }

    private async Task<bool> ValidatePayment(int orderId)
    {
        Random rng = new Random();

        await Task.Delay(rng.Next(1000, 2000));
        
        Console.WriteLine($"Order {orderId} : Payment Validated");
        return true;
    }

    private async Task<bool> CkeckInventory(int orderId)
    {
        Random rng = new Random();

        await Task.Delay(rng.Next(1500, 2500));
        
        Console.WriteLine($"Order {orderId} : Inventory Checked");
        return true;
    }

    private async Task PrepareShipment(int orderId)
    {
        Random rng = new Random();

        await Task.Delay(rng.Next(2000, 3000));
        Console.WriteLine($"Order {orderId} : Shipment Prepared");
    }

    public async Task ProcessOrder(int orderId)
    {
        OrderStatus = OrderStatus.Processing;
        Console.WriteLine($"Order {orderId} : Processing Started");
        Task<bool> validatePayment = ValidatePayment(orderId);
        Task<bool> checkInventory = CkeckInventory(orderId);
        
        bool[] results = await Task.WhenAll(validatePayment, checkInventory);

        if (results[0] && results[1])
        {
            PrepareShipment(orderId);
            Console.WriteLine($"Order {orderId} : Ready to ship");
        }
        else
        {
            OrderStatus = OrderStatus.Failed;
            Console.WriteLine($"Order {orderId} : Preparing Shipment Failed");
        }
    }

    public static void Main()
    {
        Order order1 = new Order(1);
        Order order2 = new Order(2);
        Order order3 = new Order(3);
        Order order4 = new Order(4);
        Order order5 = new Order(5);
        
        Task t1 = order1.ProcessOrder(order1.OrderId);
        Task t2 = order2.ProcessOrder(order2.OrderId);
        Task t3 = order3.ProcessOrder(order3.OrderId);
        Task t4 = order4.ProcessOrder(order4.OrderId);
        Task t5 = order5.ProcessOrder(order5.OrderId);
        
        Task.WhenAll(t1,t2,t3,t4,t5).Wait();

    }
    
}