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

            Console.WriteLine($"The sum of 2 and 3 is {Add(2,3)}");
            Console.WriteLine($"The difference of 5 and 1 is {Subtract(5,1,1)}");
            Console.WriteLine($"The product of 6 and 8 is {Multiply(6,8)}");
            Console.WriteLine($"The quotient of 12 and 3 is {Divide(12,3)}");
            Console.WriteLine($"7 % 5 = {Modulus(7,5)}");
        }

        public static string GetUserInput(string input)
        {
            Console.WriteLine(input);
            string retVal = Console.ReadLine();

            return retVal;
        }

        public static int Add(params int[] nums)
        {
            int retVal = nums[1];
            foreach(int num in nums)
            {
                retVal+=num;
            }

            return retVal;
        }

        public static int Subtract(params int[] nums)
        {
            int retVal = nums[1];
            foreach(int num in nums)
            {
                retVal-=num;
            }

            return retVal;
        }

        public static int Multiply(params int[] nums)
        {
            int retVal = nums[1];
            foreach(int num in nums)
            {
                retVal*=num;
            }

            return retVal;
        }

        public static int Divide(params int[] nums)
        {
            int retVal = nums[1];
            foreach(int num in nums)
            {
                retVal/=num;
            }

            return retVal;
        }

        public static int Modulus(params int[] nums)
        {
            int retVal = nums[1];
            foreach(int num in nums)
            {
                retVal%=num;
            }

            return retVal;
        }




        
    }
}
