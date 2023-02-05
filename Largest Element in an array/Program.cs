int[] numbers = new int[] { 3, 5, 2, 8, 6 };
int largest = numbers[0];
foreach (int number in numbers)
{
    if (number > largest)
    {
        largest = number;
    }
}
Console.WriteLine("The largest number is: {0}", largest);