
using System.Diagnostics.Metrics;

List<string> data = Console.ReadLine().Split().ToList();
string[] command = Console.ReadLine().Split().ToArray();

static List<string> Merge(List<string> data, int startIndex, int endIndex)
{

    if (endIndex > data.Count - 1)
    {
        endIndex = data.Count - 1;
    }

    if (startIndex < 0 || startIndex > data.Count - 1)
    {
        startIndex = 0;
    }

    string concatenated = string.Join("", data.GetRange(startIndex, endIndex - startIndex + 1));
    data.RemoveRange(startIndex, endIndex - startIndex + 1);

    data.Insert(startIndex, concatenated);

    return data;
}


static List<string> Divide(List<string> data, int index, int partitions)
{
    string stringToDevide = data[index];
    List<string> result = new List<string>();

    data.RemoveAt(index);


    int partSize = stringToDevide.Length / partitions;
    int reminder = stringToDevide.Length % partitions;
    if (partSize == 0)
    {
        partSize = reminder;
        reminder = 0;
    }

    for (int i = 0; i < stringToDevide.Count(); i += partSize)
    {
        if (i == stringToDevide.Count() - partSize && reminder != 0)
        {
            string part = stringToDevide.Substring(0, partSize + reminder);
            result.Add(part);
        }
        else
        {
            string partToAdd = stringToDevide.Substring(i, partSize);
            result.Add(partToAdd);
        }




    }

    data.InsertRange(index, result);

    return data;
}

while (command[0] != "3:1")
{
    int startIndex = int.Parse(command[1]);
    int endIndex = int.Parse(command[2]);

    if (command[0] == "merge")
    {
        data = Merge(data, startIndex, endIndex);
    }
    else
    {
        int index = int.Parse(command[1]);
        int partitions = int.Parse(command[2]);

        data = Divide(data, index, partitions);
    }

    Console.WriteLine(string.Join(" ", data));
    command = Console.ReadLine().Split().ToArray();
}

Console.WriteLine(string.Join(" ", data));