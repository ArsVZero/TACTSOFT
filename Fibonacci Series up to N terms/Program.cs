Console.Write("Enter the number of terms: ");
int terms = Convert.ToInt32(Console.ReadLine());
int first = 0, second = 1, next = 0;
Console.Write("Fibonacci Series upto {0} terms is: ", terms);
for (int i = 0; i < terms; i++)
{
    if (i <= 1)
    {
        next = i;
    }
    else
    {
        next = first + second;
        first = second;
        second = next;
    }
    Console.Write(next + " ");
}