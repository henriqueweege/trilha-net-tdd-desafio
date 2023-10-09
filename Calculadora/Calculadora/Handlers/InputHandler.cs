using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Handlers
{
    public static class InputHandler
    {
        public static (int, int) GetNumbers()
        {
            OutputHandler.Print(OutputHandler.GetFirstNumberMessage());
            var n1 = Console.ReadLine();
            if (int.TryParse(n1, out int n1Int))
            {
                OutputHandler.Print(OutputHandler.GetSecondNumberMessage());
                var n2 = Console.ReadLine();
                if(int.TryParse(n1, out int n2Int))
                {
                    return (n1Int, n2Int);
                }
            }
            throw new ArgumentException("Apenas números inteiros podem ser utilizados como input para as operações.");
        }
    }
}
