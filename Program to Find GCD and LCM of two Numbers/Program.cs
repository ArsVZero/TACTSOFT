Console.Write("Enter first positive integer: ");
int firstPositiveInteger = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second positive integer: ");
int secondPositiveInteger = Convert.ToInt32(Console.ReadLine());
int greatestCommonDivisor = 0, leastCommonMultiple = 0;

for (int i = 1; i <= firstPositiveInteger && i <= secondPositiveInteger; i++)
{
    if (firstPositiveInteger % i == 0 && secondPositiveInteger % i == 0)
    {
        greatestCommonDivisor = i;
    }
}

leastCommonMultiple = (firstPositiveInteger * secondPositiveInteger) / greatestCommonDivisor;
Console.WriteLine("The GCD of {0} and {1} is {2}", firstPositiveInteger, secondPositiveInteger, greatestCommonDivisor);
Console.WriteLine("The LCM of {0} and {1} is {2}", firstPositiveInteger, secondPositiveInteger, leastCommonMultiple);
