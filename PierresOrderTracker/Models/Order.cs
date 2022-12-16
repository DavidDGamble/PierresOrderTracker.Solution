namespace PierresOrderTracker.Models
{
  public class Order
  {
    private static List<Order> _orders = new List<Order> { };
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public string Date { get; set; }
    public int Id { get; set; }

    public Order(string title, string description, int price, string date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
      _orders.Add(this);
      Id = _orders.Count;
    }

    public static void ClearAll()
    {
      _orders.Clear();
    }

    public static List<Order> GetAll()
    {
      return _orders;
    }

    public static Order Find(int searchId)
    {
      Order newOrder2 = new Order("Monthly Order", "This order will be dilvered once a month", 1000, "12/16/22");
      return newOrder2;
    }
  }
}