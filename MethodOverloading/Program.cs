namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int numOne, int numtwo)
        {
            return numOne + numtwo;
        }

        public static decimal Add(decimal numOne, decimal numTwo)
        {
            return numOne + numTwo;
        }

        public static string Add(int numOne, int numTwo, bool iscurrency)
        {
            var sum = numOne + numTwo;
            if (iscurrency && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (iscurrency && sum == 1)
            {
                return $"{sum} dollar";
            }
            else
            {
                return sum.ToString();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 1, false));
            Console.WriteLine(Add(2.5m, 2.5m));
            Console.WriteLine(Add(1,2));
        }
    }
}
