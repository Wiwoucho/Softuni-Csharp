int x1 = int.Parse(Console.ReadLine());
int y1 = int.Parse(Console.ReadLine());
int x2 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());
int x3 = int.Parse(Console.ReadLine());
int y3 = int.Parse(Console.ReadLine());
int x4 = int.Parse(Console.ReadLine());
int y4 = int.Parse(Console.ReadLine());

static (int,int)[] ClosestPairToZero(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
{
    (int, int)[] result = new (int, int)[2];

    int firstPair = Math.Abs(x1 + y1 + x2 + y2);
    int secondPair = Math.Abs(x3 + y3 + x4 + y4);

    if (firstPair >= secondPair)
    {
        result[0] = (x1, y1);
        result[1] = (x2, y2);
    }
    else
    {
        result[0] = (x3, y3);
        result[1] = (x4, y4);
    }
    Array.Reverse(result);
    return result;
}

Console.WriteLine(string.Join("", ClosestPairToZero(x1,y1,x2,y2,x3,y3,x4,y4)));