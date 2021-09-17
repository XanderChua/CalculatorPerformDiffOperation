using System;
using System.Collections.Generic;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int countadd = 0;
            int countmin = 0;
            int countx = 0;
            int countdiv = 0;
            int countmod = 0;
            int totalcount = 0;
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("This is a simple calculator.");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Modulus");
                Console.WriteLine("6. Exit calculator \n");
                Console.WriteLine("Addition count : " + countadd);
                Console.WriteLine("Subtraction count : " + countmin);
                Console.WriteLine("Multiplication count : " + countx);
                Console.WriteLine("Division count : " + countdiv);
                Console.WriteLine("Modulus count : " + countmod);
                Console.WriteLine("Total operations count : " + totalcount);

                int input = Int32.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1: //addition
                        {
                            Console.WriteLine("Enter first number: ");
                            int x = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Enter second number: ");
                            int y = Int32.Parse(Console.ReadLine());
                            int add = x + y;
                            Console.WriteLine("Your answer: " + add + "\n");
                            countadd++;
                            totalcount++;                         
                            break;
                        }
                    case 2: //subtraction
                        {
                            Console.WriteLine("Enter first number: ");
                            int x = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Enter second number: ");
                            int y = Int32.Parse(Console.ReadLine());
                            int minus = x - y;
                            Console.WriteLine("Your answer: " + minus);
                            countmin++;
                            totalcount++;
                            break;
                        }
                    case 3: //multiplication
                        {
                            Console.WriteLine("Enter first number: ");
                            int x = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Enter second number: ");
                            int y = Int32.Parse(Console.ReadLine());
                            int multiply = x * y;
                            Console.WriteLine("Your answer: " + multiply);
                            countx++;
                            totalcount++;
                            break;
                        }
                    case 4:  //division
                        {
                            Console.WriteLine("Enter first number: ");
                            int x = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Enter second number: ");
                            int y = Int32.Parse(Console.ReadLine());
                            int divide = x + y;
                            Console.WriteLine("Your answer: " + divide);
                            countdiv++;
                            totalcount++;
                            break;
                        }
                    case 5: //modulus
                        {
                            Console.WriteLine("Enter first number: ");
                            int x = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Enter second number: ");
                            int y = Int32.Parse(Console.ReadLine());
                            int mod = x % y;
                            Console.WriteLine("Your answer: " + mod);
                            countmod++;
                            totalcount++;
                            break;
                        }
                    case 6: //exit program
                        {
                            loop = false;
                            break;
                        }                      
                }
                
            }

        }
    }
}