using System.Diagnostics.CodeAnalysis;

string password = Console.ReadLine();


static bool IsValidLenght(string password)
{
    if (password.Length < 6 || password.Length > 10)
    {
        return false;
    }
    return true;
}

static bool IsLettersAndDigits(string password)
{
    foreach (char c in password)
    {
        if (!((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z')))
        {
            return false;
        }
    }

    return true;
}

static bool IsContainTwoDigits(string password)
{
    int sum = 0;

    foreach(char c in password)
    {
        if (c >= 48 && c <= 57)
        {
            sum++;
        }
    }

    if (sum < 2)
    {
        return false;
    }


    return true;
}

if (!IsValidLenght(password))
{
    Console.WriteLine("Password must be between 6 and 10 characters");
}

if (!IsLettersAndDigits(password))
{
    Console.WriteLine("Password must consist only of letters and digits");
}
if (!IsContainTwoDigits(password))
{
    Console.WriteLine("Password must have at least 2 digits");
}

if (IsValidLenght(password)
    && IsLettersAndDigits(password)
    && IsContainTwoDigits(password))
{
    Console.WriteLine("Password is valid");
}