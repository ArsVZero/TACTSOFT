bool flag;
Console.Write("Enter start: ");
int start = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter end: ");
int end = Convert.ToInt32(Console.ReadLine());

if (start > end)
{
    int temporary = start;
    start = end;
    end = temporary;
}

Console.Write("Prime numbers between {0} and {1} are: ", start, end);
while (start < end)
{
    flag = false;

    if (start <= 1)
    {
        ++start;
        continue;
    }

    for (int i = 2; i <= start / 2; ++i)
    {
        if (start % i == 0)
        {
            flag = true;
            break;
        }
    }

    if (flag == false)
    {
        Console.Write("{0} ", start);
    }
    ++start;
}