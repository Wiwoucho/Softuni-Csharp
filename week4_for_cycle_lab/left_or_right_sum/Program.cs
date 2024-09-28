int n = int.Parse(Console.ReadLine());


int sumLeft = 0;
int sumRight = 0;

for (int i = 1; i <= 2; i++)
{
    for (int j = 1; j <= n ; j++)
    {
        if (i == 1)
        {
            sumLeft += int.Parse(Console.ReadLine());
        }
        else
        {
            sumRight += int.Parse(Console.ReadLine());
        }

    }
}

if  (sumLeft > sumRight || sumRight > sumLeft)
{
    Console.WriteLine($"No, diff = {Math.Abs(sumLeft - sumRight)}");
}
else
{
    Console.WriteLine($"Yes, sum = {sumRight}");
}