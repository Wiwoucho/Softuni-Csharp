using System.Text.RegularExpressions;

namespace BarIncome
{
    class Item
    {
        public string customer { get; set; }
        public string product { get; set; }
        public int count { get; set; }
        public double price { get; set; }

        public double totalIncome { get; set; }




        public Item(string customer, string product, int count, double price, double totalIncome)
        {
            this.customer = customer;
            this.product = product;
            this.count = count;
            this.price = price;
            this.totalIncome = totalIncome;
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                List<Item> items = new List<Item>();

                string pattern = @"%(?<customer>[A-Z][a-z]+)%[^|$%.]*?<(?<product>\w+)>[^|$%.]*?\|(?<count>\d+)\|[^|$%.]*?(?<price>\d+(\.\d+)?)\$";
                string input;
                double totalIncome = 0;

                while ((input = Console.ReadLine()) != "end of shift")
                {
                    Match match = Regex.Match(input, pattern);


                    if (match.Success)
                    {
                        string customer = match.Groups["customer"].Value;
                        string product = match.Groups["product"].Value;
                        int count = int.Parse(match.Groups["count"].Value);
                        double price = double.Parse(match.Groups["price"].Value);
                        totalIncome += count * price;

                        Item item = new Item(customer, product, count, price, (count * price));

                        Item existingItem = items.FirstOrDefault(i => i.customer == customer && i.product == product);

                        if (existingItem == null)
                        {
                            items.Add(item);
                        }
                        else
                        {
                            existingItem.totalIncome += count * price;
                        }
                    }
                }

                foreach (Item item in items)
                {
                    Console.WriteLine($"{item.customer}: {item.product} - {item.totalIncome:f2}");
                }
                Console.WriteLine($"Total income: {totalIncome:F2}");
            }
        }
    }
}
