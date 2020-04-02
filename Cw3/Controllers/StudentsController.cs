using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        private const string ConString = "Data Source=db-mssql;Initial Catalog=s18903;Integrated Security=True";
        private readonly IDbService _dbService;


        public StudentsController(IDbService db)
        {
            _dbService = db;
        }


        [HttpGet]
        public IActionResult GetStudents([FromServices] IDbService dbService)
        {
            var list = new List<Student>();
            using (SqlConnection con = new SqlConnection(ConString))
            using (SqlCommand com = new SqlCommand())
            {
                com.Connection = con;
                com.CommandText = "select * from student";

                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    var st = new Student();
                    st.IndexNumber = dr["IndexNumber"].ToString();
                    st.FirstName = dr["FirstName"].ToString();
                    st.LastName = dr["LastName"].ToString();
                    st.BirthDate = (DateTime)dr["BirthDate"];
                    st.IdEnrollment = (int)dr["IdEnrollment"];
                    list.Add(st);
                }
            }
            return Ok(list);
        }

        [HttpGet("{number}")]
        public IActionResult GetStudent(string number)
        {
            
            using (SqlConnection con = new SqlConnection(ConString))
            using (SqlCommand com = new SqlCommand())
            {
                com.Connection = con;
                com.CommandText = "select * from student where indexnumber=@index";
                com.Parameters.AddWithValue("index", number);

                con.Open();
                var dr = com.ExecuteReader();
                while (dr.Read())
                {
                    var st = new Student();
                    st.IndexNumber = dr["IndexNumber"].ToString();
                    st.FirstName = dr["FirstName"].ToString();
                    st.LastName = dr["LastName"].ToString();
                    st.BirthDate = (DateTime)dr["BirthDate"];
                    st.IdEnrollment = (int)dr["IdEnrollment"];
                    return Ok(st);
                }
            }
            return NotFound("Student Not Found");
        }

        [HttpPost]
        public IActionResult CreateStudent(Student student)
        {

            student.IndexNumber = $"s{new Random().Next(1, 2000)}";

            return Ok(student);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateStudent(string id)
        {
            foreach (var studnet in _dbService.GetStudents())
            {
                if (studnet.IndexNumber == id)
                {
                    return Ok("Aktualizacja dokończona");
                }

            }
            return NotFound("Nie ma takieg id w bazie studnetów");

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {

            foreach (var studnet in _dbService.GetStudents())
            {
                if (studnet.IndexNumber == id)
                {
                    return Ok("Usuwanie zakończone");
                }

            }
            return NotFound("Nie ma takieg id w bazie studnetów");

        }
    }
}