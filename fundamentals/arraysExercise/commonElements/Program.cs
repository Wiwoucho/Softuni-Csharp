string[] arr1 = Console.ReadLine().Split();
string[] arr2 = Console.ReadLine().Split();

List<string> result = new List<string>();

result = arr2.Intersect(arr1).ToList();

Console.WriteLine(string.Join(" ", result));