static int vowelsCount(string word)
{
    int sum = 0;
    foreach (char c in word.ToLower())
    {
        if (c == 'a' || c == 'e' || c == 'o' || c == 'u' || c == 'i')
        {
            sum += 1;
        }
    }

        return sum; 
}


string word = Console.ReadLine();

Console.WriteLine(vowelsCount(word));