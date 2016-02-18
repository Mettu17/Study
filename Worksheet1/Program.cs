using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet1
{
    class Program
    {
        static void Question1()
            {

            }

        static void Main(string[] args)
        {
            float Temp1,Temp2,Temp3,Temp4,Temp5,Temp6,Temp7 = 0f;
         


            Console.WriteLine("Please Enter Tempreture taken from Monday: ");
                Temp1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Tempreture taken from Tuesday: ");
                Temp2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Tempreture taken from Wednesday: ");
                Temp3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Tempreture taken from Thurdsay: ");
                Temp4 = float.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Tempreture taken from Friday: ");
                Temp5 = float.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Tempreture taken from Saturday: ");
                Temp6 = float.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Tempreture taken from Sunday: ");
                Temp7 = float.Parse(Console.ReadLine());

            float averageTemp = (Temp1 + Temp2 + Temp3 + Temp4 + Temp5 + Temp6 + Temp7);

            Console.WriteLine("Average of Tempreture is: {0} ", averageTemp);
            Console.ReadLine();



        }
    }
}
