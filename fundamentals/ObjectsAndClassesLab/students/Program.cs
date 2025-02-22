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

                students.Add(newStudent);

                student = Console.ReadLine().Split();

            }

            string city = Console.ReadLine();

            List<Student> filteredStudents = students.Where(students => students.Hometown == city).ToList();
            

            foreach (Student stud in filteredStudents)
            {
                Console.WriteLine($"{stud.FirstName} {stud.LastName} is {stud.Age} years old.");
            }
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
