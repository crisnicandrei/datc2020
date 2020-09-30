using System.Collections.Generic;
namespace L02.webapi
{
    public class StudentsRepo
    { public   List<Student> Students  ;
        public StudentsRepo()
        {
        Students = new List<Student>();
        Students.Add(new Student{Name="eu",Id=1,Faculty="AC"});
        Students.Add(new Student{Name="Xulescu",Id=2,Faculty="Istorie"});
        Students.Add(new Student{Name="Maria",Id=3,Faculty="PSIHO"});
        }
        public void addStudent()
        {
            Students.Add(new Student{Name="Dani",Id=5,Faculty="nu"});
        }
    }   

       
}
