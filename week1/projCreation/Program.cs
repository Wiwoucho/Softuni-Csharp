int time_per_project = 3;

string name = Console.ReadLine();
int project_count = int.Parse(Console.ReadLine());

int total_hours = time_per_project * project_count;

Console.WriteLine($"The architect {name} will need {total_hours} hours to complete {project_count} project/s.");


