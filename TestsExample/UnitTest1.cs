using CheckPointProcedureProgramming;

namespace TestsExample
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Program.GetSummaryRanges([1, 2, 4, 6, 7, 9]);
        }
    }
}
