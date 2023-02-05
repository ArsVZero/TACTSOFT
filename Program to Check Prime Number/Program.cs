Console.Write("Enter an integer: ");
int integer = Convert.ToInt32(Console.ReadLine());
bool isPrime = true;
for (int i = 2; i <= integer / 2; i++)
{
    if (integer % i == 0)
    {
        isPrime = false;
        break;
    }
}
if (isPrime)
{
    Console.WriteLine("{0} is prime", integer);
}
else
{
    Console.WriteLine("{0} is not prime", integer);
}