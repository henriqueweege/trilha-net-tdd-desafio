using Calculadora.Domain.Enum;

namespace Calculadora.Domain
{
    public class Operation
    {
        public int N1 { get; private set; }
        public int N2 { get; private set; }
        public int Result { get; private set; }
        public EOperationType Type { get; private set; }
        public Operation(int n1, int n2, EOperationType type)
        {
            N1 = n1;
            N2 = n2;
            switch (type)
            {
                case EOperationType.Sum:
                    Result = Sum(n1, n2);
                    break;
                case EOperationType.Subtraction:
                    Result = Subtraction(n1, n2);
                    break;
                case EOperationType.Multiplication:
                    Result = Multiplication(n1, n2);
                    break;
                case EOperationType.Division:
                    Result = Division(n1, n2);
                    break;
            }
            Type = type;
        }
        public Operation()
        {
            
        }
        public int Sum(int n1, int n2) => n1 + n2;
        public int Subtraction(int n1, int n2) => n1 - n2;
        public int Multiplication(int n1, int n2) => n1 * n2;
        public int Division(int n1, int n2) => n1 / n2;
    }
}
