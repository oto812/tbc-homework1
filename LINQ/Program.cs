namespace homework1.LINQ;

public class Program
{
    public static void Main()
    {
        var customerList = new List<Customer>();
        var orderList = new List<Order>();

        foreach (string line in File.ReadLines("D:\\TBC-academy\\tbc-homework1\\LINQ\\Customers.txt"))
        {
            var customerData = line.Split('|');
            customerList.Add(new Customer(int.Parse(customerData[0]), customerData[1]));
        }

        foreach (string line in File.ReadLines("D:\\TBC-academy\\tbc-homework1\\LINQ\\Orders.txt"))
        {
            var orderData = line.Split('|');
            orderList.Add(new Order(int.Parse(orderData[0]), DateTime.ParseExact(orderData[1], 
                "yyyyMMdd",null), orderData[2], double.Parse(orderData[3]),
                int.Parse(orderData[4]))); 
        }

        //1,2,3 tasks
        var totalOrdersByCustomer = from c in customerList
            join o in orderList
                on c.CustomerId equals o.CustomerID into customerOrders
            select new {Customer = c.CustomerId, OrderCount = customerOrders.Count(),
                SumAmount = customerOrders.Sum(x => x.Price), 
                MinAmount = customerOrders.Min(x => x.Price),
            };
        foreach (var item in totalOrdersByCustomer)
        {
            Console.WriteLine($"CustomerId - {item.Customer}, OrderCount - {item.OrderCount}, SumAmount - {item.SumAmount}," +
                              $" MinAmount - {item.MinAmount}");
        }
        
        //4 task
        var moreThanOneOrder = from c in customerList
            join o in orderList
                on c.CustomerId equals o.CustomerID into customerOrders where customerOrders.Count() > 1
            select new { Customer = c.CustomerId, OrderCount = customerOrders.Count() };
        
        foreach (var item in moreThanOneOrder)
        {
            Console.WriteLine($"CustomerId - {item.Customer}, OrderCount - {item.OrderCount}");
        }
        
        // 5 task
        
        var avgAmountMoreThanTen = from c in customerList
            join o in orderList
                on c.CustomerId equals o.CustomerID into customerOrders where customerOrders.Average(x => x.Price) > 10
            select new { Customer = c.CustomerId, AvgAmount = customerOrders.Average(x => x.Price) };
        
        foreach (var item in avgAmountMoreThanTen)
        {
            Console.WriteLine($"CustomerId - {item.Customer}, AvgAmount - {item.AvgAmount} ");
        }

        
        
        
        
        
        
        








    }
}