double pen_price = 5.8;
double marker_price = 7.2;
double preparat_per_liter = 1.2;

int pens_quantity = int.Parse(Console.ReadLine());
int markers_quantity = int.Parse(Console.ReadLine());
double preparat_quantity = double.Parse(Console.ReadLine());
double discount_percentage = double.Parse(Console.ReadLine()) / 100;

double total_without_discount = (pens_quantity * pen_price) + (markers_quantity * marker_price) + (preparat_quantity * preparat_per_liter);
double total = total_without_discount - (total_without_discount * discount_percentage);

Console.WriteLine(total);