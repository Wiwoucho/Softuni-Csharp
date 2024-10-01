string actorName = Console.ReadLine();
double academicPoints = double.Parse(Console.ReadLine());
int assessorsCount = int.Parse(Console.ReadLine());

double totalPoints = academicPoints;
bool actorNominated = false;

for (int i = 0; i < assessorsCount; i++)
{
    string assessorName = Console.ReadLine();
    double assessorPoints = double.Parse(Console.ReadLine());
    totalPoints += assessorName.Length * assessorPoints / 2;
    if (totalPoints > 1250.5)
    {
        actorNominated = true;
        Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {totalPoints:f1}!");
        break;
    }
}

if (!actorNominated)
{
    Console.WriteLine($"Sorry, {actorName} you need {1250.5 - totalPoints:f1} more!");
} 
