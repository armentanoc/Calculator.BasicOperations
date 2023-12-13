namespace Calculator.BasicOperations
{
    using ConsoleMenuLibrary;
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] opcoesOperador = {"Soma", "Subtração", "Multiplicação", "Divisão"};
            var opcoes = new ConsoleMenu(opcoesOperador);
            int selecaoUsuario = opcoes.ShowMenu();

            Console.WriteLine("Informe dois números para a operação");
            decimal number1;
            decimal number2;
            do
            {
                Console.WriteLine("Informe o primeiro número!");
            } while (!decimal.TryParse(Console.ReadLine(), out number1));

            do
            {
                Console.WriteLine("Informe o segundo número!");
            } while (!decimal.TryParse(Console.ReadLine(), out number2));

            switch (selecaoUsuario)
            {
                case 0:
                    Sum.Run(number1, number2);
                        break;
                case 1:
                    Subtraction.Run(number1, number2);
                    break;
                case 2:
                    Multiply.Run(number1, number2);
                    break;
                case 3:
                    Division.Run(number1, number2);
                    break;
                default: 
                    Console.WriteLine("Seleção errada!");
                    break;
            }
        }
    }
}
