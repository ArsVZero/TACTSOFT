Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number <= 0)
{
    Console.WriteLine("Enter a positive number");
}
else
{
    int factorial = 1;
    for (int i = 1; i <= number; i++)
    {
        factorial *= i;
    }
    Console.WriteLine("Factorial of {0} is {1}", number, factorial);
}