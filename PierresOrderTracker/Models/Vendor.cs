namespace PierresOrderTracker.Models
{
  public class Vendor 
  {
    private static List<Vendor> _vendors = new List<Vendor> { };
    public string Name { get; set; }
    public string Description {get; set; }
    public int Id { get; set; }
    public List<Order> Orders { get; set; }

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      Orders = new List<Order> { };
      _vendors.Add(this);
      Id = _vendors.Count;
    }

    public static void ClearAll()
    {
      _vendors.Clear();
    }

    public static List<Vendor> GetAll()
    {
      return _vendors;
    }

    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }

    public static Vendor Find(int searchId)
    {
      return _vendors[searchId - 1];
    }

    public static void DeleteOrder(int vendorId, int orderId)
    {
      _vendors[vendorId - 1].Orders.RemoveAt(orderId - 1);
    }

    public static void Delete(int id)
    {
      _vendors.RemoveAt(id - 1);
      for (int i = id - 1; i < _vendors.Count; i++)
      {
        _vendors[i].Id -= 1;
      }
    }
  }
}