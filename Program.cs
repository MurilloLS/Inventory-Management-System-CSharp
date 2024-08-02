using DayTwo.InventoryContext;
using DayTwo.ProductContext;

public class Program
{
    public static void Main(String[] args)
    {
        CategoryManager categoryManager = new CategoryManager();
        ProductManager productManager = new ProductManager(categoryManager);
        ProductLister productLister = new ProductLister(categoryManager);
        ProductSearcher productSearcher = new ProductSearcher(categoryManager);

        // Adding categories
        categoryManager.AddCategory("Electronics");
        categoryManager.AddCategory("Clothing");

        // Adding products
        productManager.AddProduct("Electronics", new Product("Smartphone", 10, 299.99m));
        productManager.AddProduct("Clothing", new Product("Shirt", 20, 29.99m));

        // Listing products
        productLister.ListProducts("Electronics");

        // Updating quantity
        productManager.UpdateQuantity("Electronics", "Smartphone", 15);

        // Removing product
        productManager.RemoveProduct("Clothing", "Shirt");

        // Searching for a product
        productSearcher.SearchProduct("Smartphone");
    }
}