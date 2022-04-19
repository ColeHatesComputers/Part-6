using System;

namespace Part_6
{
    class Program
    {
        private static object toint32;

        public static object Hello { get; private set; }

        static void Main(string[] args)
        {
            prompter();
            percent();
            oddsum();
            randomnum();
        }
        public static void prompter()
        {
            int min;
            int max;
            int between;
            bool done = false;


            Console.WriteLine("Please enter minimum number:");
            while (!Int32.TryParse(Console.ReadLine(), out min))
                Console.WriteLine("Please enter a numeric value");


            Console.WriteLine("Please enter a max number:");
            while (!Int32.TryParse(Console.ReadLine(), out max) || min > max)
                Console.WriteLine("Please enter a valid number(can't be less than minimum)");

            Console.WriteLine("Please enter a number between those numbers:");
            while (!Int32.TryParse(Console.ReadLine(), out between) || between >= max || between <= min)
                Console.WriteLine("Try entering a number between those");


        }

        public static void percent()
        {
            int score;
            int count = 0;
            int amount;
            double total;

            Console.WriteLine("How many cores would you like to enter?");
            while (!Int32.TryParse(Console.ReadLine(), out amount))
                Console.WriteLine("Please enter a valid number");


            for (int i = 1; i <= amount; i++)
            {
                Console.WriteLine("Please enter a score between 0 and 100:");
                while (!Int32.TryParse(Console.ReadLine(), out score) || score > 100 || score < 0)
                    Console.WriteLine("Please enter a valid score!");

                if (score > 75)
                    count++;

            }


            total = (double)count / amount * 100;

            Console.WriteLine($"The percentage of passing scores is {Math.Round(total, 2)}%");
        }

        public static void oddsum()
        {

            int num;
            int num1 = 1;
            int num2 = 0;
            Console.WriteLine("Please enter any number:");
            do
            {

                while (!Int32.TryParse(Console.ReadLine(), out num))
                    Console.WriteLine("Invalid Input");
                if (num <= 0)
                    Console.WriteLine("Invalid must be larger than zero");
            } while (num <= 0);

            do
            {
                num2 = num1 + num2;
                num1 = num1 + 2;
            } while (num1 <= num);
            Console.WriteLine($"The sum is {num2}");

        }
        public static void randomnum()
        {
            Random generator = new Random();
            int min;
            int max;
            int i = 0;
            Console.WriteLine("Enter a minimum number:");
            while (!Int32.TryParse(Console.ReadLine(), out min))
                Console.WriteLine("Enter a valid number");
            Console.WriteLine("Enter a max number");
            do
            
            {
                while (!Int32.TryParse(Console.ReadLine(), out max))
                    Console.WriteLine("Enter a valid number");
                if (max < min)
                    Console.WriteLine("Your max can't be smaller than your min number");
            } while (max <= min);
            Console.WriteLine("Nice");
            do
           
            {
                double middleNmbr = generator.Next(min, max);
                double deci = generator.NextDouble();
                middleNmbr = middleNmbr + deci;
                Console.WriteLine($"{middleNmbr}");
                i = i + 1;
            } while (i != 25);
        }




    }
    
}