List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

int score = 0;


static int CorrectIndex(List<int> nums, int index)
{
    if (index > nums.Count - 1)
    {
        index = nums.Count - 1;
        return index;
    }
    else if (index < 0)
    {
        index = 0;
        return index;
    }
    return index;
}

static List<int> ListModify(List<int> nums, int number)
{
    for (int i = 0; i < nums.Count; i++)
    {
        if (nums[i] <= number)
        {
            nums[i] += number;
        }
        else
        {
            nums[i] -= number;
        }
    }
            return nums;
}



while (numbers.Count != 0)
{
    bool wrongIndex = false;

    int index = int.Parse(Console.ReadLine());

    if (index < 0 || index > numbers.Count - 1)
    {
         wrongIndex = true;
    }

    int correctIndex = CorrectIndex(numbers, index);
    int removedNumber = numbers[correctIndex];


    score += removedNumber;

    if (wrongIndex)
    {
        if (correctIndex == 0)
        {
            numbers[0] = numbers[numbers.Count - 1];
        }
        else
        {
            numbers[numbers.Count - 1] = numbers[0];
        }
    }
    else
    {
        numbers.RemoveAt(correctIndex);

    }

    ListModify(numbers, removedNumber);


}

Console.WriteLine(score);