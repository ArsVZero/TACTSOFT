Console.Write("Enter an integer: ");
int integer = Convert.ToInt32(Console.ReadLine());
int number = integer;
int reverse = 0;
while (integer != 0)
{
    int remainder = integer % 10;
    reverse = reverse * 10 + remainder;
    integer /= 10;
}
if (number == reverse)
{
    Console.WriteLine("{0} is a palindrome", number);
}
else
{
    Console.WriteLine("{0} is not a palindrome", number);
}