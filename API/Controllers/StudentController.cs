using System.Collections.Generic;
using System.Linq;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        public readonly DataContext _context;
        public StudentController(DataContext dbcontext)
        {
            _context = dbcontext;
        }


        [HttpGet]
        public ActionResult<IEnumerable<Student>> getStudents()
        {
            return _context.Students.ToList();
        }



        [HttpGet("{id}")]
        public ActionResult<Student> getStudentById(int id )
        {
           return _context.Students.Find(id);
        }
    }
}