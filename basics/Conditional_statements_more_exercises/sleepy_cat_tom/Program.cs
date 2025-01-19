int days_for_break = int.Parse(Console.ReadLine());

int break_days_norm = 127;
int working_days_norm = 63;
int norm = 30000;

int total_time_for_playing = (break_days_norm * days_for_break) + ((365 - days_for_break) * working_days_norm);
int overfill_the_norm = total_time_for_playing - norm;

if (total_time_for_playing >= norm)
    {
    Console.WriteLine("Tom will run away");
    Console.WriteLine($"{overfill_the_norm / 60} hours and {overfill_the_norm % 60} minutes more for play");
    }
else
    {
    Console.WriteLine($"Tom sleeps well");
    Console.WriteLine($"{(norm - total_time_for_playing) / 60} hours and {(norm - total_time_for_playing) % 60} minutes less for play");
    }
