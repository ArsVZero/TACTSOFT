Console.Write("Enter first value: ");
int firstValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second value: ");
int secondValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Before swapping, first value is {0} & second value is {1}", firstValue, secondValue);
int temporary = firstValue;
firstValue = secondValue;
secondValue = temporary;
Console.WriteLine("After swapping, first value is {0} & second value is {1}", firstValue, secondValue);
