using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.  Create a loop that displays all values inclusive between 1-5.
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.Write($"{i} ");
            //}

            ////2.  Create a loop that displays all values inclusive between 10-6.
            //Console.WriteLine();

            //for(int i = 10; i >= 6; i--)
            //{
            //    Console.Write($"{i} ");
            //}

            ////3.  Create a loop that displays even numbers inclusive between 2 and 10
            //Console.WriteLine();

            //for(int i = 2; i <= 10; i = i + 2)  // i += 2
            //{
            //    Console.Write($"{i} ");
            //}

            ////4.  Create a loop that displays the sum of all numbers inclusive 
            ////    between 1 and 10. The answers should be 55.
            //Console.WriteLine();

            //int sum = 0;

            //for (int i = 1; i <= 10; i++)
            //{
            //    sum = sum + i;
            //}

            //Console.WriteLine(sum);

            ////5. Create a loop that displays all leap years inclusive between 
            ////   1990 and 2010. The output should be: 1992 1996 2000 2004 2008  
            //Console.WriteLine();

            //for(int i = 1990; i <= 2010; i++)
            //{
            //    if(i % 4 == 0)
            //    {
            //        Console.WriteLine($"{i} is a leap year");
            //    }
            //}

            ////1. counting to 10
            //int counter = 1;

            //while(counter <= 10)
            //{
            //    Console.Write($"{counter} ");
            //    counter++;
            //}

            ////2. counting program 
            //bool keepGoing = true;
            //int loopCounter = 0;

            //while (keepGoing) 
            //{
            //    Console.Write("Do you want to keep counting (y/n)");
            //    string userAnswer = Console.ReadLine();

            //    if (userAnswer == "y") 
            //    {
            //        loopCounter++;
            //        Console.WriteLine($"It's number {loopCounter}");
            //    }
            //    else if (userAnswer == "n")
            //    {
            //        keepGoing = false;
            //    }
            //    else
            //    {
            //        Console.WriteLine("ERROR: only y or n");
            //    }
            //}

            //Console.WriteLine("Thanks for playing!");

            //1. Counting with do while
            Console.WriteLine();

            int starting = 5;

            do
            {
                Console.Write($"{starting}");
                starting++;
            } while (starting < 10);

            //2. Create a menu system.
            Console.WriteLine();

            string choice;

            do
            {
                Console.WriteLine("\nSelect an Option");
                Console.WriteLine("1. Display values from 1 - 5");
                Console.WriteLine("2. Find area of a rectangle");
                Console.WriteLine("3. Exit");
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    CountingNumber();
                }
                else if (choice == "2")
                {
                    double width, length, answer;

                    Console.Write("Please enter the width: ");
                    width = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Please enter the length: ");
                    length = Convert.ToDouble(Console.ReadLine());

                    answer = AreaRectangle(width, length);
                    Console.WriteLine($"The area is {answer} m^2");
                }
                else if (choice == "3")
                {
                    Console.WriteLine("Have a nice day");
                }
                else if (choice == "4")
                {
                    NewMethod();
                }
                else
                {
                    Console.WriteLine("ERROR: Enter only 1, 2, or 3");
                }


                Console.WriteLine();


            } while (choice != "3");

            Console.ReadKey();
        }

        private static void NewMethod()
        {
            Console.WriteLine("Hello. I am so happy you are here");
            Console.WriteLine("How can I help you");
        }

        static void CountingNumber()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"{i} ");
            }
        }

        static double AreaRectangle(double length, double width)
        {
            double area;

            area = length * width;
            return area;
        }
    }
}
