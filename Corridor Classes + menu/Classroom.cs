using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corridor_Classes___menu
{
    class Classroom
    {

        string _classroomname;
        bool _projectoravailable;
        int _computersinclassroom;
        String[] Computer;

        public string Classroomname
        {
            get
            {
                return _classroomname;
            }

            set
            {
                _classroomname = value;
            }
        }

        public bool Projectoravailable
        {
            get
            {
                return _projectoravailable;
            }

            set
            {
                _projectoravailable = value;
            }
        }

        public int Computersinclassroom
        {
            get
            {
                return _computersinclassroom;
            }

            set
            {
                _computersinclassroom = value;
            }
        }

        public Classroom(String classroom, bool projectoravailable,Computer[] allcomputers)    
            {
            Classroomname = classroomname;
                Projectoravailable = projectoravailable;
                Computersinclassroom = allcomputers; 

            }
                
        public  string outputclassroom()
        {
            return "Name Of Classroom:" + _classroomname + "Projector:" + Projectoravailable;

        }


        public override string ToString()
        {
            String output = "";
            output += "Name of Classroom: " + Classroomname + " Projector: " + Projectoravailable;
            foreach(Computer c in Computersinclassroom)
            {
                output += c;

            }
            return output;
        }



    }


}
