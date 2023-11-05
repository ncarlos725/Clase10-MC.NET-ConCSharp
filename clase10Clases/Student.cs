using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase10Clases
{
    class Student : Person
    {
        public Student(String name, string lastName) : base(name, lastName, "")
        {
            this.Address = "PJe lanieri";

        }


        //---------------------------
        public void Enrollment()
        {

        }

        public override string Greeting()
        {
            return " Hola soy un Estudiante";
        }

        public override bool CanTeach
        {
            get { return false; }
        }


    }

     
}




