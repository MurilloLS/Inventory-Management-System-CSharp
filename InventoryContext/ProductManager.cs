using DayTwo.ProductContext;

namespace DayTwo.InventoryContext
{
  public class ProductManager
  {
    private CategoryManager categoryManager;

    public ProductManager(CategoryManager categoryManager)
    {
      this.categoryManager = categoryManager;
    }

    public void AddProduct(string category, Product product)
    {
      if (categoryManager.CategoryExists(category))
      {
        var productList = categoryManager.categories[category];
        productList.Add(product);
        Console.WriteLine($"Product '{product.Name}' added to category '{category}'.");
      }
      else
      {
        Console.WriteLine($"Category '{category}' not found.");
      }
    }

    public void RemoveProduct(string category, string productName)
    {
      if (categoryManager.CategoryExists(category))
      {
        var productList = categoryManager.categories[category];
        var product = productList.Find(p => p.Name == productName);
        if (product != null)
        {
          productList.Remove(product);
          Console.WriteLine($"Product '{productName}' removed from category '{category}'.");
        }
        else
        {
          Console.WriteLine($"Product '{productName}' not found in category '{category}'.");
        }
      }
      else
      {
        Console.WriteLine($"Category '{category}' not found.");
      }
    }

    public void UpdateQuantity(string category, string productName, int newQuantity)
    {
      if (categoryManager.CategoryExists(category))
      {
        var productList = categoryManager.categories[category];
        var product = productList.Find(p => p.Name == productName);
        if (product != null)
        {
          product.Quantity = newQuantity;
          Console.WriteLine($"Quantity of product '{productName}' updated to {newQuantity}.");
        }
        else
        {
          Console.WriteLine($"Product '{productName}' not found in category '{category}'.");
        }
      }
      else
      {
        Console.WriteLine($"Category '{category}' not found.");
      }
    }
  }
}