 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ProgramContinue = true;
            while (ProgramContinue == true) 

            {
                Console.WriteLine("Welcome to Batting Average Calculator!");

                Console.WriteLine("Enter Number of times at Bat");
                int Size = ReadValid2();

                double[] atBat = new double[Size];

                for (int i = 0; i <= atBat.Length - 1; i++)
                {

                    atBat[i] = ReadValid(); // validation method goes here 
                }

                double Sum = 0;
                double Avg = 0;

                for (int i = 0; i < atBat.Length; i++)
                {
                    Sum = Sum + atBat[i];

                }
                Avg = Sum / Size;

                Console.WriteLine($"The batting avg is" + Avg);

                double Count = 0;

                foreach (double Element in atBat)

                    if (Element != 0)
                    {
                        Count = Count + 1;
                    }

                double batavg = Count / Size;
                Console.WriteLine("The Slugging Percentage" + batavg);

                if (ReadValue3() == "no")
                {
                    ProgramContinue = false;
                }

            }

        }

        public static int ReadValid2()
        {

            int Size4 = int.Parse(Console.ReadLine());

            while (Size4 < 0)
            {
                Console.WriteLine("Please enter a positive number ");

                Size4 = int.Parse(Console.ReadLine());
            }
            return Size4;

        }
        public static int ReadValid()
        {
            Console.WriteLine("Enter at Bat Results");
            int Size3 = int.Parse(Console.ReadLine());

            while (Size3 != 0 && Size3 != 1 && Size3 != 2 && Size3 != 3 && Size3 != 4)
            {
                Console.WriteLine("Please only enter a number between 1-4");

                Size3 = int.Parse(Console.ReadLine());
            }
            return Size3;

        }

        public static string ReadValue3()
        {
        
        Console.WriteLine("Another Batter? enter yes or no");
            string Input = Console.ReadLine().ToLower();
            while (Input != "yes" && Input != "no") 
            {
                Console.WriteLine("Please enter either Yes or No");
                Input = Console.ReadLine().ToLower();
            }

            return Input;
        }
        
    }
}
