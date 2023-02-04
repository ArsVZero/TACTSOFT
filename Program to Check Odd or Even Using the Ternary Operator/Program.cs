Console.Write("Enter an integer: ");
int integer = Convert.ToInt32(Console.ReadLine());
if (integer == 0)
{
    Console.WriteLine("{0} is Neutral", integer);
}
else if (integer % 2 != 0)
{
    Console.WriteLine("{0} is Odd", integer);
}
else
{
    Console.WriteLine("{0} is Even", integer);
}