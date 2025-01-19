double chikenMenuPrice = 10.35;
double fishMenuPrice = 12.4;
double vegetarianMenuPrice = 8.15;

int chickenMenu = int.Parse(Console.ReadLine());
int fishMenu = int.Parse(Console.ReadLine());
int vegetarianMenu = int.Parse(Console.ReadLine());

double totalPriceMenus = (chickenMenu * chikenMenuPrice) + (fishMenu * fishMenuPrice) + (vegetarianMenu * vegetarianMenuPrice);
double deserts = totalPriceMenus * 0.2;
double total_sum = totalPriceMenus + deserts + 2.5;

Console.WriteLine(total_sum);
