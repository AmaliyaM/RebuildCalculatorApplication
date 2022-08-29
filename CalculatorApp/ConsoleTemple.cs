using System;
namespace CalculatorApp
{
     public class ConsoleTemple:IConsoleMock {
        string IConsoleMock.ReadLine()
        {
            return Console.ReadLine();
        }

        void IConsoleMock.WriteLine(string input)
        {
            Console.WriteLine(input);
        }

        void IConsoleMock.WriteLine(string input, params object[] args)
        {
            Console.WriteLine(input, args);
        }

        void IConsoleMock.Write(string input)
        {
            Console.WriteLine(input);
        }
    }
}

