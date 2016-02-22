using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = 0;

            Console.WriteLine("Enter the ammount of Start you Want: ");
            userInput = int.Parse(Console.ReadLine());



            int loop = 1;

            while (loop <= userInput)
                {

                    Console.Write("*");
                    loop++;
                    
                }

            Console.ReadLine();


        }
    }
}
