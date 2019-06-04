using CalculatorLogic;
using Xunit;

namespace CalculatorTest
{
    public class UnitTest1
    {
        /*
        Description, Summary of parametrs missing
        Incorrect: should be Assert.Equal(3, x);
         */
        [Fact]
        public void ShouldAddTwoNumbers()
        {
            var x = new Calculator().Sum(1, 2);
            Assert.Equal(x, 3);
        }

        /*
       Description, Summary of parametrs missing
        */
        [Fact]
        public void ShouldMultiplyTwoNumbers()
        {
            var x = new Calculator().Multiply(3, 2);
            Assert.Equal(6, x);
        }
    }
}
