﻿int n = int.Parse(Console.ReadLine());

int[] arr = new int[n];

for (int i = 0; i < n; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine(string.Join(" ",  arr));
Console.WriteLine(arr.Sum());