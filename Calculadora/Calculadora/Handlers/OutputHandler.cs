using Calculadora.Domain;
using System.Text;

namespace Calculadora.Handlers
{
    public static class OutputHandler
    {
        public static string GetLastOperations(List<Operation> operations)
        {
            if(operations.Count == 0)
            {
                return "Não foram realizadas operações";
            }
            var toReturn = new StringBuilder();
            for (var i = 0; i < operations.Count; i++)
            {
                toReturn.AppendLine($"\n Operação {i + 1} \n N1: {operations[i].N1} \n N2: {operations[i].N2} \n Resultado: {operations[i].Result} \n\n");
            }

            return toReturn.ToString();
        }

        public static string GetOperationsMenu()
            => $"Qual operação você gostaria de realizar? \n\n  1-Soma \n 2-Subtração \n 3-Multiplicação, \n 4-Divisão \n 0- Últimas Operações \n S- Sair";

        public static string GetFirstNumberMessage()
        => "Por favor, digite o primeiro número: ";

        public static string GetSecondNumberMessage()
        => "Por favor, digite o segundo número: ";

        public static string GetWelcomeMessage()
        => "Bem-vindo(a)!";

        public static void Print(string toPrint) 
        {
            Console.Clear(); 
            Console.WriteLine(toPrint);
        }
    }
}
