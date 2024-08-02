namespace DayTwo.InventoryContext
{
  public class ProductSearcher
  {
    private CategoryManager categoryManager;

    public ProductSearcher(CategoryManager categoryManager)
    {
      this.categoryManager = categoryManager;
    }

    public void SearchProduct(string productName)
    {
      foreach (var category in categoryManager.categories)
      {
        var product = category.Value.Find(p => p.Name == productName);
        if (product != null)
        {
          Console.WriteLine($"Product found in category '{category.Key}': Name: {product.Name}, Quantity: {product.Quantity}, Price: {product.Price:C}");
          return;
        }
      }
      Console.WriteLine($"Product '{productName}' not found.");
    }
  }
}