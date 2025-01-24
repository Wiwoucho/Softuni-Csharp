int n = int.Parse(Console.ReadLine());

int[] arr = new int[n];

for (int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine());
    arr[i] = number;
}
Array.Reverse(arr);
Console.WriteLine(string.Join(" ", arr));