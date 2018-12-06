using Xunit.Abstractions;

namespace CalculatorTest
{
    public class TestBase
    {
        protected readonly ITestOutputHelper Output;

        public TestBase(ITestOutputHelper tempOutput)
        {
            Output = tempOutput;
        }
    }
}
