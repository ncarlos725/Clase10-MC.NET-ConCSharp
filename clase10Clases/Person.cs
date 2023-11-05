using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase10Clases
{
    // Con abstract nos limita a trabajar con las clases teacher o person ya no podremos crear instancias de clases de persons por que no tendria sentido.
    public abstract class Person
    {
        private static int Counter;

        public int Id
        {
            get; protected set;
        }
        public string Name
        {
            get; protected set;
        }

        public string LastName
        {
            get; protected set;

        }

        public string Address
        {
            get; protected set;
        }

        //Como Sobrescribir una funcion 
        public virtual string Greeting()
        {
            return " Soy una persona";
        }

        public virtual bool CanTeach
        {
            get 
            {
                return false;
            }
        }

        // Ejemplo de como llamar un constructor en otro constructor
        public Person(String name, string lastName) : this(name, lastName, "")
        {
        }

        // Constructor
        public Person(string name, string lastName, string addres)
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

        //
    }

}
