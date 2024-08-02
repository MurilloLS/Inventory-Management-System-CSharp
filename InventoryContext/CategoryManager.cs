using DayTwo.ProductContext;

namespace DayTwo.InventoryContext
{
  public class CategoryManager
  {
    internal Dictionary<string, List<Product>> categories;

    public CategoryManager()
    {
      categories = new Dictionary<string, List<Product>>();
    }

    public void AddCategory(string category)
    {
      if (!categories.ContainsKey(category))
      {
        categories[category] = new List<Product>();
        Console.WriteLine($"Category '{category}' added.");
      }
      else
      {
        Console.WriteLine($"Category '{category}' already exists.");
      }
    }

    public void RemoveCategory(string category)
    {
      if (categories.ContainsKey(category))
      {
        categories.Remove(category);
        Console.WriteLine($"Category '{category}' removed.");
      }
      else
      {
        Console.WriteLine($"Category '{category}' not found.");
      }
    }

    public bool CategoryExists(string category)
    {
      return categories.ContainsKey(category);
    }
  }
}