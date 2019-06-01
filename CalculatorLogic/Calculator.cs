using System;
using System.Resources;

namespace CalculatorLogic
{

    /*
     * Class Calculator inherits interface ICalculator
     */
    public class Calculator : ICalculator
    {
        public ResourceManager resourceManager = new ResourceManager(typeof(Resources.ResourceEn));
        public string langSelected = "English";

        public ConsoleColor color = ConsoleColor.White;
        /*
         Summary description of method missing
         Parameters description is missing
         Harcoded strings should be taken from resources file
        */
        public double Sum(double a, double b)
        {
            getResourceManager();
            var x = a + b;
            Console.ForegroundColor = color;
            Console.WriteLine(resourceManager.GetString("ResultIs") + $" {x}");
            return x;
        }
        /*
         Summary description of method missing
         Parameters description is missing
         Harcoded strings should be taken from resources file
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
         Summary description of method missing
         Parameters description is missing
         Harcoded strings should be taken from resources file
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
          Summary description of method missing
          Parameters description is missing
          Harcoded strings should be taken from resources file
          divide by zero is not handled
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
