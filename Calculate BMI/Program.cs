using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight = 0;
            double height = 0;
                

            Console.WriteLine("Enter the Weight: ");
            weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Height: ");
            height = double.Parse(Console.ReadLine());

            double  ans = weight / height;


            Console.Write("Your BMI is: {0}",ans);

            Console.ReadLine();
        } 
    }
}
