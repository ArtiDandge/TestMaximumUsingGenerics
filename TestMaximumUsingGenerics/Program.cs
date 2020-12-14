using System;

namespace TestMaximumUsingGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to this program where we will be finding maximum number using generics");
            Console.WriteLine(FindMaximumNumber.FindMaxIntNumber(654,53,112));
            Console.WriteLine(FindMaximumNumber.FindMaxIntNumber(64, 533, 12));
            Console.WriteLine(FindMaximumNumber.FindMaxIntNumber(643, 53, 1312));
            Console.WriteLine(FindMaximumNumber.FindMaxFloatNumber(6.4f, 5.3f, 1.2f));
            Console.WriteLine(FindMaximumNumber.FindMaxFloatNumber(6.4f, 53.3f, 2f));
            Console.WriteLine(FindMaximumNumber.FindMaxFloatNumber(6.43f, 5.3f, 131.2f));
        }
    }
}
