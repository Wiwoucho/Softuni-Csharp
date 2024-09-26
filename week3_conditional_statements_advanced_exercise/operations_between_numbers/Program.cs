double n1 = double.Parse(Console.ReadLine());
double n2 = double.Parse(Console.ReadLine());
var operators = Console.ReadLine();


double result = 0;


switch (operators)
{
    case "*":
        result = n1 * n2;
        Console.WriteLine($"{n1} {operators} {n2} = {result} - {(result % 2 == 0 ? "even" : "odd")}");
        break;

    case "-":
        result = n1 - n2;
        Console.WriteLine($"{n1} {operators} {n2} = {result} - {(result % 2 == 0 ? "even" : "odd")}");
        break;

    case "+":
        result = n1 + n2;
        Console.WriteLine($"{n1} {operators} {n2} = {result} - {(result % 2 == 0 ? "even" : "odd")}");
        break;

    case "/":
        if (n2 == 0)
        {
            Console.WriteLine($"Cannot divide {n1} by zero");
        }
        else
        {
            result = n1 / n2;
            Console.WriteLine($"{n1} {operators} {n2} = {result:f2}");
        }
        break;

    case "%":
        if (n2 == 0)
        {
            Console.WriteLine($"Cannot divide {n1} by zero");
        }
        else
        {
            result = n1 % n2;
            Console.WriteLine($"{n1} {operators} {n2} = {(n1%n2)}");
        }
        break;

}


