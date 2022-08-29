using System;

namespace CalculatorApp
{

    public class Program
    {
        public IConsoleMock CurrentConsole = new ConsoleTemple();
        public static void Main()
        {
            Program currentProgram = new Program();
            currentProgram.StartCalculation();
        }

        public void StartCalculation()
        {
            bool endApp = false;
            // Display title as the C# console calculator app.
            CurrentConsole.WriteLine("Console Calculator in C#\r");
            CurrentConsole.WriteLine("------------------------\n");

            while (!endApp)
            {
                // Declare variables and set to empty.
                string numInput1 = "";
                string numInput2 = "";
                double result = 0;

                // Ask the user to type the first number.
                CurrentConsole.Write("Type a number, and then press Enter: ");
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    CurrentConsole.Write("This is not valid input. Please enter an integer value: ");
                    numInput1 = Console.ReadLine();
                }

                // Ask the user to type the second number.
                CurrentConsole.Write("Type another number, and then press Enter: ");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    CurrentConsole.Write("This is not valid input. Please enter an integer value: ");
                    numInput2 = CurrentConsole.ReadLine();
                }

                // Ask the user to choose an operator.
                CurrentConsole.WriteLine("Choose an operator from the following list:");
                CurrentConsole.WriteLine("\ta - Add");
                CurrentConsole.WriteLine("\ts - Subtract");
                CurrentConsole.WriteLine("\tm - Multiply");
                CurrentConsole.WriteLine("\td - Divide");
                CurrentConsole.Write("Your option? ");

                string op = CurrentConsole.ReadLine();

                try
                {
                    result = CalculatorClass.DoOperation(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        CurrentConsole.WriteLine("This operation will result in a mathematical error.\n");
                    }
                    else CurrentConsole.WriteLine("Your result: {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    CurrentConsole.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
                }

                CurrentConsole.WriteLine("------------------------\n");

                // Wait for the user to respond before closing.
                CurrentConsole.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                if (CurrentConsole.ReadLine() == "n") endApp = true;

                CurrentConsole.WriteLine("\n"); // Friendly linespacing.
            }


            return;
        }
    }
}