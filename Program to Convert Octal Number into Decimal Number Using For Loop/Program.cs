int octalNumber, decimalNumber = 0, reminder = 0, temporary = 0, baseNumber = 8;
Console.Write("Enter an octal number: ");
octalNumber = Convert.ToInt32(Console.ReadLine());
temporary = octalNumber;
for (int i = 0; octalNumber > 0; i++)
{
    reminder = octalNumber % 10;
    octalNumber /= 10;
    decimalNumber += Convert.ToInt32(reminder * Math.Pow(Convert.ToDouble(baseNumber), Convert.ToDouble(i)));
}
Console.WriteLine("Decimal equivalent of {0} is {1}", temporary, decimalNumber);