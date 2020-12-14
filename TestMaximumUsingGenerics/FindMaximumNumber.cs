using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaximumUsingGenerics
{
    public class FindMaximumNumber
    {

        /// <summary>
        /// This method returns largest numbers among all 3 integer numbers 
        /// </summary>
        /// <param name="firstValue">firstValue is of integer type</param>
        /// <param name="secondValue">secondValue is of integer type</param>
        /// <param name="thirdValue">thirdValue is of integer type</param>
        /// <returns></returns>
        public static int FindMaxIntNumber(int firstValue, int secondValue, int thirdValue)
        {
            if(firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0 ||
               firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) > 0 ||
               firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) >=0 )
            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0 ||
                secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) > 0 ||
                secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) >= 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0 ||
                thirdValue.CompareTo(firstValue) >=0 && thirdValue.CompareTo(secondValue) > 0 ||
                thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) >= 0)
            {
                return thirdValue;
            }
            return firstValue;
        }
       
    }
}
