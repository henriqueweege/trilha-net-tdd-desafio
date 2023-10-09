using Calculadora.Domain;
using Calculadora.Handlers;

namespace Calculadora.UnitTests
{
    public class CacheHandler_UnitTests
    {
        private readonly CacheHandler _cache;
        public CacheHandler_UnitTests()
        {
            _cache = new ();
        }

        [Fact]
        public void GivenOperationToSave_CacheHandler_ShouldSave()
        {
            //arrange
            var opToSave = new Operation();

            //act
            _cache.Save(opToSave);

            //assert
            Assert.True(_cache.Operations.Count > 0);

        }

        [Fact]
        public void Given3OperationSaved_CacheHandler_ShouldSave()
        {
            //arrange
            var opToSave1 = new Operation(1,2,Domain.Enum.EOperationType.Sum);
            var opToSave2 = new Operation(2,3,Domain.Enum.EOperationType.Sum);
            var opToSave3 = new Operation(3,4,Domain.Enum.EOperationType.Sum);

            //act
            _cache.Save(opToSave1);
            _cache.Save(opToSave2);
            _cache.Save(opToSave3);

            //assert
            Assert.True(_cache.Operations.Count == 3);
            var op1 = _cache.Operations[0];
            var op2 = _cache.Operations[1];
            var op3 = _cache.Operations[2];
            Assert.Equal(opToSave1, op1);
            Assert.Equal(opToSave2, op2);
            Assert.Equal(opToSave3, op3);
        }

        [Fact]
        public void Given4OperationSaved_CacheHandler_ShouldSave3()
        {
            //arrange
            var opToSave0 = new Operation(0, 1, Domain.Enum.EOperationType.Sum);
            var opToSave1 = new Operation(1, 2, Domain.Enum.EOperationType.Sum);
            var opToSave2 = new Operation(2, 3, Domain.Enum.EOperationType.Sum);
            var opToSave3 = new Operation(3, 4, Domain.Enum.EOperationType.Sum);

            //act
            _cache.Save(opToSave0);
            _cache.Save(opToSave1);
            _cache.Save(opToSave2);
            _cache.Save(opToSave3);

            //assert
            Assert.True(_cache.Operations.Count == 3);
            var op1 = _cache.Operations[0];
            var op2 = _cache.Operations[1];
            var op3 = _cache.Operations[2];
            Assert.Equal(opToSave1, op1);
            Assert.Equal(opToSave2, op2);
            Assert.Equal(opToSave3, op3);
        }


    }
}
