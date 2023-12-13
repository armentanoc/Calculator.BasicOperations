

namespace Calculator.BasicOperations
{
    internal class Multiply
    {
        public static void Run(decimal number1, decimal number2) 
        {
            decimal result = number1 * number2;
            Console.WriteLine($"O resultado da multiplicação de {number1} por {number2} é: {result}");
        }
    }
}
