using System.Collections.Generic;
namespace L02.webapi
{
    public class StudentsRepo
    { public  List<Student> Students  ;
        public StudentsRepo()
        {
        Students = new List<Student>();
        Students.Add(new Student{Nume="eu",Prenume="Popescu",anStudiu=2,Id=1,Faculty="AC"});
        Students.Add(new Student{Nume="Xulescu",Prenume="Sorin",anStudiu=3,Id=2,Faculty="Istorie"});
        Students.Add(new Student{Nume="Maria",Prenume="Marescu",anStudiu=2,Id=3,Faculty="PSIHO"});
        }
    }   

       
}
