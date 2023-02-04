Console.Write("Enter a: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter b: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter c: ");
double c = Convert.ToDouble(Console.ReadLine());
double discriminator, denominator, root1, root2;
if (a == 0)
{
    root1 = -c / b;
    Console.WriteLine("The roots are linear {0}", root1);
}
else
{
    discriminator = (b * b) - (4 * a * c);
    denominator = 2 * a;
    if (discriminator > 0)
    {
        Console.WriteLine("THE ROOTS ARE REAL AND DISTINCT ROOTS");
        root1 = (-b / denominator) + (Math.Sqrt(discriminator) / denominator);
        root2 = (-b / denominator) - (Math.Sqrt(discriminator) / denominator);
        Console.WriteLine("THE ROOTS ARE {0} and {1}", root1, root2);
    }
    else if (discriminator == 0)
    {
        Console.WriteLine("THE ROOTS ARE REPEATED");
        root1 = -b / denominator;
        Console.WriteLine("THE ROOT IS {0}", root1);
    }
    else
    {
        Console.WriteLine("THE ROOTS ARE COMPLEX");
        root1 = -b / denominator;
        root2 = ((Math.Sqrt((4 * a * c) - (b * b))) / denominator);
        Console.WriteLine("THE ROOT 1 IS {0} + {1}i", root1, root2);
        Console.WriteLine("THE ROOT 2 IS {0} + {1}i", root1, root2);
    }
}