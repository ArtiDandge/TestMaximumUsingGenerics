using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaximumUsingGenerics
{
    public class FindMaximumNumber<T> where T : System.IComparable<T>
    {
        public T[] value;
        /// <summary>
        /// Constructor of class type generic
        /// </summary>
        /// <param name="value">genric value</param>
        public FindMaximumNumber(T[] value)
        {
            this.value = value;

        }

        /// <summary>
        /// This method returns largest  among all 3 numbers uisng Generinc Class
        /// </summary>
        /// <param name="firstValue">firstValue is of Generinc type</param>
        /// <param name="secondValue">secondValue is of Generinc type</param>
        /// <param name="thirdValue">thirdValue is of Generinc type</param>
        /// <returns></returns>
        public static T FindMaximum(T firstValue, T secondValue, T thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0 ||
               firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) > 0 ||
               firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) >= 0)
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
                thirdValue.CompareTo(firstValue) >= 0 && thirdValue.CompareTo(secondValue) > 0 ||
                thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) >= 0)
            {
                return thirdValue;
            }
            return firstValue;
        }

        /// <summary>
        /// Sort given array
        /// </summary>
        /// <param name="values">integer values</param>
        /// <returns></returns>
        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }

        /// <summary>
        /// Sort given array and return max value
        /// </summary>
        /// <param name="values">integer values</param>
        /// <returns></returns>
        public T MaxValue(params T[] values)
        {
            var sorted_value = Sort(values);
            return sorted_value[^1];
        }

        /// <summary>
        /// return max value 
        /// </summary>
        /// <returns></returns>
        public T MaxMEthod()
        {
            var Max = MaxValue(this.value);
            return Max;
        }
      
        /// <summary>
        /// Print max value
        /// </summary>
        public void PrintMAxValue()
        {
            var max = MaxValue(this.value);
            Console.WriteLine("MAximum value is : " +max);
        }

    }
}
