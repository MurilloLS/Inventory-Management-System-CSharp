namespace DayTwo.InventoryContext
{
  public class ProductLister
  {
    private CategoryManager categoryManager;

    public ProductLister(CategoryManager categoryManager)
    {
      this.categoryManager = categoryManager;
    }

    public void ListProducts(string category)
    {
      if (categoryManager.CategoryExists(category))
      {
        Console.WriteLine($"Products in category '{category}':");
        foreach (var product in categoryManager.categories[category])
        {
          Console.WriteLine($"Name: {product.Name}, Quantity: {product.Quantity}, Price: {product.Price:C}");
        }
      }
      else
      {
        Console.WriteLine($"Category '{category}' not found.");
      }
    }
  }
}