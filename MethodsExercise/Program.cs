namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name = GetUserInput("What is your name?");
            string color = GetUserInput("What is your favorite color?");
            string animal = GetUserInput("What is your favorite animal?");
            string band = GetUserInput("What is your favorite band?");

            Console.WriteLine($"Hi, my name is {name}, my favorite color is {color},");
            Console.WriteLine($"my favorite animal is {animal}, and my favorite band is {band}.");

            Console.WriteLine($"2 + 3 = {Add(2,3)}");
            Console.WriteLine($"5 - 1 - 1 = {Subtract(5,1,1)}");
            Console.WriteLine($"6 * 8 = {Multiply(6,8)}");
            Console.WriteLine($"12 / 3 = {Divide(12,3)}");
            Console.WriteLine($"7 % 5 = {Modulus(7,5)}");
        }

        public static string GetUserInput(string input)
        {
            Console.WriteLine(input);
            string retVal = Console.ReadLine();

            return retVal;
        }

        public static double Add(params double[] nums)
        {
            double retVal = nums[0];
            foreach(double num in nums)
            {
                retVal+=num;
            }
            retVal-=nums[0];

            return retVal;
        }

        public static double Subtract(params double[] nums)
        {
            double retVal = nums[0];
            foreach(double num in nums)
            {
                retVal-=num;
            }
            retVal+=nums[0];

            return retVal;
        }

        public static double Multiply(params double[] nums)
        {
            double retVal = nums[0];
            foreach(double num in nums)
            {
                retVal*=num;
            }
            retVal/=nums[0];

            return retVal;
        }

        public static double Divide(params double[] nums)
        {
            double retVal = nums[0];
            foreach(double num in nums)
            {
                retVal/=num;
            }
            retVal*=nums[0];

            return retVal;
        }

        public static double Modulus(double num1, double num2)
        {
            double retVal = num1 % num2;

            return retVal;
        }




        
    }
}
