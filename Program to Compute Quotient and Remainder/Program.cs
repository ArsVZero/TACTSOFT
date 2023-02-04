Console.Write("Enter dividend: ");
int dividend = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter divisor: ");
int divisor = Convert.ToInt32(Console.ReadLine());
int quotient = dividend / divisor;
int remainder = dividend % divisor;
Console.WriteLine("Quotient & Remainder of {0} & {1} is respectively {2} & {3}", dividend, divisor, quotient, remainder);