namespace StoreBoxes
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split();

            List<Box> box = new List<Box>();

            while (command[0] != "end")
            {
                string serialNumber = command[0];
                string itemName = command[1];
                int intemQuantity = int.Parse(command[2]);
                double itemPrice = double.Parse(command[3]);

                Box newBox = new Box();

                newBox.SerialNumber = serialNumber;
                newBox.Item.Name = itemName;
                newBox.Quantity = intemQuantity;
                newBox.Price = itemPrice;
                newBox.Item.Price = itemPrice;

                box.Add(newBox);

                command = Console.ReadLine().Split();
            }

            box.Sort((x, y) => (y.Price * y.Quantity).CompareTo((x.Price * x.Quantity)));

            foreach (Box b in box)
            {
                Console.WriteLine(b.SerialNumber);
                Console.WriteLine($"-- {b.Item.Name} - ${b.Item.Price:F2}: {b.Quantity}");
                Console.WriteLine($"-- ${b.Price * b.Quantity:F2}");
            }
        }
    }

    class Box
    {
        public Box()
        {
            Item = new Item();
        }

        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
    class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
}