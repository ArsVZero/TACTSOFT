Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int originalNumber, remainder, result = 0;
originalNumber = number;

while (originalNumber != 0)
{
    remainder = originalNumber % 10;
    result += (int)Math.Pow(remainder, 3);
    originalNumber /= 10;
}

if (result == number) { Console.WriteLine("{0} is an Armstrong number", number); }
else { Console.WriteLine("{0} is not an Armstrong number", number); }