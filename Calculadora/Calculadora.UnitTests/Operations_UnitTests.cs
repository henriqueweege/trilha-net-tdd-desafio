using Calculadora.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.UnitTests
{
    public class Operations_UnitTests
    {
        private readonly Operations _operations;
        public Operations_UnitTests()
        {
            _operations = new Operations(); 
        }

        [Fact]
        public void GivenIntegerNumber_Sum_ShouldReturnCorrectValue()
        {
            //arrange
            var n1 = 1;
            var n2 = 2;

            //act
            int result = _operations.Sum(n1, n2);

            //assert
            Assert.Equal(n1 + n2, result);
        }
    }
}
