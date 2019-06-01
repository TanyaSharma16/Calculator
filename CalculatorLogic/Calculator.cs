using System;
using System.Resources;

namespace CalculatorLogic
{

    public class Calculator
    {
        public  ResourceManager resourceManager = new ResourceManager(typeof(Resources.ResourceEn));
        public  string langSelected = "English";

        public ConsoleColor color = ConsoleColor.White;
        /*
         Summary description missing
        */
        public double Sum(double a, double b)
        {
            getResourceManager();
            var x = a + b;
            Console.ForegroundColor = color;
            Console.WriteLine(resourceManager.GetString("ResultIs")+ $" {x}");
            return x;
        }
        /*
         Summary description missing
        */
        public double Subtract(double a, double b)
        {
            getResourceManager();
            var x = a - b;
            Console.ForegroundColor = color;
            Console.WriteLine(resourceManager.GetString("ResultIs") + $" {x}");
            return x;
        }
        /*
         Summary description missing
        */
        public double Multiply(double a, double b)
        {
            getResourceManager();
            var x = a * b;
            Console.ForegroundColor = color;
            Console.WriteLine(resourceManager.GetString("ResultIs") + $" {x}");
            return x;
        }
        /*
         Summary description missing
        */
        public double Divide(double a, double b)
        {
            getResourceManager();
            var x = a / b;
            Console.ForegroundColor = color;
            Console.WriteLine(resourceManager.GetString("ResultIs") + $" {x}");
            return x;
        }

        public void getResourceManager()
        {
            if (langSelected.Equals("French", StringComparison.CurrentCultureIgnoreCase))
                resourceManager = new ResourceManager(typeof(Resources.ResourceFr));
        }
    }
}
