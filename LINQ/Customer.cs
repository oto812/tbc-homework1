using System.Runtime.InteropServices.JavaScript;

namespace homework1.LINQ;

public class Customer
{
    public int CustomerId { get; }
    public string CustomerName { get; }

    public Customer(int customerId, string customerName)
    {
        CustomerId = customerId;
        CustomerName = customerName;
    }
}