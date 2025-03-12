using System.Text;

namespace multiplyBigNumbers
{
    internal class Program
    {

        static string MultiplyBigNumbers(string number, string multiplier)
        {
            if (number == "0" || multiplier == "0")
            {
                return "0";
            }

            StringBuilder result = new StringBuilder();
            int remainder = 0;


            for (int i = number.Length - 1; i >= 0; i--)
            {
                int currentNumber = int.Parse(number[i].ToString());
                int currentResult = currentNumber * int.Parse(multiplier) + remainder;
                if (currentResult > 9)
                {
                    remainder = currentResult / 10;
                    currentResult %= 10;
                }
                else
                {
                    remainder = 0;
                }
                result.Insert(0, currentResult);
            }
            if (remainder > 0)
            {
                result.Insert(0, remainder);
            }
            return result.ToString();
        }
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            string multiplier = Console.ReadLine();

            string result = MultiplyBigNumbers(number, multiplier);
            Console.WriteLine(result);
        }
    }
}
