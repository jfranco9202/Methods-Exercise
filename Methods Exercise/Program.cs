using System;

namespace Methods_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("What is you favorite color?");
            string userColor = Console.ReadLine();

            Console.WriteLine("What is you favorite animal?");
            string userAnimal = Console.ReadLine();


            Console.WriteLine("What is you favorite band?");
            string userBand = Console.ReadLine();

            Console.WriteLine($"Once upon a time {userName} went to watch the {userBand}in his favorite {userColor} shirt and a { userAnimal} attacked");
        }

        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static int Minus(int c, int d)
        {
            return c - d;
        }

        public static int Divide(int x, int y)
        {
            return x / y;
        }

    }
}
        
