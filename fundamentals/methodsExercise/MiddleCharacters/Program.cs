string input = Console.ReadLine();


static string MiddleChars(string input)
{
    string result = null;

    if (input.Length % 2 == 0)
    {
        result += input[input.Length / 2 -1 ];
        result += input[input.Length / 2];
    }
    else
    {
        result += input[input.Length/2];
    }

    return result;
}


Console.WriteLine(MiddleChars(input));