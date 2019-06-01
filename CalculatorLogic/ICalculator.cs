using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLogic
{
    public interface ICalculator
    {
        /*
         * define all methods of operations here
         */
        double Sum(double a, double b);
        double Subtract(double a, double b);
        double Multiply(double a, double b);
        double Divide(double a, double b);


    }
}
