Console.Write("Enter first floating-point number: ");
float floatingPointNumber1 = Convert.ToSingle(Console.ReadLine());
Console.Write("Enter second floating-point number: ");
float floatingPointNumber2 = Convert.ToSingle(Console.ReadLine());
float result = floatingPointNumber1 * floatingPointNumber2;
Console.WriteLine("Product of {0} & {1} is {2}", floatingPointNumber1, floatingPointNumber2, result);