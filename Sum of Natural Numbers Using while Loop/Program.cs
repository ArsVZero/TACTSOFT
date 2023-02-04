Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number <= 0)
{
    Console.WriteLine("Enter a positive number");
}
else
{
    int sum = 0, i = 1;
    while (i <= number)
    {
        sum += i;
        i++;
    }
    Console.WriteLine("Sum of natural numbers up to {0} is {1}", number, sum);
}