using CalculatorLibrary;
using Xunit;

namespace CalculatorTest
{
    public class CalculatorTest
    {
        [Theory]
        [InlineData(1,2)]
        public void AddTest(int x,int y)
        {
            Assert.Equal(3,Calculator.Add(x,y));
        }
    }
}
