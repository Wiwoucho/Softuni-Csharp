using System.Threading.Channels;

char char1 = char.Parse(Console.ReadLine());
char char2 = char.Parse(Console.ReadLine());


static string Sequence(char char1, char char2)
{

    if (char1 > char2)
    {
        (char1, char2) = (char2, char1);
    }

    string characters = null;
    for (int i = char1+1 ; i < char2 ; i++)
    {
        characters += $"{(char) i} ";
    }

    return characters;
}

Console.WriteLine(Sequence(char1, char2));