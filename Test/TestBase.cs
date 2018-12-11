using Xunit.Abstractions;

namespace Test
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
