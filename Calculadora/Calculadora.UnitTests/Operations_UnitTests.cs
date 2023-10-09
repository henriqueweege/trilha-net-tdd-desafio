using Calculadora.Domain;

namespace Calculadora.UnitTests
{
    public class Operations_UnitTests
    {
        private readonly Operations _operations;
        public Operations_UnitTests()
        {
            _operations = new Operations();
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
            double result = _operations.Sum(n1, n2);

            //assert
            Assert.Equal(n1 + n2, result);
        }

        [Theory]
        [InlineData(11.586, 3.452)]
        [InlineData(106.9, 21.20)]
        [InlineData(1.69, 4.3)]
        [InlineData(135.9, 4.90)]
        [InlineData(-11.586, 3.452)]
        [InlineData(-106.9, 21.20)]
        [InlineData(-1.69, 4.3)]
        [InlineData(-135.9, 4.90)]
        [InlineData(11.586, -3.452)]
        [InlineData(106.9, -21.20)]
        [InlineData(1.69, -4.3)]
        [InlineData(135.9, -4.90)]
        public void GivenDoubleNumbers_Sum_ShouldReturnCorrectValue(double n1, double n2)
        {
            //arrange
            //act
            double result = _operations.Sum(n1, n2);

            //assert
            Assert.Equal(n1 + n2, result);
        }

        [Theory]
        [InlineData(11.586, 3452)]
        [InlineData(106.9, 21)]
        [InlineData(1.69, 46784)]
        [InlineData(135.9, 4)]
        [InlineData(-11.586, 3452)]
        [InlineData(-106.9, 21)]
        [InlineData(-1.69, 46784)]
        [InlineData(-135.9, 4)]
        [InlineData(11.586, -3452)]
        [InlineData(106.9, -21)]
        [InlineData(1.69, -46784)]
        [InlineData(135.9, -4)]
        public void GivenN1AsDoubleAndN2AsInteger_Sum_ShouldReturnCorrectValue(double n1, int n2)
        {
            //arrange

            //act
            double result = _operations.Sum(n1, n2);

            //assert
            Assert.Equal(n1 + n2, result);
        }

        [Theory]
        [InlineData(3452, 11.586)]
        [InlineData(21, 106.9)]
        [InlineData(46784, 1.69)]
        [InlineData(4, 135.9)]
        [InlineData(-3452, 11.586)]
        [InlineData(-21, 106.9)]
        [InlineData(-46784, 1.69)]
        [InlineData(-4, 135.9)]
        [InlineData(3452, -11.586)]
        [InlineData(21, -106.9)]
        [InlineData(46784, -1.69)]
        [InlineData(4, -135.9)]
        public void GivenN2AsDoubleAndN1AsInteger_Sum_ShouldReturnCorrectValue(int n1, double n2)
        {
            //arrange

            //act
            double result = _operations.Sum(n1, n2);

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
            double result = _operations.Subtraction(n1, n2);

            //assert
            Assert.Equal(n1 - n2, result);
        }

        [Theory]
        [InlineData(11.586, 3.452)]
        [InlineData(106.9, 21.20)]
        [InlineData(1.69, 4.3)]
        [InlineData(135.9, 4.90)]
        [InlineData(-11.586, 3.452)]
        [InlineData(-106.9, 21.20)]
        [InlineData(-1.69, 4.3)]
        [InlineData(-135.9, 4.90)]
        [InlineData(11.586, -3.452)]
        [InlineData(106.9, -21.20)]
        [InlineData(1.69, -4.3)]
        [InlineData(135.9, -4.90)]
        public void GivenDoubleNumbers_Subtraction_ShouldReturnCorrectValue(double n1, double n2)
        {
            //arrange
            //act
            double result = _operations.Subtraction(n1, n2);

            //assert
            Assert.Equal(n1 - n2, result);
        }

        [Theory]
        [InlineData(11.586, 3452)]
        [InlineData(106.9, 21)]
        [InlineData(1.69, 46784)]
        [InlineData(135.9, 4)]
        [InlineData(-11.586, 3452)]
        [InlineData(-106.9, 21)]
        [InlineData(-1.69, 46784)]
        [InlineData(-135.9, 4)]
        [InlineData(11.586, -3452)]
        [InlineData(106.9, -21)]
        [InlineData(1.69, -46784)]
        [InlineData(135.9, -4)]
        public void GivenN1AsDoubleAndN2AsInteger_Subtraction_ShouldReturnCorrectValue(double n1, int n2)
        {
            //arrange

            //act
            double result = _operations.Subtraction(n1, n2);

            //assert
            Assert.Equal(n1 - n2, result);
        }

        [Theory]
        [InlineData(3452, 11.586)]
        [InlineData(21, 106.9)]
        [InlineData(46784, 1.69)]
        [InlineData(4, 135.9)]
        [InlineData(-3452, 11.586)]
        [InlineData(-21, 106.9)]
        [InlineData(-46784, 1.69)]
        [InlineData(-4, 135.9)]
        [InlineData(3452, -11.586)]
        [InlineData(21, -106.9)]
        [InlineData(46784, -1.69)]
        [InlineData(4, -135.9)]
        public void GivenN2AsDoubleAndN1AsInteger_Subtraction_ShouldReturnCorrectValue(int n1, double n2)
        {
            //arrange

            //act
            double result = _operations.Subtraction(n1, n2);

            //assert
            Assert.Equal(n1 - n2, result);
        }


        #endregion
    }
}
