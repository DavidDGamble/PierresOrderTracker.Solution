namespace PierresOrderTracker.Models
{
  public class Order
  {
    private static List<Order> _orders = new List<Order> { };
    public string Title { get; set; }
    public string Description { get; set; }
    public string Price { get; set; }
    public string Date { get; set; }
    public int Id { get; set; }

    public Order(string title, string description, string price, string date)
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
      return _orders[searchId - 1];
    }

    public static void Delete(int id)
    {
      _orders.RemoveAt(id - 1);
      for (int i = id - 1; i < _orders.Count; i++)
      {
        _orders[i].Id -= 1;
      }
    }
  }
}