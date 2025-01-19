double record_in_seconds = double.Parse(Console.ReadLine());
double lenght_in_meters = double.Parse(Console.ReadLine());
double time_for_swimming_one_meter = double.Parse(Console.ReadLine());


double player_time = lenght_in_meters * time_for_swimming_one_meter;
double water_resistance = Math.Floor(lenght_in_meters / 15);       //water resistance slowing him down with 12.5 sec per 15 meters
double water_resistance_in_seconds = water_resistance * 12.5;
player_time += water_resistance_in_seconds;

if (player_time >= record_in_seconds) 
{
    Console.WriteLine($"No, he failed! He was {player_time - record_in_seconds:f2} seconds slower.");
}
else
{
    Console.WriteLine($" Yes, he succeeded! The new world record is {player_time:f2} seconds.");
}