using DemoMethods;

namespace TestDemoMethods;

public class CalculatorTests
{
    [Fact]
    public void Add_PositiveNumbers_HappyPath()
    {
        var c = new Calculator();

        var result = c.Add(4, 5);

        Assert.Equal(9, result);
    }

    [Fact]
    public void Subtract_PositiveNumbers_HappyPath()
    {
        var result = Calculator.Subtract(3, 1);
        Assert.Equal(2, result);
    }
}