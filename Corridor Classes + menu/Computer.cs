using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corridor_Classes___menu
{
    class Computer
    {
        private string computername;
        private string computerstatus;
        private int numberoffaults;

        public string Computername
        {
            get
            {
                return computername;
            }

            set
            {
                computername = value;
            }
        }

        public string Computerstatus
        {
            get
            {
                return computerstatus;
            }

            set
            {
                computerstatus = value;
            }
        }

        int Numberoffaults
        {
            get
            {
                return numberoffaults;
            }

            set
            {
                numberoffaults = value;
            }
        }

        public Computer(String cname, String status, int faults)
        {
             Computername = cname;
             Computerstatus = status;
             Numberoffaults = faults;
        }


        public int showNumberOfFaults()
        {
            return Numberoffaults;
        }

        public override string ToString()
        {
            string output = "";
            output = "===========================================\n";
            output += "Computer Name: " + Computername + "\n";
            output += "Computer Status: " + Computerstatus + "\n";
            output += "Number of Faults: " + Numberoffaults + "\n";
            output += "==========================================\n";

            return output;
                
        }




    }


}
