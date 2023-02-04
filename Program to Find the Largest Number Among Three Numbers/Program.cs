Console.Write("Enter first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter third number: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber > secondNumber)
{
    if (firstNumber > thirdNumber)
    {
        Console.WriteLine("First number {0} is the largest", firstNumber);
    }
    else
    {
        Console.WriteLine("Third number {0} is the largest", thirdNumber);
    }
}
else
{
    if (secondNumber > thirdNumber)
    {
        Console.WriteLine("Second number {0} is the largest", secondNumber);
    }
    else
    {
        Console.WriteLine("Third number {0} is the largest", thirdNumber);
    }
}