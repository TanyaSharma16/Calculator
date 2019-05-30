using System;
using System.Linq;
using CalculatorLogic;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main()
        {
            Console.Write("Type the operation you want to execute (sum, subtract, multiply, divide): ... ");
            var result = Console.ReadLine();

            Console.Write("Please type the first operand: ");
            var n1 = Console.ReadLine();

            Console.Write("Now, Please type the second operand: ");
            var n2 = Console.ReadLine();

            Console.WriteLine("Please choose the color of results from the following options:\n Red\n Blue\n Green\n Yellow");
            var colorSelected = Console.ReadLine();
            var calculator = new Calculator();
            switch (colorSelected)
            {
                case "Red":
                    calculator.color = ConsoleColor.Red;
                        break;
                case "Blue":
                    calculator.color = ConsoleColor.Blue;
                    break;
                case "Green":
                    calculator.color = ConsoleColor.Green;
                    break;
                case "Yellow":
                    calculator.color = ConsoleColor.Yellow;
                    break;
                default:
                    calculator.color = ConsoleColor.White;
                    break;


            }
            /*
             if-else statements should be changed to switch statement
             */
            if (result == "sum")
                calculator.Sum(Convert.ToDouble(n1), Convert.ToDouble(n2));
            else
            {
                if (result == "subtract")
                    calculator.Subtract(Convert.ToDouble(n1), Convert.ToDouble(n2));
                else
                {
                    if (result == "multiply")
                        calculator.Multiply(Convert.ToDouble(n1), Convert.ToDouble(n2));
                    else
                    {
                        if (result == "divide")
                            calculator.Divide(Convert.ToDouble(n1), Convert.ToDouble(n2));
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
