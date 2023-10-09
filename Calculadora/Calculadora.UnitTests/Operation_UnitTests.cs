using Calculadora.Domain;

namespace Calculadora.UnitTests
{
    public class Operation_UnitTests
    {
        private readonly Operation _operations;
        public Operation_UnitTests()
        {
            _operations = new Operation();
        }

        #region Sum

        [Theory]
        [InlineData(1, 2)]
        [InlineData(10, 20)]
        [InlineData(19, 4)]
        [InlineData(1359, 490)]
        [InlineData(-1, 2)]
        [InlineData(-10, 20)]
        [InlineData(-19, 4)]
        [InlineData(-1359, 490)]
        [InlineData(1, -2)]
        [InlineData(10, -20)]
        [InlineData(19, -4)]
        [InlineData(1359, -490)]
        public void GivenIntegerNumbers_Sum_ShouldReturnCorrectValue(int n1, int n2)
        {
            //arrange
            //act
            var result = _operations.Sum(n1, n2);

            //assert
            Assert.Equal(n1 + n2, result);
        }

    
        #endregion

        #region Subtraction

        [Theory]
        [InlineData(1, 2)]
        [InlineData(10, 20)]
        [InlineData(19, 4)]
        [InlineData(1359, 490)]
        [InlineData(-1, 2)]
        [InlineData(-10, 20)]
        [InlineData(-19, 4)]
        [InlineData(-1359, 490)]
        [InlineData(1, -2)]
        [InlineData(10, -20)]
        [InlineData(19, -4)]
        [InlineData(1359, -490)]
        public void GivenIntegerNumbers_Subtraction_ShouldReturnCorrectValue(int n1, int n2)
        {
            //arrange
            //act
            var result = _operations.Subtraction(n1, n2);

            //assert
            Assert.Equal(n1 - n2, result);
        }

       
        #endregion

        #region Multiplication

        [Theory]
        [InlineData(1, 2)]
        [InlineData(10, 20)]
        [InlineData(19, 4)]
        [InlineData(1359, 490)]
        [InlineData(-1, 2)]
        [InlineData(-10, 20)]
        [InlineData(-19, 4)]
        [InlineData(-1359, 490)]
        [InlineData(1, -2)]
        [InlineData(10, -20)]
        [InlineData(19, -4)]
        [InlineData(1359, -490)]
        public void GivenIntegerNumbers_Multiplication_ShouldReturnCorrectValue(int n1, int n2)
        {
            //arrange
            //act
            var result = _operations.Multiplication(n1, n2);

            //assert
            Assert.Equal(n1 * n2, result);
        }

        #endregion

        #region Division

        [Theory]
        [InlineData(1, 2)]
        [InlineData(10, 20)]
        [InlineData(19, 4)]
        [InlineData(1359, 490)]
        [InlineData(-1, 2)]
        [InlineData(-10, 20)]
        [InlineData(-19, 4)]
        [InlineData(-1359, 490)]
        [InlineData(1, -2)]
        [InlineData(10, -20)]
        [InlineData(19, -4)]
        [InlineData(1359, -490)]
        public void GivenIntegerNumbers_Division_ShouldReturnCorrectValue(int n1, int n2)
        {
            //arrange
            //act
            var result = _operations.Division(n1, n2);

            //assert
            Assert.Equal(n1 / n2, result);

        }
        #endregion
    }
}
