namespace CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split("->");
            Dictionary<string, List<string>> CompanyEmployees = new ();

            while (text[0] != "End")
            {
                string companyName = text[0];
                string employeeID= text[1];

                if (!CompanyEmployees.ContainsKey(companyName))
                {
                    CompanyEmployees.Add(companyName, new List<string>());
                    CompanyEmployees[companyName].Add(employeeID);
                }
                else
                {
                    if (!CompanyEmployees[companyName].Contains(employeeID))
                    {
                       CompanyEmployees[companyName].Add(employeeID);
                    }
                }

                text = Console.ReadLine().Split("->");
            }

            foreach (var (company, employees) in CompanyEmployees)
            {
                Console.WriteLine($"{company} \n--{string.Join("\n--", employees)}");
            }
        }
    }
}
