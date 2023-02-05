Console.Write("Enter an integer: ");
int integer = Convert.ToInt32(Console.ReadLine());
int number = integer, count = 0;
while (integer != 0)
{
    integer /= 10;
    count++;
}
Console.WriteLine("Number of digits in {0} is {1}", number, count);