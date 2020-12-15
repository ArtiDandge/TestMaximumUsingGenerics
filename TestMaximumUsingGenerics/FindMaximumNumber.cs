using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaximumUsingGenerics
{
    public class FindMaximumNumber<T> where T : System.IComparable<T>
    {
        public T firstValue, secondValue, thirdValue;

        /// <summary>
        /// This method returns largest  among all 3 numbers uisng Generinc Class
        /// </summary>
        /// <param name="firstValue">firstValue is of Generinc type</param>
        /// <param name="secondValue">secondValue is of Generinc type</param>
        /// <param name="thirdValue">thirdValue is of Generinc type</param>
        /// <returns></returns>
        public static T FindMaximum(T firstValue, T secondValue, T thirdValue)
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
