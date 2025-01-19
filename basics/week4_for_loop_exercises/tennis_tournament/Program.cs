int tournamentCount = int.Parse(Console.ReadLine());
int startingPoints = int.Parse(Console.ReadLine());

double totalWins = 0;
double totalPoints = startingPoints;     // adding the starting points to the total points pot

for (int i = 0; i < tournamentCount; i++)
{ 
    string tournamentExit = Console.ReadLine();
    
    switch (tournamentExit)
    {
        case "W":
            totalWins += 1;
            totalPoints += 2000;
            break;

        case "F":
            totalPoints += 1200;
            break;

        case "SF":
            totalPoints += 720;
            break;
    }
}

Console.WriteLine($"Final points: {totalPoints}");
Console.WriteLine($"Average points: {Math.Floor((totalPoints - startingPoints) / tournamentCount)}");
Console.WriteLine($"{totalWins / tournamentCount * 100:f2}%");
  