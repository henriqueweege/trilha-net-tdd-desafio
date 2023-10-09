using Calculadora.Domain;

namespace Calculadora.UnitTests
{
    public class Operation_UnitTests
    {

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
            var op = new Operation(n1, n2, Domain.Enum.EOperationType.Sum);

            //assert
            Assert.Equal(n1 + n2, op.Result);
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
            var op = new Operation(n1, n2, Domain.Enum.EOperationType.Subtraction);

            //assert
            Assert.Equal(n1 - n2, op.Result);
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
            var op = new Operation(n1, n2, Domain.Enum.EOperationType.Multiplication);

            //assert
            Assert.Equal(n1 * n2, op.Result);
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
            var op = new Operation(n1, n2, Domain.Enum.EOperationType.Division);

            //assert
            Assert.Equal(n1 / n2, op.Result);
        }
        #endregion
    }
}
