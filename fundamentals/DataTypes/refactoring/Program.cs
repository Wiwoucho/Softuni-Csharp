/*
 Old code 
 
 int ___Do___ = int.Parse(Console.ReadLine());
for (int takoa = 2; takoa <= ___Do___; takoa++)
{
   bool takovalie = true;
   for (int cepitel = 2; cepitel < takoa; cepitel++)
   {
       if (takoa % cepitel == 0)
       {
          takovalie = false;
          break;
       }
   }
Console.WriteLine("{0} -> {1}", takoa, takovalie);
}

 */

static bool IsPrime(int num)
{
    return true;
}

int n = int.Parse(Console.ReadLine());
for (int i = 2; i <= n; i++)
{
    bool isPrime = true;
    if (i == 2)
    {
        Console.WriteLine($"{i} -> {isPrime.ToString().ToLower()}");
        continue;
    }
    for (int j = 2; j < Math.Sqrt(n); j++)
    {
        if (i % j == 0)
        {
            isPrime = false;
            break;
        }
    }
    Console.WriteLine($"{i} -> {isPrime.ToString().ToLower()}");
}
