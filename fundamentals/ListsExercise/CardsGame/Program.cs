using System.ComponentModel;

List<int> deck1 = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> deck2 = Console.ReadLine().Split().Select(int.Parse).ToList();


while (deck1.Any() && deck2.Any())
{
    if (deck1[0] > deck2[0])
    {
        int losingCard = deck2[0];
        int winningCard = deck1[0];

        deck2.RemoveAt(0);
        deck1.RemoveAt(0);

        deck1.Add(losingCard);
        deck1.Add(winningCard);
    }

    else if (deck1[0] < deck2[0])
    {
        int losingCard = deck1[0];
        int winningCard = deck2[0];

        deck2.RemoveAt(0);
        deck1.RemoveAt(0);

        deck2.Add(losingCard);
        deck2.Add(winningCard);
    }
    else
    {
        deck1.RemoveAt(0);
        deck2.RemoveAt(0);
    }
}

if (deck1.Any())
{
    Console.WriteLine($"First player wins! Sum: {deck1.Sum()}");
}
else
{
    Console.WriteLine($"Second player wins! Sum: {deck2.Sum()}");

}