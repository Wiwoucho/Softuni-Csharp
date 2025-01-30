int dnaLenght = int.Parse(Console.ReadLine());
string[] dnaSamples = new string[0];


static int SumElements(string dna)
{
    int sum = 0;
    
        for (int i = 0; i < dna.Length; i++)
        {
            sum += int.Parse(dna[i].ToString());
        }
    
    return sum;
}

static int DnaIndex(string[] array, string dna)
{
    
        string target = string.Join(" ", dna.ToArray());

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == target)
            {
                return i;
            }
        }
    
    return 0;
}


while (true)
{
    string input = Console.ReadLine();
    string[] data = input.Split('!', StringSplitOptions.RemoveEmptyEntries);
    string dna = string.Join(" ", data);

    if (input == "Clone them!")
    {
        break;
    }

    Array.Resize(ref dnaSamples, dnaSamples.Length + 1);
    dnaSamples[dnaSamples.Length - 1] = string.Join(" ", dna);
}

string[] longestDnaSequence = new string[0];


foreach (string ddd in dnaSamples)
{
    int currentLenght = 1;
    int biggestLenght = 1;

    string dna = ddd.Replace(" ", "");

    for (int i = 1; i < dna.Length; i++)
    {
        if (dna[i] == '1' && dna[i - 1] == '1')
        {
            currentLenght += 1;
        }
        else
        {
            currentLenght = 1;
        }

        if (currentLenght > biggestLenght)
        {
            biggestLenght = currentLenght;
        }

    }
    if (biggestLenght > 1)
    {
        Array.Resize(ref longestDnaSequence, longestDnaSequence.Length + 1);
        longestDnaSequence[longestDnaSequence.Length - 1] = dna;
    }
}

int bestIndex = int.MaxValue;
string[] sameBestIndexArray = new string[1];

foreach (string dna in longestDnaSequence)
{
    int currentLenght = 1;
    int biggestLenght = 1;
    int leftMostIndex = 0;

    for (int i = 1; i < dna.Length; i++)
    {
        if (dna[i] == '1' && dna[i - 1] == '1')
        {
            currentLenght += 1;
        }
        else
        {
            currentLenght = 1;
        }

        if (currentLenght > biggestLenght)
        {
            biggestLenght = currentLenght;
            leftMostIndex = i;
        }
    }
    if (bestIndex > leftMostIndex)
    {
        bestIndex = leftMostIndex;
        sameBestIndexArray[0] = dna;
    }
    else if (bestIndex == leftMostIndex)
    {
        Array.Resize(ref sameBestIndexArray, sameBestIndexArray.Length + 1);
        sameBestIndexArray[sameBestIndexArray.Length - 1] = dna;
    }
}
if (sameBestIndexArray[0] == null)
{
    sameBestIndexArray[0] = "1";
}

if (sameBestIndexArray.Length == 1)
{
    string dna = sameBestIndexArray[0];
    Console.WriteLine($"Best DNA sample {DnaIndex(dnaSamples, dna) + 1} with sum: {SumElements(dna)}.");
    Console.WriteLine(string.Join(" ", dna.ToArray()));
}
else
{
    int bestDnaIndex = 0;
    int bestDnaSum = 0;
    for (int i = 0; i < sameBestIndexArray.Length; i++)
    {
        string dnk = sameBestIndexArray[i];
        int currentDnaSum = SumElements(dnk);
        if (currentDnaSum < bestDnaSum)
        {
            bestDnaIndex = i;
        }
    }

    string dna = sameBestIndexArray[bestDnaIndex];
    Console.WriteLine($"Best DNA sample {DnaIndex(dnaSamples, dna) + 1} with sum: {SumElements(dna)}.");
    Console.WriteLine(string.Join(" ", dna.ToArray()));
}

