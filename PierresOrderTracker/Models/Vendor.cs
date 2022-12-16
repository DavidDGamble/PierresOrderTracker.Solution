namespace PierresOrderTracker.Models
{
  public class Vendor 
  {
    private static List<Vendor> _vendors = new List<Vendor> { };
    public string Name { get; set; }
    public string Description {get; set; }
    public int Id { get; set; }
    public List<Order> Orders {get; set; }

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
  }
}