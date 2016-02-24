using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corridor_Classes___menu
{
    class Program
    {
        static void Main(string[] args)
        {

            Computer PC1 = new Computer("L113-T", "OK", 0);
            Computer PC2 = new Computer("L113-1", "OK", 0);
            Computer PC3 = new Computer("L113-2", "OK", 0);
            Computer PC4 = new Computer("L113-3", "OK", 0);



            Computer[] computers = new Computer[3];

            computers[0] = PC1;
            computers[1] = PC2;
            computers[2] = PC3;
            computers[3] = PC4;



            Classroom myClassroom = new Classroom("L113", true);

            Console.WriteLine(myClassroom);
            myClassroom.Computersinclassroom[0].Numberoffaults = 1;

            Console.WriteLine(myClassroom);


            Console.ReadLine();





         /*   //MENU

            int choice = 0;

            while (choice != 7)
            {

                Console.WriteLine("Select what you need to do: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)

                {



                }


            }*/


        } 

     }   
}   
