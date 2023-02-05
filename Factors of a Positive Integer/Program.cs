Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("The factors of {0} are: ", number);
for (int i = 1; i <= number; i++)
{
    if (number % i == 0)
    {
        Console.Write(i + " ");
    }
}