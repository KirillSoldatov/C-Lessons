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
        [Fact]
        public void Summary_Range_With_Two_Values_Should_Be_Two_Elements_And_One_Range()
        {
            //Arrange
            int[] twoIntArray = new int[] { 1, 2 };
            string[] oneRangeStringArray = new string[] { "1 -> 2" };
            //Act
            string[] summaryRange = Program.GetSummaryRange(twoIntArray);
            //Assert
            Assert.Equal(oneRangeStringArray, summaryRange);
        }

        [Fact]
        public void Summary_Range_With_One_Value_In_Last_Range_Should_Be_Return_Ranges_And_Last_Element_Without_Range()
        {
            //Arrange
            int[] lastElementArray = new int[] { 1, 2, 4 };
            string[] rangeWithLastElementArray = new string[] { "1 -> 2", " 4"};
            //Act
            string[] summaryRange = Program.GetSummaryRange(lastElementArray);
            //Assert
            Assert.Equal(rangeWithLastElementArray, summaryRange);
        }

        [Fact]
        public void Summary_Range_With_Several_Values_In_Last_Range_Should_Be_Return_Ranges()
        {
            //Arrange
            int[] elementArray = new int[] { 1, 2, 4, 5 };
            string[] rangeElementArray = new string[] { "1 -> 2", " 4 -> 5" };
            //Act
            string[] summaryRange = Program.GetSummaryRange(elementArray);
            //Assert
            Assert.Equal(rangeElementArray, summaryRange);
        }

        [Fact]
        public void Shift_Zeros_With_One_Zero_At_Start_Of_Array_Should_Be_Return_Zero_At_End_Of_Array()
        {
            //Arrange
            int[] elementArray = new int[] { 0, 1, 2, 3, 4 };
            int[] zeroAtEndArray = new int[] { 1, 2, 3, 4, 0 };
            //Act
            int[] sortedElementArray = Program.ShiftZeros(elementArray);
            //Assert
            Assert.Equal(zeroAtEndArray, sortedElementArray);
        }
        
        [Fact]
        public void Shift_Zeros_With_One_Element_Array_Should_Be_Return_One_Element_Array()
        {
            //Arrange
            int[] elementArray = new int[] { 0 };
            int[] zeroAtEndArray = new int[] { 0 };
            //Act
            int[] sortedElementArray = Program.ShiftZeros(elementArray);
            //Assert
            Assert.Equal(zeroAtEndArray, sortedElementArray);
        }

        [Fact]
        public void Find_All_Disappeared_Nums_Upd_With_Missing_Nums_Should_Be_Return_Missing_Nums()
        {
            //Arrange
            int[] elementArray = new int[] { 4, 3, 2, 7, 8, 2, 3, 1 };
            int[] numsArray = new int[] { 5, 6 };
            //Act
            int[] missedNumsArray = Program.FindAllDisappearedNumsUpd(elementArray);
            //Assert
            Assert.Equal(numsArray, missedNumsArray);
        }
    }
}
