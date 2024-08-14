using tdd_bobs_bagels.CSharp.Main;

namespace csharp_tdd_bobs_bagels.tests;

public class BobBagelsTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void AddBagelTest()
    {
        Basket basket = new Basket(5);
        bool result = basket.addBagel("b1");

        Assert.That(result, Is.True);
    }
}