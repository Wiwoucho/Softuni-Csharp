int n = int.Parse(Console.ReadLine());

List<string> brackets = new List<string>();
for (int i = 0; i < n; i++)
{   
    string symbol = Console.ReadLine();

    if (symbol == "(" || symbol == ")")
    {
        brackets.Add(symbol);
    }
}

string lastBracket = string.Empty;
bool isBalanced = false;

foreach (string b in brackets)
{
    if (brackets[0]  == ")" || lastBracket == b || brackets.Last() == "(")
    {
        isBalanced = false;
        break;
    }
    else
    {
        isBalanced = true;
    }

    lastBracket = b;
}

Console.WriteLine(isBalanced ? "BALANCED" : "UNBALANCED");