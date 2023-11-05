using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase10Clases
{
    class program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            Student estudianteJorge = new Student("Jorge","Gonzalez");
            persons.Add(estudianteJorge);


            Teacher profesorJuanito = new Teacher("Juanito", "Melenas");
            persons.Add(profesorJuanito);


            

            //Student estudianteFrancis = new Student("Fran","Quiroga","SiempreViva");     

            //PrintStudentNames(student);



            //List<Student> student = new List<Student>();

            //Student estudianteJorge = new Student("Jorge","Perez","Calle123");

            //student.Add(estudianteJorge);

            //Student estudianteFrancis = new Student("Fran","Quiroga","SiempreViva");     

            //PrintStudentNames(student);

            PrintPersontNames(persons);


        }

        //funciones


        private static void PrintPersontNames(List<Person> persons)
        {
            foreach (Person person in persons)
            {
                Console.WriteLine(person.Name);
                Console.WriteLine(person.Greeting());
            }
        }


        //private static void PrintStudentNames(List<Student> students)
        //{
        //    foreach (Student student in students)
        //    {
        //        Console.WriteLine(student.Name);
        //    }
        //}
    }
}
