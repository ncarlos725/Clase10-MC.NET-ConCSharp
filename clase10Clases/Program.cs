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
            List<Student> student = new List<Student>();

            Student estudianteJorge = new Student("Jorge","Perez","Calle123");
     
            student.Add(estudianteJorge);

            Student estudianteFrancis = new Student("Fran","Quiroga","SiempreViva");
          

            

            PrintStudentNames(student);

           
        }

        //funciones
        private static void PrintStudentNames(List<Student> students) 
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student.Name);
            }
        }
    }
}
