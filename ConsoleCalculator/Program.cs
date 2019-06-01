using System;
using System.Linq;
using CalculatorLogic;
using System.Resources;
using System.Globalization;
using System.Reflection;
using ConsoleCalculator.Resources;

namespace ConsoleCalculator
{
    class Program
    {
        static ResourceManager resourceManager = new ResourceManager(typeof(Resources.ResourceEn));
        static void Main()
        {
            var calculator = new Calculator();
            Console.Write("Please select the language from the following options:\nEnglish \nFrench ");
           calculator.langSelected = Console.ReadLine();
        
            if(calculator.langSelected.Equals("French",StringComparison.CurrentCultureIgnoreCase))
                resourceManager = new ResourceManager(typeof(Resources.ResourceFr));
           
            Console.Write(resourceManager.GetString("InputForOperation"));
            var result = Console.ReadLine();
            
            Console.Write(resourceManager.GetString("SelectFirstOperand"));
            var n1 = Console.ReadLine();

            Console.Write(resourceManager.GetString("SelectSecondOperand"));
            var n2 = Console.ReadLine();

            Console.WriteLine(resourceManager.GetString("SelectColor"));
            var colorSelected = Console.ReadLine();
           
            switch (colorSelected)
            {
                case "1":
                    calculator.color = ConsoleColor.Red;
                        break;
                case "2":
                    calculator.color = ConsoleColor.Blue;
                    break;
                case "3":
                    calculator.color = ConsoleColor.Green;
                    break;
                case "4":
                    calculator.color = ConsoleColor.Yellow;
                    break;
                default:
                    calculator.color = ConsoleColor.White;
                    break;


            }
            /*
             if-else statements should be changed to switch statement
             */
            if (result.Equals("sum",StringComparison.CurrentCultureIgnoreCase) || result.Equals("somme",StringComparison.CurrentCultureIgnoreCase))
                calculator.Sum(Convert.ToDouble(n1), Convert.ToDouble(n2));
            else
            {
                if (result.Equals("subtract",StringComparison.CurrentCultureIgnoreCase) || result.Equals("soustraction", StringComparison.CurrentCultureIgnoreCase))
                    calculator.Subtract(Convert.ToDouble(n1), Convert.ToDouble(n2));
                else
                {
                    if (result.Equals("multiply", StringComparison.CurrentCultureIgnoreCase) || result.Equals("multiplication", StringComparison.CurrentCultureIgnoreCase))
                        calculator.Multiply(Convert.ToDouble(n1), Convert.ToDouble(n2));
                    else
                    {
                        if (result.Equals("divide", StringComparison.CurrentCultureIgnoreCase) || result.Equals("division", StringComparison.CurrentCultureIgnoreCase))
                            calculator.Divide(Convert.ToDouble(n1), Convert.ToDouble(n2));
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
