using Calculadora.Handlers;

namespace Calculadora.UnitTests
{
    public class Menu_UnitTests
    {
        private MenuHandler _menuHandler;
        public Menu_UnitTests()
        {
            _menuHandler = new MenuHandler();
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
            string menu = _menuHandler.GetOperationsMenu();

            //assert
            Assert.Contains(sum, menu);
            Assert.Contains(subtraction, menu);
            Assert.Contains(division, menu);
            Assert.Contains(multiplication, menu);
        }

    }
}
