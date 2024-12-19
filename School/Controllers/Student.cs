using Microsoft.AspNetCore.Mvc;
using School.Models;
using System.Collections.Generic;

namespace StudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        
        private static List<Student> students = new List<Student>
        {
            new Student { StudentId = 1, FirstName = "Johnny", LastName = "Storm", Age = 22, Email = "fire@hotmail.com" },
            new Student { StudentId = 2, FirstName = "Harry", LastName = "Osborn", Age = 22, Email = "goblin@yahoo.com" },
            new Student { StudentId = 3, FirstName = "Peter", LastName = "Parker", Age = 22, Email = "spider@gmail.com" }
        };

        
        [HttpGet]
        public ActionResult<IEnumerable<Student>> GetStudents()
        {
            return Ok(students);
        }
    }
}
