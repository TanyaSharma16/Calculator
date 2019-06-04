using CalculatorLogic;
using Xunit;

namespace CalculatorTest
{
    public class UnitTest1
    {
        [Fact]
        public void ShouldAddTwoNumbers()
        {
            var x = new Calculator().Sum(1, 2);
            Assert.Equal(3, x);
        }

        public void addTestWrongOutput()
        {
            var x = new Calculator().Sum(1, 2);
            Assert.Equal(10, x);
        }

        [Fact]
        public void ShouldMultiplyTwoNumbers()
        {
            var x = new Calculator().Multiply(3, 2);
            Assert.Equal(6, x);
        }
        [Fact]
        public void mulTestWithRange()
        {
            var x = new Calculator().Multiply(3, 2);
            Assert.NotInRange(x,2,3);
        }
        [Fact]
        public void subTest()
        {
            var x = new Calculator().Subtract(7, 2);
            Assert.Equal(5, x);
        }
        [Fact]
        public void subTestWrongOutput()
        {
            var x = new Calculator().Subtract(7, 2);
            Assert.NotEqual(7, x);
        }
        [Fact]
        public void divideTest()
        {
            var x = new Calculator().Divide(8, 2);
            Assert.Equal(4, x);
        }
        [Fact]
        public void divideTestWrongOutput()
        {
            var x = new Calculator().Divide(8, 2);
            Assert.NotEqual(3, x);
        }
    }
}
