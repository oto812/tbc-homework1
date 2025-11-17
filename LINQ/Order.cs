namespace homework1.LINQ;

public class Order
{
    public int OrderID { get; }
    public DateTime OrderDate { get; }
    public string Product { get; }
    public double Price { get; }
    public int CustomerID { get; }


    public Order(int orderID, DateTime orderDate, string product, double price, int customerID)
    {
        OrderID = orderID;
        OrderDate = orderDate;
        Product = product;
        Price = price;
        CustomerID = customerID;
    }
}