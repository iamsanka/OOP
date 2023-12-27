using NUnit.Framework;

[TestFixture]
public class ShoppingCartTests
{
    [Test]
    public void TestCartWithNoProducts()
    {
        ShoppingCart cart = new ShoppingCart();
        Assert.AreEqual(0, cart.GetCartSize());
    }

    [Test]
    public void TestCartWithOneProduct()
    {
        ShoppingCart cart = new ShoppingCart();
        cart.AddToCart(new Product("Milk", 1.4));
        Assert.AreEqual(1, cart.GetCartSize());
    }

    [Test]
    public void TestCartWithTwoProducts()
    {
        ShoppingCart cart = new ShoppingCart();
        cart.AddToCart(new Product("Milk", 1.4));
        cart.AddToCart(new Product("Bread", 2.2));
        Assert.AreEqual(2, cart.GetCartSize());
    }

    [Test]
    public void TestCartWithFiveProducts()
    {
        ShoppingCart cart = new ShoppingCart();
        cart.AddToCart(new Product("Milk", 1.4));
        cart.AddToCart(new Product("Bread", 2.2));
        cart.AddToCart(new Product("Butter", 3.2));
        cart.AddToCart(new Product("Cheese", 4.2));
        cart.AddToCart(new Product("Eggs", 2.0));
        Assert.AreEqual(5, cart.GetCartSize());
    }
}
