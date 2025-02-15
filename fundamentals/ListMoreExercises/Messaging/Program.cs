List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
string text = Console.ReadLine();

for (int i = 0; i < numbers.Count; i++)
{
    int result = 0;
    string numbersToString = numbers[i].ToString();

    foreach (char symbol in numbersToString)
    {
        result += int.Parse(symbol.ToString());
    }

    numbers[i] = result;

}

string phrase = string.Empty;


for (int i = 0; i < numbers.Count; i++)
{
    int counter = 0;
    int index = 0;

    for (int j = 0; j < numbers[i]; j++)
    {


        if (counter == text.Length)
        {
            index = 0;
            
        }

        counter += 1;
        index += 1;

    }
    phrase += text[index].ToString();
    text = text.Remove(index, 1);
}

Console.WriteLine(phrase);