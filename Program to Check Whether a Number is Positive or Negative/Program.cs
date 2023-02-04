Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 0)
{
    Console.WriteLine("{0} is neutral", number);
}
else if (number > 0)
{
    Console.WriteLine("{0} is positive", number);
}
else
{
    Console.WriteLine("{0} is negative", number);
}
