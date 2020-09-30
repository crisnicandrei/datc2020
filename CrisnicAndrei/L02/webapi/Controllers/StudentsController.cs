using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
namespace L02.webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        StudentsRepo students = new StudentsRepo();
        private readonly ILogger<StudentsController> _logger;
        public StudentsController(ILogger<StudentsController> logger)
        {
            _logger = logger;        
        }
        [HttpGet]
        public List<Student> Get()
        {
            return students.Students;
        }
        [HttpGet("{id}")]
        public Student Get(int id)
        {
            foreach (Student student in students.Students)
            {
                if(student.Id == id)
                {
                    return student;
                }
            }
            return null;
        }
        
        
        [HttpPost]
        
        public List<Student> Post()
        {
            students.addStudent();
            return students.Students; //return pentru testare
        }
    
       [HttpDelete("{id}")]
       public List<Student> Delete(int id)
        {
           foreach(Student student in students.Students)
           {
               if(student.Id == id)
               {
                   students.Students.Remove(student);
                   return students.Students;
               }


           }
           return null;
        }
       [HttpPut("{id}")]
       public Student Update(int id)
       {
           foreach(Student student in students.Students)
           {
               if(student.Id == id)
               {
                   student.Nume = "Dorel";
                   return student;
               }
           }
           return null;
           
       }
    }

    
}