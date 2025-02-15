string encryptedMessage = Console.ReadLine();

List<int> numbers = new List<int>();
List<char> nonNumbers = new List<char>();

foreach (char symbol in encryptedMessage)
{
    if (char.IsDigit(symbol))
    {
        numbers.Add(int.Parse(symbol.ToString()));
    }
    else
    {
        nonNumbers.Add(symbol);
    }
}


List<int> takeList = new List<int>();
List<int> skipList = new List<int>();
for (int i = 0; i < numbers.Count; i++) 
{
    if (i % 2 == 0)
    {
        takeList.Add(numbers[i]);
    }
    else 
    {
        skipList.Add(numbers[i]);
    } 
}

string result = "";

while (takeList.Count > 0)
{
    result += new string(nonNumbers.Take(takeList[0]).ToArray());

    if (nonNumbers.Count < takeList[0])
    {
        takeList[0] = nonNumbers.Count;
    }
    nonNumbers.RemoveRange(0, takeList[0]);

    if (nonNumbers.Count < skipList[0])
    {
        skipList[0] = nonNumbers.Count;
    }
    nonNumbers.RemoveRange(0, skipList[0]);

    takeList.RemoveAt(0);
    skipList.RemoveAt(0);
}

Console.WriteLine(result);