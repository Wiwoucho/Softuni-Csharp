List<string> subjects = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

string[] command = Console.ReadLine().Split(":").ToArray();


while (command[0] != "course start")
{
    string option = command[0];
    string lessonsTitle = command[1];

    if (option == "Add")
    {
        if (!subjects.Contains(lessonsTitle))
        {
            subjects.Add(lessonsTitle);
        }

    }
    else if (option == "Insert")
    {
        int index = int.Parse(command[2]);

        if (!subjects.Contains(lessonsTitle))
        {
            subjects.Insert(index, lessonsTitle);
        }
    }
    else if (option == "Remove")
    {
        if (subjects.Contains(lessonsTitle))
        {
            subjects.Remove(lessonsTitle);   
        }
    }
    else if (option == "Swap")
    {
        string lessonsTitle2 = command[2];

        if (subjects.Contains(lessonsTitle) && subjects.Contains(lessonsTitle2))
        {
            bool exercise1 = false;
            bool exercise2 = false;

            int index1 = subjects.IndexOf(lessonsTitle);
            int index2 = subjects.IndexOf(lessonsTitle2);
            if (subjects.Contains(lessonsTitle + "-Exercise"))
            {
                 
                subjects.RemoveAt(subjects.IndexOf(lessonsTitle + "-Exercise"));
                exercise1 = true;
            }
            if (subjects.Contains(lessonsTitle2 + "-Exercise"))
            {
                subjects.RemoveAt(subjects.IndexOf(lessonsTitle2 + "-Exercise"));
                exercise2 = true;
            }

            string tempSubject = subjects[index1];

            subjects[index1] = lessonsTitle2;
            if(exercise1)
            {
                subjects.Insert(index2 + 1, lessonsTitle + "-Exercise");
            }

            subjects[index2] = tempSubject;
            if (exercise2)
            {
                subjects.Insert(index1 + 1, lessonsTitle2 + "-Exercise");
            }


 
        }

    }
    else if (option == "Exercise")
    {
        if (subjects.Contains(lessonsTitle))
        {
            int index = subjects.IndexOf(lessonsTitle);
            string exercise = lessonsTitle + "-Exercise";

            if (!subjects.Contains(exercise))
            {
                subjects.Insert(index + 1, exercise);
            }
        }
        else
        {
            subjects.Add(lessonsTitle);
            subjects.Add(lessonsTitle + "-Exercise");
        }
    }
    command = Console.ReadLine().Split(":").ToArray();
}

for (int i = 0; i < subjects.Count; i++)
{
    Console.WriteLine($"{i + 1}.{subjects[i]}");
}









////Methods, Lists, arrays, databases, databases-excercise