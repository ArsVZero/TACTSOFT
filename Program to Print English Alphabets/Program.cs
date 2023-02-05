Console.Write("Enter U/u to print uppercase alphabets & L/l to print lowercase alphabets: ");
char caseType = Convert.ToChar(Console.Read());
switch (caseType)
{
    case 'l':
    case 'L':
        Console.Write("Lower case alphabets: ");
        for (char i = 'a'; i <= 'z'; i++)
        {
            Console.Write(i + " ");
        }
        break;
    case 'u':
    case 'U':
        Console.Write("Upper case alphabets: ");
        for (char i = 'A'; i <= 'Z'; i++)
        {
            Console.Write(i + " ");
        }
        break;
    default:
        Console.WriteLine("Invalod input");
        break;
}
