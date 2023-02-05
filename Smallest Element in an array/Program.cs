int[] numbers = new int[] { 3, 5, 1, 8, 6 };
int smallest = numbers[0];
foreach (int number in numbers)
{
    if (number < smallest)
    {
        smallest = number;
    }
}
Console.WriteLine("The smallest number is: {0}", smallest);