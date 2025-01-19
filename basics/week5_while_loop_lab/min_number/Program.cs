string text = Console.ReadLine();

int minNumber = int.MaxValue;

while (text != "Stop")
{
    int number = int.Parse(text);
    if (number < minNumber)
    {
        minNumber = number;
    }
    text = Console.ReadLine();
}

Console.WriteLine(minNumber);