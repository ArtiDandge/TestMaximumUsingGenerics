using System;

namespace TestMaximumUsingGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to this program where we will be finding maximum number using generics");
            Console.WriteLine("-------------Comaparision of Integers------------");
            Console.WriteLine("Max value among 654, 53, 112 is \t " + FindMaximumNumber<int>.FindMaximum(654,53,112));
            Console.WriteLine("Max value among 64, 533, 12 is \t " + FindMaximumNumber<int>.FindMaximum(64, 533, 12));
            Console.WriteLine("Max value among 643, 53, 1312 is \t " + FindMaximumNumber<int>.FindMaximum(643, 53, 1312));


            Console.WriteLine("-------------Comaparision of Float------------");
            Console.WriteLine("Max value among 6.4f, 5.3f, 1.2f is \t " + FindMaximumNumber<float>.FindMaximum(6.4f, 5.3f, 1.2f));
            Console.WriteLine("Max value among 6.4f, 53.3f, 2f is \t " + FindMaximumNumber<float>.FindMaximum(6.4f, 53.3f, 2f));
            Console.WriteLine("Max value among 6.43f, 5.3f, 131.2f is \t " + FindMaximumNumber<float>.FindMaximum(6.43f, 5.3f, 131.2f));

            Console.WriteLine("-------------Comaparision of String------------");
            Console.WriteLine(FindMaximumNumber<string>.FindMaximum("Apple","Peach","Banana"));
            Console.WriteLine(FindMaximumNumber<string>.FindMaximum("Zebra", "Peach", "Banana"));

            Console.WriteLine("--------------------Generics Class and Method-------------------------");
            int[] arr = { 23, 345, 456, 456, 456, 332 };
            FindMaximumNumber<int> generic = new FindMaximumNumber<int>(arr);

         }
    }
}
