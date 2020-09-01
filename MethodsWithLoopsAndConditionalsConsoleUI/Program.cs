using System;
using System.Collections.Generic;
using System.Linq;

namespace MethodsWithLoopsAndConditionalsConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            EqualIntegers();
            Console.WriteLine("");

            ByThree();
            Console.WriteLine("");

            PrintRange();
            Console.WriteLine("");

            EvenOrOdd();
            Console.WriteLine("");

            PosOrNeg();
            Console.WriteLine("");

            AgeOfCandidate();
            Console.WriteLine("");

            InRange();
            Console.WriteLine("");

            MultiTable();
            Console.WriteLine("");

            Index();
            Console.WriteLine("");

            Compute(new int[] {0,1,2,3,4});
            Console.WriteLine("");
           
            Cube();
        }

        public static void PrintRange()
        {
            for (int i = -1000; i <= 1000; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void ByThree()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        public static void EqualIntegers()
        {
            Console.WriteLine("Type your num1 integer");
            var num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Type your num2 integer");
            var num2 = int.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("Congrats they're equal"); 
            }
            else
            {
                Console.WriteLine("You suck"); 
            }
        }

        public static bool EvenOrOdd()
        {
            Console.WriteLine("Type in a number");
            var num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("True");
                return true;
            }
            else
            {
                Console.WriteLine("False");
                return false;
            }
        }

        public static void PosOrNeg()
        {
            
            Console.WriteLine("Type in a number");
            var num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("positive");
            }
            else if(num < 0)
            {
                Console.WriteLine("negative");
            }
            else
            {
                Console.WriteLine("neither");
            }
        }

        public static void AgeOfCandidate()
        {
            Console.WriteLine("What is your age?");

            var age = int.Parse(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("You can vote for Trump!");
            }
            else
            {
                Console.WriteLine("You're a liberal"); 
            }
        }

        public static bool InRange()
        {
            Console.WriteLine("Type a number");
            var num = int.Parse(Console.ReadLine());

            if (num > -10 && num < 10)
            {
                Console.WriteLine("In Range");
                return true;
            }
            else
            {
                Console.WriteLine("Out of range");
                return false;
            }
        }

        public static void MultiTable()
        {
            int number;
            Console.WriteLine("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine("{0} * {1} = {2}",
                number, i, number * i);
            }
        }
        
        public static void Index()
        {
            Console.WriteLine("Enter the number of your index");
            string num = Console.ReadLine();
            int i = Convert.ToInt32(num);
            int[] number = new int[i];
            
            foreach (var item in number)
            {
                Random r = new Random();
                int size = r.Next(0,100);
                Console.WriteLine(item + size);
            }
            Console.ReadLine();
        }

        public static int Compute(int[] number)
        {
            int[] array = new int[] { };
            int sum = number.Sum();
            return sum;
        }

        public static void Cube()
        {
            Console.WriteLine("Enter a number");
            
            int userInput = Convert.ToInt32(Console.ReadLine());
            double cube = Math.Pow(userInput, 3);

            Console.WriteLine("Number is {0} and the Cube of {0} = {1}", userInput, cube);
            Console.ReadLine();
        }
    }
}
