using System.Collections.Generic;

namespace L02.webapi
{
    public class StudentsRepo
    { public static List<Student> Students = null;

        public StudentsRepo()
        {
            Students = new List<Student>();
        }

        public static List<Student> GetStudents()
        {
            return Students;
        }
    
        
       
        
        
    }
}