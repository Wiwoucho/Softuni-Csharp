namespace ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(", ");

            List<string> validNames = new();

            foreach (string name in text)
            {
                if (name.Length >= 3 && name.Length <= 16)
                {
                    bool isValid = true;
                    foreach (char symbol in name)
                    {
                        if (!char.IsLetterOrDigit(symbol) && symbol != '-' && symbol != '_')
                        {
                            isValid = false;
                            break;
                        }
                    }
                    if (isValid)
                    {
                        validNames.Add(name);
                    }


                }

            }
            Console.WriteLine(string.Join("\n", validNames));
        }
    }
}
