int n = int.Parse(Console.ReadLine());

List<int> oddNums = new List<int>();
List<int> evenNums = new List<int>();

for (int i = 1; i <= n; i++)
{
    int num = int.Parse(Console.ReadLine());

    if (i % 2 == 0)
    {
        evenNums.Add(num);
    }
    else
    {
        oddNums.Add(num);
    }
}

if (oddNums.Sum() > evenNums.Sum() || evenNums.Sum() > oddNums.Sum())
{
    Console.WriteLine($"No\nDiff = {Math.Abs(oddNums.Sum() - evenNums.Sum())}");
}
else
{
    Console.WriteLine($"Yes\nSum = {evenNums.Sum()}");
}
