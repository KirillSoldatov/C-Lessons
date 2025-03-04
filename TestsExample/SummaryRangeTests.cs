using HomeWorkProcedureProgram;

namespace TestsExample
{
    public class SummaryRangeTests
    {
        [Fact]
        public void Summary_Range_With_Zero_Value_Should_Be_Return_Zero_Array()
        {
            //Arrange
            int[] zeroIntArray = new int[0];
            string[] zeroStringArray = new string[0];
            //Act
            string[] summaryRange = Program.GetSummaryRange(zeroIntArray);
            //Assert
            Assert.Equal(zeroStringArray, summaryRange);
        }
        [Fact]
        public void Summary_Range_With_One_Value_Should_Be_Range_With_One_Element_Without_Range()
        {
            //Arrange
            int[] oneIntArray = new int[]{1};
            string[] oneStringArray = new string[]{"1"};
            //Act
            string[] summaryRange = Program.GetSummaryRange(oneIntArray);
            //Assert
            Assert.Equal(oneStringArray, summaryRange);
        }
        
        
    }
}
