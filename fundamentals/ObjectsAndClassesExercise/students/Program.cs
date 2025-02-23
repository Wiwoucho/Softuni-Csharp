namespace students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] student = Console.ReadLine().Split();

                string firstName = student[0];
                string lastName = student[1];
                double grade = double.Parse(student[2]);

                Student newStudent = new Student(firstName, lastName, grade);
                students.Add(newStudent);
            }

            foreach (Student student in students.OrderByDescending(stud => stud.grade))
            {
                Console.WriteLine(student.ToString());
            }
        }
    }

    class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public double grade { get; set; }

        public Student(string firstName, string lastName, double grade)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.grade = grade;
        }

        public override string ToString()
        {
            return $"{firstName} {lastName}: {grade:F2}";
        }
        
    }
}

