using CalculatorApp;
namespace CalculatorApp.Test;


public class CalculatorTest
{
    CalculatorClass calc = new CalculatorClass();
    [Fact]
    public void DoesAdditionWork()
    {
        Assert.Equal(12, CalculatorClass.DoOperation(7, 5, "a"));
    }

    [Fact]
    public void DoesSubstractionWork()
    {
        Assert.Equal(12, CalculatorClass.DoOperation(16, 4, "s"));
    }

    [Fact]
    public void DoesMultiplyWork()
    {
        Assert.Equal(12, CalculatorClass.DoOperation(2, 6, "m"));
    }

    [Fact]
    public void DoesdivisionWork()
    {
        Assert.Equal(2, CalculatorClass.DoOperation(12, 6, "d"));
    }

    [Fact]
    public void DoesNotNotWorkDivision()
    {
        Assert.Equal(Double.NaN, CalculatorClass.DoOperation(2, 0, "d"));
    }

    [Fact]
    public void DoesNotNotWorkOperation1()
    {
        Assert.Equal(Double.NaN, CalculatorClass.DoOperation(5, 1, "ma"));
    }

    [Fact]
    public void DoesNotNotWorkOperation2()
    {
        Assert.Equal(Double.NaN, CalculatorClass.DoOperation(1, 3, ""));
    }
}
