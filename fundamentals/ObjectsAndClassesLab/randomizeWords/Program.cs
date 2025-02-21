using System;


class Program
{
    static void Main()
    {
        string text = Console.ReadLine();
        string[] words = text.Split(' ');
        Random rnd = new Random();
        for (int i = 0; i < words.Length; i++)
        {
            int randomIndex = rnd.Next(words.Length);
            string temp = words[i];
            words[i] = words[randomIndex];
            words[randomIndex] = temp;
        }

        foreach (string word in words)
        {
            Console.WriteLine(word);
        }

    }
}
