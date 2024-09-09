double w = double.Parse(Console.ReadLine()) *100; // converting the meters to cm and reducing by 100 due to the coridor in the middle of the room
double h = double.Parse(Console.ReadLine()) *100;


int desk_w = 120;
int desk_h = 70;
int space_taken_from_furniture = 3;

double total_desks_w = Math.Floor(w / desk_w);
double total_desks_h = Math.Floor((h-100) / desk_h);

double total_desks = (total_desks_w * total_desks_h) - space_taken_from_furniture;

Console.WriteLine(total_desks);