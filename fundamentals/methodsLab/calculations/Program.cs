static int Calculations(string operation, int a, int b)
{
    int result = 0;

    if (operation == "add")
    {
        result = a + b;
    }
    else if(operation == "multiply")
    {
        result = a * b;
    }
    else if (operation == "subtract")
    {
        result = a - b;
    }
    else
    {
        result = a / b;
    }

    return result;
}

string operation = Console.ReadLine();
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());


Console.WriteLine(Calculations(operation, a, b));