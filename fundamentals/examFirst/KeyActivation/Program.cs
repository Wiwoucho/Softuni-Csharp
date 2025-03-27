using System.Text;

namespace Exams

{
    internal class Program
    {
        public static string Flip(string key, string type, int startIndex, int endIndex)
        {
            StringBuilder text = new StringBuilder(key);

            for (int i = startIndex; i < endIndex; i++)
            {
                if (type == "Upper")
                {
                    text[i] = char.ToUpper(text[i]);
                }
                else if (type == "Lower")
                {
                    text[i] = char.ToLower(text[i]);
                }
            }

            return text.ToString();
        }

        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string[] command = Console.ReadLine().Split(">>>");

            while (command[0] != "Generate")
            {
                switch (command[0])
                {
                    case "Contains":
                        string substring = command[1];

                        if (key.Contains(substring))
                        {
                            Console.WriteLine($"{key} contains {substring}");
                        }
                        else
                        {
                            Console.WriteLine("Substring not found!");
                        }
                        break;
                    case "Flip":

                        string type = command[1];
                        int startIndex = int.Parse(command[2]);
                        int endIndex = int.Parse(command[3]);

                        key = Flip(key, type, startIndex, endIndex);
                        Console.WriteLine(key);
                        break;

                    case "Slice":
                        startIndex = int.Parse(command[1]);
                        endIndex = int.Parse(command[2]);

                        key = key.Remove(startIndex, endIndex - startIndex);
                        Console.WriteLine(key);
                        break;
                }

                command = Console.ReadLine().Split(">>>");
            }
            Console.WriteLine($"Your activation key is: {key}");
        }
    }
}
