using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.BasicOperations
{
    internal class Subtraction
    {
        public static void Run(decimal number1, decimal number2)
        {
            decimal result = number1 - number2;
            Console.WriteLine($"O resultado da subtração de {number1} por {number2} é: {result}");
        }
    }
}
