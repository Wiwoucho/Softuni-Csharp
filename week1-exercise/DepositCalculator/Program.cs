double deposited_sum = double.Parse(Console.ReadLine());
double deposit_term = double.Parse(Console.ReadLine());
double annual_interest_rate = double.Parse(Console.ReadLine()) / 100;

double total_sum = deposited_sum + deposit_term * ((deposited_sum * annual_interest_rate) / 12);

Console.WriteLine(total_sum);
