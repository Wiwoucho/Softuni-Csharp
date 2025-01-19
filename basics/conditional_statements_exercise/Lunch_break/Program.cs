string movieName = Console.ReadLine();
int movie_length = int.Parse(Console.ReadLine());
int break_lenght = int.Parse(Console.ReadLine());

double time_for_lunch = break_lenght * 0.125; // lunch is 12.5% of the break time
double time_for_relax = break_lenght * 0.25; // relax is 25% of the break time

double isTimeEnoughForMovie = break_lenght - time_for_lunch - time_for_relax;

if (isTimeEnoughForMovie >= movie_length)
{
    Console.WriteLine($"You have enough time to watch {movieName} and left with {Math.Ceiling(isTimeEnoughForMovie - movie_length)} minutes free time.");
}
else
{
    Console.WriteLine($"You don't have enough time to watch {movieName}, you need {Math.Ceiling(movie_length - isTimeEnoughForMovie)} more minutes.");
}