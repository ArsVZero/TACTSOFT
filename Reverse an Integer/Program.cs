Console.Write("Enter an integer: ");
int integer = Convert.ToInt32(Console.ReadLine());
int number = integer, reverse = 0;
while (integer != 0)
{
    int remainder = integer % 10;
    reverse = reverse * 10 + remainder;
    integer /= 10;
}
Console.WriteLine("Reversed form of {0} is {1}", number, reverse);