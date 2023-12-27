using System;
using System.Collections.Generic;

class Product
{
    public string Name { get; set; }
    public double Price { get; set; }

    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public override string ToString()
    {
        return $"- product: {Name} {Price} e";
    }
}

class ShoppingCart
{
    private List<Product> cartItems = new List<Product>();

    public void AddToCart(Product product)
    {
        cartItems.Add(product);
    }

    public int GetCartSize()
    {
        return cartItems.Count;
    }

    public void DisplayCartContents()
    {
        Console.WriteLine("Your products in shopping cart:");
        foreach (var item in cartItems)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine($"There are {GetCartSize()} products in the shopping cart.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        ShoppingCart cart = new ShoppingCart();

        // Adding products to the shopping cart
        cart.AddToCart(new Product("Milk", 1.4));
        cart.AddToCart(new Product("Bread", 2.2));
        cart.AddToCart(new Product("Butter", 3.2));
        cart.AddToCart(new Product("Cheese", 4.2));

        // Displaying the contents of the shopping cart
        cart.DisplayCartContents();

        Console.WriteLine("Press enter key to continue...");
        Console.ReadLine();
    }
}
