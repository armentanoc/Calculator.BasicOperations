using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.BasicOperations
{
    public class Division
    {
        public static void Run(decimal number1, decimal number2)
        {
            if(number1 < number2 || number2 == 0)
            {
                Console.WriteLine("Não é possível realizar essa divisão");
            }
            else
            {
                Console.WriteLine($"A divisão de {number1} por {number2} é igual a:{number1/number2}");
            }
        }
    }
}
