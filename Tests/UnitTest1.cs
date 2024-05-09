using net_calculator_tester;
using NUnit.Framework;

namespace Tests;

[TestFixture]
public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestAdd()
    {
        float somma = Calculator.Add(1, 2);
        if (somma == 3)
            Assert.Pass();
        Assert.Fail($"La somma dovrebbe essere 3, invece è {somma}");
    }

    [Test]
    public void TestSubtraction()
    {
        float diff = Calculator.Subtract(10, 5);
        if(diff == 5) 
            Assert.Pass();
        Assert.Fail($"La differenza dovrebbe essere 5, invece è {diff}");
    }

    [Test]
    public void TestDivision()
    {
        float quoz;
        float divisore = 0;
        try
        {
            quoz = Calculator.Divide(10, divisore);
        }
        catch (Exception ex)
        {
            if (divisore == 0)
                Assert.Pass();

            Assert.Fail(ex.Message);
        }
        
        if (Calculator.Divide(10, divisore) == 10/divisore)
            Assert.Pass();
        Assert.Fail("Il risultato non è corretto");      
    }

    [Test]
    public void TestMultiply()
    {
        float prod = Calculator.Multiply(2, 5);
        if (prod == 10)
            Assert.Pass();
        Assert.Fail($"Il prodotto dovrebbe essere 10, invece è {prod}");
    }
}