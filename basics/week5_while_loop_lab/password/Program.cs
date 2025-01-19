string username = Console.ReadLine();
string password = Console.ReadLine();


string pass = "";

while (pass != password)
{
    pass = Console.ReadLine();
}

if (pass == password)
{
    Console.WriteLine($"Welcome {username}!");
}