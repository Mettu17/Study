using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberofStudents = 0;

            Console.WriteLine("Enter Number Of Students: ");
            numberofStudents = int.Parse(Console.ReadLine());

            int loop = 0;
            int student = 0;

            while(loop < numberofStudents)
                {
                    Console.WriteLine("Enter The Age of Student "+loop+": ");
                    student += int.Parse(Console.ReadLine());
                    loop++;
                
                    
                }

            Console.WriteLine("The Average Age is {0}", (student / numberofStudents));

            Console.ReadLine();


           
        }
    }
}
