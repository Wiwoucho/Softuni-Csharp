namespace MinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> materialsDict = new Dictionary<string, int>();

            while (true)
            {
                string material = Console.ReadLine();

                if (material == "stop")
                {
                    break;
                }

                int amount = int.Parse(Console.ReadLine());



                if (!materialsDict.ContainsKey(material))
                {
                    materialsDict.Add(material, 0);
                }

                materialsDict[material] += amount;

            }


            foreach ((string material, int amount) in materialsDict)
            {
                Console.WriteLine($"{material} -> {amount}");
            }

        }
    }
}
