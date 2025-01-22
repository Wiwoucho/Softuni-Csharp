int key = int.Parse(Console.ReadLine());
int iterration = int.Parse(Console.ReadLine());


List<int> asciiNumbers = new List<int>();
List <string> text = new List<string>();

for (int i = 0; i < iterration; i++)
{
   
    char newChar = char.Parse(Console.ReadLine());

    int turnIntoAscii = (int)newChar + (int)key;
    asciiNumbers.Add(turnIntoAscii);
}

foreach (int c in asciiNumbers)
{
    text.Add(char.ConvertFromUtf32(c));
}
string result = string.Join("", text);
Console.WriteLine(result);