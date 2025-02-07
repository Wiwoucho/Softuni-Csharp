List<int> numbers1 = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> numbers2 = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> result = new List<int>();

if (numbers1.Count >= numbers2.Count)
{
    for (int i = 0; i < numbers1.Count; i++)
    {
        if (i < numbers1.Count) result.Add(numbers1[i]);
        if (i < numbers2.Count) result.Add(numbers2[i]);
    }
}
else
{
    for (int i = 0; i < numbers2.Count; i++)
    {
       if (i < numbers1.Count) result.Add(numbers1[i]);
       if (i < numbers2.Count) result.Add(numbers2[i]);
    }
}
Console.WriteLine(string.Join(" ", result));