using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("select an operation - add, subtract, divide, multiply: ");
            string operation = Console.ReadLine();

            Console.Write("first number: ");
            float number1 = Convert.ToInt16(Console.ReadLine());

            Console.Write("second number: ");
            float number2 = Convert.ToInt16(Console.ReadLine());

            switch(operation)
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
