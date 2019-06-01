using System;

namespace CalculatorLogic
{
    public class Calculator
    {
        public ConsoleColor color = ConsoleColor.White;
        /*
         Summary description of method missing
         Parameters description is missing
         Harcoded strings should be taken from resources file
        */
        public double Sum(double a, double b)
        {
            var x = a + b;
            Console.ForegroundColor = color;
            Console.WriteLine($"The result is: {x}");
            return x;
        }
        /*
         Summary description of method missing
         Parameters description is missing
         Harcoded strings should be taken from resources file
        */
        public double Subtract(double a, double b)
        {
            var x = a - b;
            Console.ForegroundColor = color;
            Console.WriteLine($"The result is: {x}");
            return x;
        }
        /*
         Summary description of method missing
         Parameters description is missing
         Harcoded strings should be taken from resources file
        */
        public double Multiply(double a, double b)
        {
            var x = a * b;
            Console.ForegroundColor = color;
            Console.WriteLine($"The result is: {x}");
            return x;
        }
        /*
          Summary description of method missing
          Parameters description is missing
          Harcoded strings should be taken from resources file
          divide by zero is not handled
         */
        public double Divide(double a, double b)
        {
            var x = a / b;
            Console.ForegroundColor = color;
            Console.WriteLine($"The result is: {x}");
            return x;
        }
    }
}
