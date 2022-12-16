namespace PierresOrderTracker.Models
{
  public class Pastry
  {
    public int PastryTotal { get; set; }
    private int _totalCost; 

    public Pastry(int pastryTotal)
    {
      PastryTotal = pastryTotal;
      _totalCost = 0;
    }

    public int GetTotalCost() { return _totalCost; }

    public void CalcTotal()
    {
      _totalCost = PastryTotal * 2;
      if (PastryTotal > 2)
      {
        int freeNum = PastryTotal / 3;
        _totalCost -= freeNum;
      }
    }
  }
}