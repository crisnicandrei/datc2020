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
        
        [HttpPost]
        
        public List<Student> Post()
        {
            students.addStudent();
            return students.Students; //return pentru testare
        }
    }
    //     [HttpDelete]
    //    public void Delete(int id)
    //    {
    //        foreach(Student student in StudentsRepo.Students)
    //        {
    //            if(student.Id == id)
    //            {
    //                StudentsRepo.Students.Remove(student);
    //            }
    //        }
    //    }
    //    [HttpPut]

    
}