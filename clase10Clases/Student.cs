using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase10Clases
{
    class Student
    {
        private static int Counter;

        public int Id 
        { 
            get; private set; 
        } 
       public string Name
        {
            get; private set;
        }

        public string LastName
        {
            get; private set;

        }
        
        public string Address
        {
            get; private set;
        }
        // Ejemplo de como llamar un constructor en otro constructor
        public Student(String name, string lastName) : this(name,lastName, "")
        { 
        }

        // Constructor
        public Student(string name, string lastName, string addres)
        {
            if (string.IsNullOrEmpty(Name))
            {
                
            }
            if (string.IsNullOrEmpty(LastName)) 
            {

            }
    

            Counter++;
            this.Id = Counter;

            this.Name = name;
            this.LastName = lastName;
            this.Address = addres;
        }
        public void Matricular()
        {
            // hace algo
        }

    
    }// cllas student

}// namespace
