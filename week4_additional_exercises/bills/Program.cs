int n = int.Parse(Console.ReadLine());

double electricityBill = 0;
double waterBill = 0;
double internetBill = 0;
double unexpectedBills = 0;


int water = 20;
int internet = 15;

for (int i = 0; i < n; i++)
{
    double electricityForTheMonth = double.Parse(Console.ReadLine());
    electricityBill += electricityForTheMonth;
    waterBill += 20;
    internetBill += 15;
    unexpectedBills += (electricityForTheMonth + water + internet) * 1.2; 
}

Console.WriteLine($"Electricity: {electricityBill:f2} lv");
Console.WriteLine($"Water: {waterBill:f2} lv");
Console.WriteLine($"Internet: {internetBill:f2} lv");
Console.WriteLine($"Other: {unexpectedBills:f2} lv");
Console.WriteLine($"Average {(electricityBill + waterBill + internetBill + unexpectedBills) / n:f2}");