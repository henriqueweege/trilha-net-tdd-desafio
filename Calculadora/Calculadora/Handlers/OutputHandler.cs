using Calculadora.Domain;
using System.Text;

namespace Calculadora.Handlers
{
    public class OutputHandler
    {
        public string GetLastOperations(List<Operation> operations)
        {
            var toReturn = new StringBuilder();
            for(var i =0; i < operations.Count; i++)
            {
                toReturn.AppendLine($"\n Operação {i + 1} \n N1: {operations[i].N1} \n N2: {operations[i].N2} \n Resultado: {operations[i].Result} \n\n");
            }

            return toReturn.ToString();
        }

        public string GetOperationsMenu()
            => $"Qual operação você gostaria de realizar? \n\n  1-Soma \n 2-Subtração \n 3-Multiplicação, \n 4-Divisão";
        
    }
}
