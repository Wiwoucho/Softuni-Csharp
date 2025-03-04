namespace Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<(decimal, int)>> products = new();

            while (true)
            {
                string[] information = Console.ReadLine().Split();

                string item = information[0];

                if (item == "buy")
                {
                    foreach(var key in products)
                    {
                        Console.WriteLine($"{key.Key} -> {key.Value.Sum(product => product.Item1 * product.Item2)}");
                    }

                    break;
                }

                decimal price = decimal.Parse(information[1]);
                int quantity = int.Parse(information[2]);

                if (!products.ContainsKey(item))
                {
                    products.Add(item, new List<(decimal, int)> {(decimal.Zero, 0)} );
                }

                var product = products[item];
                product[0] = (price , quantity + product[0].Item2);
            }
        }
    }
}
