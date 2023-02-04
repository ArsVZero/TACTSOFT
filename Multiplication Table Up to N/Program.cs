Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number <= 0)
{
    Console.WriteLine("Enter a positive number");
}
else
{
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine("{0} x {1} = {2}", number, i, number * i);
    }
}