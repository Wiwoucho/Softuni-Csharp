string numbers = Console.ReadLine();


while (numbers != "END")
{
    Console.WriteLine(IsPalindrome(numbers));
    numbers = Console.ReadLine();
}
static bool IsPalindrome(string input)
{
    return input.SequenceEqual(input.Reverse());
}


