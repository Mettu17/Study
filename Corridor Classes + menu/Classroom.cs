using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corridor_Classes___menu
{
    class Classroom
    {

        public string classroomname;
        public bool projectoravailable;
        int computersinclassroom;

        public string Classroomname
        {
            get
            {
                return classroomname;
            }

            set
            {
                classroomname = value;
            }
        }

        public bool Projectoravailable
        {
            get
            {
                return projectoravailable;
            }

            set
            {
                projectoravailable = value;
            }
        }


        Computer[] conmputersinclassrom;
        internal Computer[] Conmputersinclassrom
        {
            get
            {
                return conmputersinclassrom;
            }

            set
            {
                conmputersinclassrom = value;
            }
        }

        

        public Classroom(String classroom, bool projectoravailable,Computer[] allcomputers)    
            {
                Classroomname = classroomname;
                Projectoravailable = projectoravailable;
                computersinclassroom = allcomputers; 

            }
                
        public  string outputclassroom()
        {
            return "Name Of Classroom:" + classroomname + "Projector:" + projectoravailable;

        }


        public override string ToString()
        {
            String output = "";
            output += "Name of Classroom: " + Classroomname + " Projector: " + Projectoravailable;
            foreach(Computer c in Computerinclassroom)
            {
                output += c;

            }
            return output;
        }



    }


}
