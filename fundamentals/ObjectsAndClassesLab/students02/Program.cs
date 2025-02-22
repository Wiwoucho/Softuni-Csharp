using System.Security.Cryptography.X509Certificates;

namespace students
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] student = Console.ReadLine().Split();

            List<Student> students = new List<Student>();

            while (student[0] != "end")
            {
                string firstName = student[0];
                string lastName = student[1];
                string age = student[2];
                string hometown = student[3];

                Student newStudent = new Student();

                newStudent.FirstName = firstName;
                newStudent.LastName = lastName;
                newStudent.Age = age;
                newStudent.Hometown = hometown;



                if (!IsUserExist(students, firstName, lastName))
                {
                    students.Add(newStudent);

                }
                else
                {
                   int studIndex =  students.IndexOf(students.First(st => st.FirstName == firstName && st.LastName == lastName));
                   students.RemoveAt(studIndex);
                   students.Insert(studIndex, newStudent);
                }


                student = Console.ReadLine().Split();

            }

            string city = Console.ReadLine();

            List<Student> filteredStudents = students.Where(students => students.Hometown == city).ToList();


            foreach (Student stud in filteredStudents)
            {
                Console.WriteLine($"{stud.FirstName} {stud.LastName} is {stud.Age} years old.");
            }
        }
        public static bool IsUserExist(List<Student> students, string firstName, string LastName)
        {
            foreach (Student stud in students)
            {
                if (stud.FirstName == firstName && stud.LastName == LastName)
                {
                    return true;
                }
                
            }
            return false;
        }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string Hometown { get; set; }
    }

}
