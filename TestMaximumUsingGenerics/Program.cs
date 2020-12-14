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
        }
    }
}
