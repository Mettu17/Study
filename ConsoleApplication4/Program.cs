using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {

            int userInput = 0;

            Console.WriteLine("Enter the Lenght of the Base: ");
            userInput *= int.Parse(Console.ReadLine());

            for (int count1 = 0; count1 < userInput; count1++)
            {
                for (int count2 = 0; count2 <= count1; count2++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }
            
            Console.ReadLine();




        }
    }
}
