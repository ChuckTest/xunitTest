using CalculatorLibrary;
using Xunit;
using Xunit.Abstractions;

namespace CalculatorTest
{
    public class CalculatorTest : TestBase
    {
        public CalculatorTest(ITestOutputHelper tempOutput) : base(tempOutput)
        {

        }

        [Theory]
        [InlineData(1, 2)]
        public void AddTest(int x, int y)
        {
            var result = Calculator.Add(x, y);
            Output.WriteLine($"{x}+{y}={result}");
            Assert.Equal(3, result);
        }
    }
}
