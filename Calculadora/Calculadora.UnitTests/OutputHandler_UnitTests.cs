using Calculadora.Domain;
using Calculadora.Handlers;

namespace Calculadora.UnitTests
{
    public class OutputHandler_UnitTests
    {
        private readonly OutputHandler _outputHandler;

        public OutputHandler_UnitTests()
        {
            _outputHandler = new ();
        }

        [Fact]
        public void GivenCallTo_GetOperationsMenu_ShouldContainOperations()
        {
            //arrange 
            var sum = "Soma";
            var subtraction = "Subtração";
            var division = "Divisão";
            var multiplication = "Multiplicação";

            //act
            string menu = _outputHandler.GetOperationsMenu();

            //assert
            Assert.Contains(sum, menu);
            Assert.Contains(subtraction, menu);
            Assert.Contains(division, menu);
            Assert.Contains(multiplication, menu);
        }

        [Fact]
        public void GivenCallTo_GetLastOperations_ShouldContainOperations()
        {
            //arrange 
            var operations = new List<Operation>();
            operations.Add(new(1, 2, Domain.Enum.EOperationType.Sum));
            operations.Add(new(2, 3, Domain.Enum.EOperationType.Subtraction));
            operations.Add(new(3, 4, Domain.Enum.EOperationType.Multiplication));

            //act
            string lastOperations = _outputHandler.GetLastOperations(operations);

            //assert
            Assert.Contains("Operação 1", lastOperations);
            Assert.Contains("N1: 1", lastOperations);
            Assert.Contains("N2: 2", lastOperations);
            Assert.Contains("Resultado: 3", lastOperations);
            Assert.Contains("Operação 2", lastOperations);
            Assert.Contains("N1: 2", lastOperations );
            Assert.Contains("N2: 3", lastOperations );
            Assert.Contains("Resultado: -1", lastOperations     );
            Assert.Contains("Operação 3", lastOperations);
            Assert.Contains("N1: 3", lastOperations);
            Assert.Contains("N2: 4", lastOperations);
            Assert.Contains("Resultado: 12", lastOperations);
        }




    }
}
