int n = int.Parse(Console.ReadLine());

double number = 0;

// hystogram
int numbers0To9 = 0;
int numbers10To19 = 0;
int numbers20To29 = 0;
int numbers30To39 = 0;
int numbers40To50 = 0;
int invalidNumbers = 0;


for (int i = 0; i < n; i++)
{
    double current_number = double.Parse(Console.ReadLine());


    if (current_number >= 0 && current_number <= 9)
    {
        number += current_number * 0.2;
        numbers0To9++;
    }

    else if (current_number >= 10 && current_number <= 19)
    {
        number += current_number * 0.3;
        numbers10To19++;
    }

    else if (current_number >= 20 && current_number <= 29)
    {
        number += current_number * 0.4;
        numbers20To29++;
    }

    else if (current_number >= 30 && current_number <= 39)
    {
        number += 50;
        numbers30To39++;
    }

    else if (current_number >= 40 && current_number <= 50)
    {
        number += 100;
        numbers40To50++;
    }

    else
    {
        invalidNumbers++;
        number /= 2;
    }
}

double totalNumbers  = numbers0To9 + numbers10To19 + numbers20To29 + numbers30To39 + numbers40To50 + invalidNumbers;

Console.WriteLine($"{number:f2}");
Console.WriteLine($"From 0 to 9: {numbers0To9 / totalNumbers * 100:f2}%");
Console.WriteLine($"From 10 to 19: {numbers10To19 / totalNumbers * 100:f2}%");
Console.WriteLine($"From 20 to 29: {numbers20To29 / totalNumbers * 100:f2}%");
Console.WriteLine($"From 30 to 39: {numbers30To39 / totalNumbers * 100:f2}%");
Console.WriteLine($"From 40 to 50: {numbers40To50 / totalNumbers * 100:f2}%");
Console.WriteLine($"Invalid numbers: {invalidNumbers / totalNumbers * 100:f2}%");