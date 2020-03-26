using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cw3.DAL;
using Cw3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cw3.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentsController : ControllerBase
    {

        private readonly IDbService _dbService;
        

        public StudentsController(IDbService db)
        {
            _dbService = db;
        }


        [HttpGet]
        public IActionResult GetStudents()
        {
            return Ok(_dbService.GetStudents());
        }

        [HttpPost]
        public IActionResult CreateStudent(Student student)
        {

            student.IndexNumber = $"s{new Random().Next(1, 2000)}";

            return Ok(student);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id)
        {
            foreach(var studnet in _dbService.GetStudents())
            {
                if (studnet.IdStudent == id)
                {
                    return Ok("Aktualizacja dokończona");
                }
  
            }
            return NotFound("Nie ma takieg id w bazie studnetów");
                
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {

            foreach (var studnet in _dbService.GetStudents())
            {
                if (studnet.IdStudent == id)
                {
                    return Ok("Usuwanie zakończone");
                }

            }
            return NotFound("Nie ma takieg id w bazie studnetów");
            
        }
    }
}