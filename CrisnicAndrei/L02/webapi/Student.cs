namespace L02.webapi
{
    public class Student
    {
         public string Name{get;set;}
       public int Id{get;set;}
       public string Faculty{get;set;}

       public Student(string name,int id,string faculty)
       {
           Name = name;
           Id = id;
           Faculty = faculty;
       }
    }
}