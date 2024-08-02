namespace DayTwo.ProductContext
{
  public class Product
  {
    public Product(string name, int quantity, decimal price)
    {
      Name = name;
      Quantity = quantity;
      Price = price;
    }
    public string Name { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
  }
}