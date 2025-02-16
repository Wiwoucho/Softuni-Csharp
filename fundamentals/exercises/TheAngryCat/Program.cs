List<int> priceRatings = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
int entryPoint = int.Parse(Console.ReadLine());

string typeOfItems = Console.ReadLine();
int numberBorder = priceRatings[entryPoint];


List<int> leftSide = new List<int>();
List<int> rightSide = new List<int>();


for (int i = 0; i <= 1; i++)
{
    if (i == 0)
    {
        if (typeOfItems == "cheap")
        {
            List<int> tempList = priceRatings.GetRange(0, entryPoint);
            leftSide = tempList.Where(x => x < numberBorder).ToList();
        }
        else 
        {
            List<int> tempList = priceRatings.GetRange(0, entryPoint);
            leftSide = tempList.Where(x => x >= numberBorder).ToList();
        }
    }
    else if (i == 1)
    {
        if (typeOfItems == "expensive")
        {
            List<int> tempList = priceRatings.GetRange(entryPoint + 1, priceRatings.Count - entryPoint - 1);
            rightSide = tempList.Where(x => x >= numberBorder).ToList();
        }
        else
        {
            List<int> tempList = priceRatings.GetRange(entryPoint + 1, priceRatings.Count - entryPoint - 1);
            rightSide = tempList.Where(x => x < numberBorder).ToList();
        }
    }
}

if (leftSide.Sum() >= rightSide.Sum())
{
    Console.WriteLine($"Left - {leftSide.Sum()}");
}
else
{
    Console.WriteLine($"Right - {rightSide.Sum()}");
}