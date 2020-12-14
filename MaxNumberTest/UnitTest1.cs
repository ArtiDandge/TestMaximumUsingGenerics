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

        /// <summary>
        /// TC1.1 When Three Floats are given to the method and largest number among all numbers is at position 1st, this test case should pass
        /// </summary>
        /// <param name="firstValue">firstValue will be maximum of all three Float values</param>
        /// <param name="secondValue">secondValue contain Float value</param>
        /// <param name="thirdValue">thirdValue  contain Float value</param>
        [TestMethod]
        [DataRow(54.3f, 4.3f, 3.2f)]
        public void GivenThreeFloat_WhenMaxFloatAtPositionOne_ShouldReturnThatValue(float firstValue, float secondValue, float thirdValue)
        {
            float expectedResult = firstValue;
            float result = FindMaximumNumber.FindMaxFloatNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expectedResult, result);
        }

        /// <summary>
        /// TC1.2 When Three Floats are given to the method and largest number among all numbers is at position 2nd, this test case should pass
        /// </summary>
        /// <param name="firstValue">firstValue will contain float value</param>
        /// <param name="secondValue">secondValue will be maximum of all three float values</param>
        /// <param name="thirdValue">thirdValue  contain float value</param>
        [TestMethod]
        [DataRow(22.3f, 345.3f, 4.32f)]
        public void GivenThreeFloat_WhenMaxFloatAtPositionTwo_ShouldReturnThatValue(float firstValue, float secondValue, float thirdValue)
        {
            float expectedResult = secondValue;
            float result = FindMaximumNumber.FindMaxFloatNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expectedResult, result);
        }

        /// <summary>
        /// TC1.3 When Three floats are given to the method and largest number among all numbers is at position 3rd, this test case should pass
        /// </summary>
        /// <param name="firstValue">firstValue contain float value</param>
        /// <param name="secondValue">secondValue contain float value</param>
        /// <param name="thirdValue">thirdValue will be maximum of all three float values </param>
        [TestMethod]
        [DataRow(53.3f, 3.53f, 83.2f)]
        public void GivenThreeFloat_WhenMaxFloatAtPositionThree_ShouldReturnThatValue(float firstValue, float secondValue, float thirdValue)
        {
            float expectedResult = thirdValue;
            float result = FindMaximumNumber.FindMaxFloatNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expectedResult, result);
        }

        /// <summary>
        /// TC1.1 When Three strings are given to the method and largest number among all numbers is at position 1st, this test case should pass
        /// </summary>
        /// <param name="firstValue">firstValue will return, since its precedes </param>
        /// <param name="secondValue">secondValue contain string value</param>
        /// <param name="thirdValue">thirdValue  contain string value</param>
        [TestMethod]
        [DataRow("Zebra", "Peach", "Banana")]
        public void GivenThreeString_WhenMaxStringAtPositionOne_ShouldReturnThatValue(string firstValue, string secondValue, string thirdValue)
        {
            string expectedResult = firstValue;
            string result = FindMaximumNumber.FindMaxString(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expectedResult, result);
        }

        /// <summary>
        /// TC1.2 When Three strings are given to the method and largest number among all strings is at position 2nd, this test case should pass
        /// </summary>
        /// <param name="firstValue">firstValue will contain string value</param>
        /// <param name="secondValue">secondValue will return, since its precedes </param>
        /// <param name="thirdValue">thirdValue  contain string value</param>
        [TestMethod]
        [DataRow("Apple", "Peach", "Banana")]
        public void GivenThreeStrings_WhenMaxStringAtPositionTwo_ShouldReturnThatValue(string firstValue, string secondValue, string thirdValue)
        {
            string expectedResult = secondValue;
            string result = FindMaximumNumber.FindMaxString(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expectedResult, result);
        }

        /// <summary>
        /// TC1.3 When Three strings are given to the method and largest number among all numbers is at position 3rd, this test case should pass
        /// </summary>
        /// <param name="firstValue">firstValue contain string value</param>
        /// <param name="secondValue">secondValue contain string value</param>
        /// <param name="thirdValue">thirdValue will return, since its precedes </param>
        [TestMethod]
        [DataRow("Apple", "Banana","Yogart")]
        public void GivenThreeString_WhenMaxStringAtPositionThree_ShouldReturnThatValue(string firstValue, string secondValue, string thirdValue)
        {
            string expectedResult = thirdValue;
            string result = FindMaximumNumber.FindMaxString(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expectedResult, result);
        }

    }
}
