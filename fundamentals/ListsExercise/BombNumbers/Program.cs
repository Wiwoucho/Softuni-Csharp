List<int> bombNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
int[] detonatorNums = Console.ReadLine().Split().Select(int.Parse).ToArray();

int detonator = detonatorNums[0];
int detonatorRange = detonatorNums[1];


while (bombNumbers.Contains(detonator))
{
    int bombIndex = bombNumbers.IndexOf(detonator);
    int startIndex = Math.Max(0, bombIndex - detonatorRange);
    int endIndex = Math.Min(bombNumbers.Count - 1, bombIndex + detonatorRange);

    bombNumbers.RemoveRange(startIndex, endIndex - startIndex + 1);
}


Console.WriteLine(bombNumbers.Sum());

