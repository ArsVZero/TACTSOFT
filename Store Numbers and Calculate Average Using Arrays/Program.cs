int[] numbers = new int[] { 1, 2, 3, 4, 5 };
int sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    sum += numbers[i];
}

int average = sum / numbers.Length;
Console.WriteLine("The average is: {0}", average);