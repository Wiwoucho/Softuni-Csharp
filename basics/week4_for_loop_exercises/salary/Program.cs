int openedTabs = int.Parse(Console.ReadLine());
double salary = double.Parse(Console.ReadLine());

for (int i = 0; i < openedTabs; i++)
{
    string currenetTab = Console.ReadLine();

    switch (currenetTab)
    {
        case "Facebook":
            salary -= 150;
            break;
        case "Instagram":
            salary -= 100;
            break;
        case "Reddit":
            salary -= 50;
            break;
    }
    if (salary <= 0)
    {
        Console.WriteLine("You have lost your salary.");
        break;
    }
}

if (salary > 0)
{
    Console.WriteLine(salary);
}