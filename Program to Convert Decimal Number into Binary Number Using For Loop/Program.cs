int counter = 0, temporary = 0;
Console.Write("Enter a decimal number: ");
int decimalNumber = Convert.ToInt32(Console.ReadLine());
int[] binaryNumber = new int[64];
temporary = decimalNumber;

for (int i = 0; decimalNumber > 0; i++)
{
    binaryNumber[i] = decimalNumber % 2;
    decimalNumber /= 2;
    counter++;
}

Console.Write("Binary equivalent of {0} is: ", temporary);

for (int i = counter - 1; i >= 0; i--)
{
    Console.Write(binaryNumber[i]);
}