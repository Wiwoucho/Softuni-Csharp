int annual_price = int.Parse(Console.ReadLine());

double sneakers_price = annual_price * 0.6;
double basketball_clothes = sneakers_price * 0.8;
double basketball_ball = basketball_clothes * 0.25;
double basketball_accessories = basketball_ball * 0.2;

double total = annual_price + sneakers_price + basketball_clothes + basketball_ball +  basketball_accessories;
Console.WriteLine(total);