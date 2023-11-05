using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase10Clases
{
    internal class Teacher : Person
    {
        public Teacher(String name, string lastName) : base(name, lastName, "")
        {
        }

        // List subject
        public List<string> subjects { get; private set; }

        //Sobre escritura
        public override string Greeting()
        {
            return " Hola soy un Prosor";
        }

        public override bool CanTeach
        {
            get { return true; }
        }

    }
}
