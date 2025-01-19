int n = int.Parse(Console.ReadLine());

int max_number = int.MinValue;
int sum = 0;

for (int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine());

    sum += number;
    if (number > max_number)
    {
        max_number = number;

    }

}

sum -= max_number;

// Check if the sum of the remaining numbers is equal to the maximum number
if (sum == max_number)
{
    Console.WriteLine($"Yes\n Sum = {max_number}");
}
else
{
    Console.WriteLine($"No\n Diff = {Math.Abs(max_number - sum)}");
}