string text = Console.ReadLine();

int maxNumber = int.MinValue;

while (text != "Stop")
{
   int number = int.Parse(text);
    if (number > maxNumber)
    {
        maxNumber = number;
    }
    text = Console.ReadLine();
}

Console.WriteLine(maxNumber);