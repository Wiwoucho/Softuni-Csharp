List<int> checkPoints = Console.ReadLine().Split().Select(int.Parse).ToList();

double player1 = 0;
double player2 = 0;

for (int i = 0; i < checkPoints.Count / 2; i++)
{
    double player1Checkpoint = checkPoints[i];
    double player2Checkpoint = checkPoints[checkPoints.Count - i - 1];


    player1 += checkPoints[i];
    player2 += player2Checkpoint;

    if (player1Checkpoint == 0)
    {
        player1 *= 0.8;
    }
    else if (player2Checkpoint == 0)
    {
        player2 *= 0.8;
    }
}


if (player1 < player2)
{
    string correctTIme = player1 % 1 == 0 ? player1.ToString() : player1.ToString("F1");

    Console.WriteLine($"The winner is left with total time: {correctTIme}");
}
else
{
    string correctTIme = player2 % 1 == 0 ? player2.ToString() : player2.ToString("F1");

    Console.WriteLine($"The winner is right with total time: {correctTIme}");
}