using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestMaximumUsingGenerics;
namespace MaxNumberTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// TC1.1 When Three integers are given to the method and largest number among all numbers is at position 1st, this test case should pass
        /// </summary>
        /// <param name="firstValue">firstValue will be maximum of all three integer values</param>
        /// <param name="secondValue">secondValue contain interge value</param>
        /// <param name="thirdValue">thirdValue  contain interge value</param>
        [TestMethod]
        [DataRow(543,453,332)]
        public void GivenThreeIntegers_WhenMaxIntegerAtPositionOne_ShouldReturnThatValue(int firstValue, int secondValue, int thirdValue)
        {
            int expectedResult = firstValue;
            int result = FindMaximumNumber.FindMaxIntNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expectedResult, result);
        }

        /// <summary>
        /// TC1.2 When Three integers are given to the method and largest number among all numbers is at position 2nd, this test case should pass
        /// </summary>
        /// <param name="firstValue">firstValue will contain interge value</param>
        /// <param name="secondValue">secondValue will be maximum of all three integer values</param>
        /// <param name="thirdValue">thirdValue  contain interge value</param>
        [TestMethod]
        [DataRow(223, 3453, 432)]
        public void GivenThreeIntegers_WhenMaxIntegerAtPositionTwo_ShouldReturnThatValue(int firstValue, int secondValue, int thirdValue)
        {
            int expectedResult = secondValue;
            int result = FindMaximumNumber.FindMaxIntNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expectedResult, result);
        }

        /// <summary>
        /// TC1.3 When Three integers are given to the method and largest number among all numbers is at position 3rd, this test case should pass
        /// </summary>
        /// <param name="firstValue">firstValue contain interge value</param>
        /// <param name="secondValue">secondValue contain interge value</param>
        /// <param name="thirdValue">thirdValue will be maximum of all three integer values </param>
        [TestMethod]
        [DataRow(533, 353, 832)]
        public void GivenThreeIntegers_WhenMaxIntegerAtPositionThree_ShouldReturnThatValue(int firstValue, int secondValue, int thirdValue)
        {
            int expectedResult = thirdValue;
            int result = FindMaximumNumber.FindMaxIntNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
