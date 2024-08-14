global using NUnit.Framework;
using tdd_bobs_bagels.CSharp.Main;

namespace csharp_tdd_bobs_bagels.tests;

public class BobBagelsTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase("b1", 5, true)]
    [TestCase("b2", 1, false)]
    public void AddBagelTest(string a, int b, bool c)
    {
        Basket basket = new Basket(b);

        basket.addBagel("b0");
        bool result = basket.addBagel(a);
        Assert.That(result, Is.EqualTo(c));
    }

    [TestCase("b1", true)]
    [TestCase("b2", false)]
    public void RemoveBagelTest(string a, bool b)
    {
        Basket basket = new Basket(5);

        basket.addBagel("b1");
        bool result = basket.removeBagel(a);
        Assert.That(result, Is.EqualTo(b));
    }

    [TestCase(1)]
    [TestCase(100)]
    [TestCase(-5)]
    public void ChangeCapacityTest(int a)
    {
        Basket basket = new Basket(0);

        basket.changeCapacity(a);
        Assert.That(basket.capacity, Is.EqualTo(a));
    }

}