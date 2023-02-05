Console.Write("Enter the base: ");
int baseNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the exponent: ");
int exponent = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i = 0; i < exponent; i++)
{
    result *= baseNumber;
}
Console.Write("{0} to the power {1} is equals {2}", exponent, baseNumber, result);