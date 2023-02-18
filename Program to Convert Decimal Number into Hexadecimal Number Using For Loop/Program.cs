int counter = 0, temporary = 0, remainder = 0;
Console.Write("Enter a decimal number: ");
int decimalNumber = Convert.ToInt32(Console.ReadLine());
char[] hexadecimalNumber = new char[64];
temporary = decimalNumber;

for (int i = 0; decimalNumber > 0; i++)
{
    remainder = decimalNumber % 16;
    if (remainder < 10)
    {
        hexadecimalNumber[i] = (char)(remainder + 48);
    }
    else
    {
        hexadecimalNumber[i] = (char)(remainder + 55);
    }
    decimalNumber /= 16;
    counter++;
}

Console.Write("Binary equivalent of {0} is: ", temporary);

for (int i = counter - 1; i >= 0; i--)
{
    Console.Write(hexadecimalNumber[i]);
}