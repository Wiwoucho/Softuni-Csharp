int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

string[] command = Console.ReadLine().Split();

while (command[0] != "end")
{
    switch (command[0])
    {
        case "exchange":
            int index = int.Parse(command[1]);
            if (ExchangeIndex(arr, index) != null)
            {

                int[] result = ExchangeIndex(arr, index);
                arr = result;
                break;
            }
            else
            {
                Console.WriteLine("Invalid index");
                break;
            }

        case "max":
            if (command[1] == "even")
            {
                Console.WriteLine(MaxEvenIndex(arr));
            }
            else
            {
                Console.WriteLine(MaxOddIndex(arr));
            }
            break;

        case "min":
            if (command[1] == "even")
            {
                Console.WriteLine(MinEvenIndex(arr));
            }
            else
            {
                Console.WriteLine(MinOddIndex(arr));
            }
            break;

        case "first":
            if (command[2] == "even")
            {
                Console.WriteLine(FirstEvenNumbers(arr, int.Parse(command[1])));
            }

            else
            {
                Console.WriteLine(FirstOddNumbers(arr, int.Parse(command[1])));
            }
            break;

        case "last":
            if (command[2] == "even")
            {
                Console.WriteLine(LastEvenNumbers(arr, int.Parse(command[1])));
            }
            else
            {
                Console.WriteLine(LastOddNumber(arr, int.Parse(command[1])));
            }
            break;
    }

    command = Console.ReadLine().Split();
}

Console.WriteLine($"[{string.Join(", ", arr)}]");


static int[] ExchangeIndex(int[] nums, int index)
{


    if (index >= 0 && index < nums.Length)
    {
        int[] sliceLeftPart = nums[0..(index + 1)];
        int[] sliceRightPart = nums[(index + 1)..];
        return sliceRightPart.Concat(sliceLeftPart).ToArray();
    }


    return null;
}


static object MaxEvenIndex(int[] nums)
{
    int index = 0;
    int topNumber = int.MinValue;
    bool isFind = false;

    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] % 2 == 0)
        {
            if (topNumber <= nums[i])
            {
                topNumber = nums[i];
                isFind = true;
                index = i;
            }
        }
    }

    if (isFind)
    {
        return index;
    }
    return "No matches";
}

static object MaxOddIndex(int[] nums)
{
    int index = 0;
    int topNumber = int.MinValue;
    bool isFind = false;

    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] % 2 != 0)
        {
            if (topNumber <= nums[i])
            {
                topNumber = nums[i];
                isFind = true;
                index = i;
            }
        }
    }

    if (isFind)
    {
        return index;
    }
    return "No matches";
}

static object MinEvenIndex(int[] nums)
{
    int index = 0;
    int lowestNum = int.MaxValue;
    bool isFind = false;

    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] % 2 == 0)
        {
            if (lowestNum >= nums[i])
            {
                lowestNum = nums[i];
                isFind = true;
                index = i;
            }
        }
    }

    if (isFind)
    {
        return index;
    }
    return "No matches";
}
static object MinOddIndex(int[] nums)
{
    int index = 0;
    int lowestNum = int.MaxValue;
    bool isFind = false;

    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] % 2 != 0)
        {
            if (lowestNum >= nums[i])
            {
                lowestNum = nums[i];
                isFind = true;
                index = i;
            }
        }
    }

    if (isFind)
    {
        return index;
    }
    return "No matches";
}

static string FirstEvenNumbers(int[] nums, int count)
{
    if (nums.Length < count)
    {
        return "Invalid count";
    }

    int[] newArray = new int[0];
    int counter = 0;

    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] % 2 == 0)
        {
            if (counter >= count)
            {
                break;
            }
            Array.Resize(ref newArray, newArray.Length + 1);
            newArray[counter] = nums[i];
            counter++;
        }
    }
    return $"[{string.Join(", ", newArray)}]";
}

static string FirstOddNumbers(int[] nums, int count)
{
    if (nums.Length < count)
    {
        return "Invalid count";
    }

    int[] newArray = new int[0];
    int counter = 0;

    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] % 2 != 0)
        {
            if (counter >= count)
            {
                break;
            }
            Array.Resize(ref newArray, newArray.Length + 1);
            newArray[counter] = nums[i];
            counter++;
        }
    }
    return $"[{string.Join(", ", newArray)}]";
}

static string LastEvenNumbers(int[] nums, int count)
{
    int[] reversedArray = (int[])nums.Clone();
    Array.Reverse(reversedArray);
    if (nums.Length < count)
    {
        return "Invalid count";
    }

    int[] newArray = new int[0];
    int counter = 0;

    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] % 2 == 0)
        {
            if (counter >= count)
            {
                break;
            }
            Array.Resize(ref newArray, newArray.Length + 1);
            newArray[counter] = reversedArray[i];
            counter++;
        }
    }
    Array.Reverse(newArray);
    return $"[{string.Join(", ", newArray)}]";
}

static string LastOddNumber(int[] nums, int count)
{
    int[] reversedArray = (int[])nums.Clone();
    Array.Reverse(reversedArray);
    if (nums.Length < count)
    {
        return "Invalid count";
    }

    int[] newArray = new int[0];
    int counter = 0;

    for (int i = 0; i < nums.Length; i++)
    {
        if (reversedArray[i] % 2 != 0)
        {
            if (counter >= count)
            {
                break;
            }
            Array.Resize(ref newArray, newArray.Length + 1);
            newArray[counter] = reversedArray[i];
            counter++;
        }
    }
    Array.Reverse(newArray);
    return $"[{string.Join(", ", newArray)}]";
}