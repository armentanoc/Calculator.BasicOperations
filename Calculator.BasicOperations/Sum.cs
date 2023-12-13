
namespace Calculator.BasicOperations
{
    internal class Sum
    {
        public static void Run(decimal number1, decimal number2)
        {
            decimal result = number1 + number2;
            Console.WriteLine($"O resultado da soma de {number1} por {number2} é: {result}");
        }
    }
}
