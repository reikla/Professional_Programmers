using DemoMethods;

namespace TestDemoMethods;

public class CalculatorTests
{
    [Fact]
    public void Add_PositiveNumbers_HappyPath()
    {
        //Arrange
        var c = new Calculator();

        //Act
        var result = c.Add(4, 5);

        //Assert
        Assert.Equal(9, result);
    }

    [Fact]
    public void Subtract_PositiveNumbers_HappyPath()
    {
        // Arrange, Act
        var result = Calculator.Subtract(3, 1);
        
        //Assert
        Assert.Equal(2, result);
    }
}