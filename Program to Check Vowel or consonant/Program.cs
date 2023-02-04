Console.Write("Enter an alphabet: ");
char character = Convert.ToChar(Console.Read());
bool lowerCase = character is 'a' or 'e' or 'i' or 'o' or 'u';
bool upperCase = character is 'A' or 'E' or 'I' or 'O' or 'U';
if (character >= 'a' && character <= 'z' || character >= 'A' && character <= 'Z')
{
    if (lowerCase || upperCase)
    {
        Console.WriteLine("{0} is a Vowel", character);
    }
    else
    {
        Console.WriteLine("{0} is a Consonant", character);
    }
}
else
{
    Console.WriteLine("{0} is not an Alphabet", character);
}