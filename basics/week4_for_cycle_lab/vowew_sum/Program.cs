string text = Console.ReadLine();

int sum = 0;

Dictionary<char, int> vowews = new Dictionary<char, int> 
{
    {'a' , 1},
    {'e' , 2},
    {'i' , 3},
    {'o' , 4},
    {'u' , 5}
};

for (int i = 0; i < text.Length; i++)
{
    if (vowews.ContainsKey(text[i]))
    {
    sum += vowews[text[i]];
    }
}

Console.WriteLine(sum);