//int output = 0;
//Console.Write("Enter lower range: ");
//int lower = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter upper range: ");
//int upper = Convert.ToInt32(Console.ReadLine());

//Console.Write("Armstrong numbers between {0} and {1} are: ", lower, upper);

//for (int i = lower; i <= upper; i++)
//{
//    int temporary = i;
//    while (temporary != 0)
//    {
//        int remainder = temporary % 10;
//        output = output + (remainder * remainder * remainder);
//        temporary /= 10;
//    }

//    if (i == output)
//    {
//        Console.Write("{0} ", i);
//    }

//    output = 0;
//}
using System;

namespace ArmstrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int lower, upper, temp, remainder, n = 0, result = 0;

            Console.Write("Enter lower range: ");
            lower = int.Parse(Console.ReadLine());
            Console.Write("Enter upper range: ");
            upper = int.Parse(Console.ReadLine());

            Console.WriteLine("Armstrong numbers between {0} and {1} are: ", lower, upper);

            for (int i = lower; i <= upper; i++)
            {
                temp = i;
                while (temp != 0)
                {
                    remainder = temp % 10;
                    n = n + (remainder * remainder * remainder);
                    temp /= 10;
                }

                if (i == n)
                {
                    Console.WriteLine(i);
                }

                n = 0;
            }
        }
    }
}
