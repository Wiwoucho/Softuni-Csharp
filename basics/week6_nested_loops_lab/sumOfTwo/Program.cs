int startNum = int.Parse(Console.ReadLine());
int endNum = int.Parse(Console.ReadLine());
int magicNum = int.Parse(Console.ReadLine());

int counter =  0;

bool isFound = false;

for (int i = startNum; i <= endNum; i++)
{
    for (int j = startNum; j <= endNum; j++)
    {
        counter++;

        if (i + j == magicNum)
        {
            Console.WriteLine($"Combination N:{counter} ({i} + {j} = {i + j})");
            isFound = true;
            break;
        }
    }
    if (isFound)
    {
        break;
    }
}

if (!isFound)
{
    Console.WriteLine($"{counter} combinations - neither equals {magicNum} ");
}