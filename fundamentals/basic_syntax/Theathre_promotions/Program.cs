string dayType = Console.ReadLine();
int age = int.Parse(Console.ReadLine());

string ticketPriceOrError = "";
switch (dayType)
{
    case "Weekday":
        if (age >= 0 && age <= 18)
        {
            ticketPriceOrError = "12$";
        }
        else if (age > 18 && age <= 64)
        {
            ticketPriceOrError = "18$";
        }
        else if (age > 64 && age <= 122)
        {
            ticketPriceOrError = "12$";
        }
        else
        {
            ticketPriceOrError = "Error!";
        }
        break;

    case "Weekend":
        if (age >= 0 && age <= 18)
        {
            ticketPriceOrError = "15$";
        }
        else if (age > 18 && age <= 64)
        {
            ticketPriceOrError = "20$";
        }
        else if (age > 64 && age <= 122)
        {
            ticketPriceOrError = "15$";
        }
        else
        {
            ticketPriceOrError = "Error!";
        }
        break;

    case "Holiday":
        if (age >= 0 && age <= 18)
        {
            ticketPriceOrError = "5$";
        }
        else if (age > 18 && age <= 64)
        {
            ticketPriceOrError = "12$";
        }
        else if (age > 64 && age <= 122)
        {
            ticketPriceOrError = "10$";
        }
        else
        {
            ticketPriceOrError = "Error!";
        }
        break;
}

Console.WriteLine(ticketPriceOrError);