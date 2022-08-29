using CalculatorApp;
using System.Text.RegularExpressions;
namespace CalculatorApp.Test;


public class CalculatorStringTest
{

    [Fact]
    public void DoesProgramWorkWithRightValues()
    {
        Program program = new();
        var output = new StringWriter();
        Console.SetOut(output);
        var input = new StringReader(@"6
7
m
n");
        Console.SetIn(input);
        program.StartCalculation();

        var expected =
                "Console Calculator in C#" +
                "------------------------" +
                "Type a number, and then press Enter: " +
                "Type another number, and then press Enter: " +
                "Choose an operator from the following list:" +
                "a - Add" +
                "s - Subtract" +
                "m - Multiply" +
                "d - Divide" +
                "Your option? " +
                "Your result: 42" +
                "------------------------" +
                "Press 'n' and Enter to close the app, or press any other key and Enter to continue: ";
        Assert.Equal(expected, Regex.Replace(output.ToString(), @"[\r\t\n]+", string.Empty));
    }


    [Fact]
    public void DoesProgramWorkWithBadValues()
    {
        Program program = new();
        var output = new StringWriter();
        Console.SetOut(output);
        var input = new StringReader(@"6
0
d
n");
        Console.SetIn(input);
        program.StartCalculation();

        var expected =
                "Console Calculator in C#" +
                                 "------------------------" +
                                 "Type a number, and then press Enter: " +
                                 "Type another number, and then press Enter: " +
                                 "Choose an operator from the following list:" +
                                 "a - Add" +
                                 "s - Subtract" +
                                 "m - Multiply" +
                                 "d - Divide" +
                                 "Your option? " +
                                 "This operation will result in a mathematical error." +
                                 "------------------------" +
                                 "Press 'n' and Enter to close the app, or press any other key and Enter to continue: ";
        Assert.Equal(expected, Regex.Replace(output.ToString(), @"[\r\t\n]+", string.Empty));
    }


}

