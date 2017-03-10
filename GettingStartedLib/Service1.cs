using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GettingStartedLib
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class CalculatorServce: ICalculator
    {
        double ICalculator.add(double n1, double n2)
        {
            double result = n1 + n2;
            Console.WriteLine("Recieved Add ({0},{1})", n1, n2);
            Console.WriteLine("Return : {0}", result);
            return result;
        }
        double ICalculator.multiply(double n1, double n2)
        {
            double result = n1 * n2;
            Console.WriteLine("Recieved Multiply({0},{1})", n1,n2);
            Console.WriteLine("Return: {0}", result);
            return result;
        }
        double ICalculator.divide(double n1, double n2)
        {
            double result = n1 / n2;
            Console.WriteLine("Recieved Divide({0},{1})", n1, n2);
            Console.WriteLine("Return: {0}", result);
            return result;
        }
        double ICalculator.subtract(double n1, double n2)
        {
            double result = n1 - n2;
            Console.WriteLine("Recieved Subtract({0},{1})", n1, n2);
            Console.WriteLine("Return: {0}", result);
            return result;
        }
    }
}
