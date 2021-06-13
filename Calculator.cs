using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("select an operation - add, subtract, divide, multiply: "); // the console text
            string operation = Console.ReadLine(); // read the operation from the console

            Console.Write("first number: "); // the first number
            float number1 = Convert.ToInt16(Console.ReadLine()); // convert the number to an 16 bit int

            Console.Write("second number: "); // the second number
            float number2 = Convert.ToInt16(Console.ReadLine()); // convert the number to an 16 bit int

            switch(operation) // switch operation: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/switch
            {
                case "add":
                    Console.WriteLine(number1 + number2);
                    break;

                case "subtract":
                    Console.WriteLine(number1 - number2);
                    break;

                case "divide":
                    Console.WriteLine(number1 / number2);
                    break;

                case "multiply":
                    Console.WriteLine(number1 * number2);
                    break;
            }
        }
    }
}
