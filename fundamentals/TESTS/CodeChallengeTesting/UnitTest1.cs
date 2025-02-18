using CodeChallenge;
using Xunit;
using Xunit.Sdk;

namespace CodeChallengeTesting
{
    public class UnitTest1
    {
        [Fact]
        public void sortedArray()
        {

            int[] array = { 2, 5, 1, 3, 4 };
            int[] expectedArray = { 1, 2, 3, 4, 5 };
            int[] result = NumberProcessor.SortArray(array);

            Assert.Equal(expectedArray, result);
        }

        [Fact]
        public void calculateSumOfAnArray15()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int expectedResult = 15;
            int result = NumberProcessor.FindSum(array);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void calculatedSumOfAnArray10()
        {
            int[] array = { 1, 2, 3, 4, 0 };
            int expectedResult = 10;
            int result = NumberProcessor.FindSum(array);
            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void FindSumNullArray()
        {
            int[] emptyArray = null;
            var result = Assert.Throws<ArgumentException>(() => NumberProcessor.FindMax(emptyArray));


            Assert.Equal("Array cannot be null or empty", result.Message);
        }

        [Fact]
        public void FindSumEmptyArray()
        {
            try
            {
                int[] emptyArray =new int[0];
                NumberProcessor.FindMax(emptyArray);
            }
            catch (System.Exception ex)
            {
                Assert.Equal("Array cannot be null or empty", ex.Message);
            }
        }

        [Fact]
        public void IsEvenWorkingRight()
        {
            int number = 2;
            bool result = NumberProcessor.IsEven(number);
            Assert.True(result);
            
        }

        [Fact]
        public void IsEvenWorkingLeft()
        {
            int number = 3;
            bool result = NumberProcessor.IsEven(number);
            Assert.False(result);
        }
    }
}