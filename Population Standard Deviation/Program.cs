double[] numbers = new double[] { 2.0, 4.0, 4.0, 4.0, 5.0, 5.0, 7.0, 9.0 };
double mean = 0.0;
double sumOfSquaredDifferences = 0.0;
int count = numbers.Length;

foreach (double number in numbers)
{
    mean += number;
}
mean /= count;

foreach (double number in numbers)
{
    double difference = number - mean;
    sumOfSquaredDifferences += difference * difference;
}

double standardDeviation = Math.Sqrt(sumOfSquaredDifferences / count);

Console.WriteLine("The standard deviation is: {0}", standardDeviation);