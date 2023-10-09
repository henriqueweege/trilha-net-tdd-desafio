namespace Calculadora.Domain
{
    public class Operations
    {
        public int N1 { get; set; }
        public int N2 { get; set; }
        public int Result { get; set; }
        public string Operation { get; set; }
        public Operations(int n1, int n2, int result, string operation)
        {
            N1 = n1;
            N2 = n2;
            Operation = operation;
        }
        public Operations()
        {
            
        }
        public int Sum(int n1, int n2) => n1 + n2;
        public int Subtraction(int n1, int n2) => n1 - n2;
        public int Multiplication(int n1, int n2) => n1 * n2;
        public int Division(int n1, int n2) => n1 / n2;
    }
}
