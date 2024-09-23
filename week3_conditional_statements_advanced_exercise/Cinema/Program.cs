string ticketType = Console.ReadLine();
int rows = int.Parse(Console.ReadLine());
int cols = int.Parse(Console.ReadLine());

double ticketPrice = 0;

switch (ticketType)
{
    case "Premiere":
        ticketPrice = 12; // ticketPrice for single premiere ticket
        break;

    case "Normal":
        ticketPrice = 7.5; // ticketPrice for single normal ticket
        break;

    case "Discount":
        ticketPrice = 5; // ticketPrice for single discount ticket
        break;

}

Console.WriteLine($"{rows * cols * ticketPrice:f2}");
