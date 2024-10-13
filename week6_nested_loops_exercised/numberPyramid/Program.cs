using System;

class Program
{
    static void Main()
    {
        // Четене на число n от потребителя
        Console.Write("Въведете число n: ");
        int n = int.Parse(Console.ReadLine());

        int currentNumber = 1;

        // Външен цикъл за редовете
        for (int row = 1; currentNumber <= n; row++)
        {
            // Вътрешен цикъл за отпечатване на числа в съответния ред
            for (int col = 1; col <= row; col++)
            {
                if (currentNumber > n)
                    break; // Излизане от цикъла, ако числото надвиши n

                Console.Write(currentNumber + " ");
                currentNumber++;
            }
            Console.WriteLine(); // Прехвърляне на нов ред след всеки ред от пирамидата
        }
    }
}
