﻿int n = int.Parse(Console.ReadLine());

int currentNumber = 1;

        
for (int row = 1; currentNumber <= n; row++)
{
            
    for (int col = 1; col <= row; col++)
    {
        if (currentNumber > n)
        break;
            
        Console.Write(currentNumber + " ");
        currentNumber++;
    }
    Console.WriteLine(); 
}