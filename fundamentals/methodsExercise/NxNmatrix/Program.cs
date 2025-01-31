int number = int.Parse(Console.ReadLine());

static void Matrix(int number)
{
    for (int i = 0; i < number; i++)
    {
        for (int j = 0; j < number; j++)
        {
            if (j == number - 1)
            {
                Console.WriteLine($"{number} ");
            }
            else
            {
                Console.Write($"{number} ");
            }
        }
    }
}

Matrix(number);