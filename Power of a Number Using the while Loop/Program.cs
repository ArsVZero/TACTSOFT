Console.Write("Enter the base: ");
int baseNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the exponent: ");
int exponent = Convert.ToInt32(Console.ReadLine());
int result = 1;
int i = 0;
while (i < exponent)
{
    result *= baseNumber;
    i++;
}
Console.Write("{0} to the power {1} is equals {2}", exponent, baseNumber, result);