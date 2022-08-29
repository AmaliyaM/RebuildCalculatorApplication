using System;
namespace CalculatorApp
{
    public interface IConsoleMock
    {
        void WriteLine(string input);
        void WriteLine(string input, params object[] args);
        void Write(string input);
        string ReadLine();

    }
}

