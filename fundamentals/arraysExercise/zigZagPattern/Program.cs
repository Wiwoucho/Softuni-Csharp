int n = int.Parse(Console.ReadLine());

string[] arr1 = new string[n];
string[] arr2 = new string[n];


for (int i = 1; i <= n; i++)
{
    string[] currentNumbers = Console.ReadLine().Split();
    string num1 = currentNumbers[0];
    string num2 = currentNumbers[1];

    if (i % 2 != 0)
    {
        arr1[i-1] = num1;
        arr2[i-1] = num2;
    }
    else
    {
        arr1[i-1] = num2;
        arr2[i-1] = num1;
    }

}

Console.WriteLine(string.Join(" ", arr1));
Console.WriteLine(string.Join(" ", arr2));