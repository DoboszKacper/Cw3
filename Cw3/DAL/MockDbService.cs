using Cw3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cw3.DAL
{
    public class MockDbService : IDbService
    {
        private static IEnumerable<Student> _students;

        static MockDbService()
        {
            _students = new List<Student>
            {
                new Student{IdStudent=1,FirstName="Gorge", LastName="Lolo",IndexNumber="s1234" },
                new Student{IdStudent=2,FirstName="Miki", LastName="Foko",IndexNumber="s12321" },
                new Student{IdStudent=3,FirstName="Lucas", LastName="Trand",IndexNumber="s5342" },
                new Student{IdStudent=4,FirstName="Frank", LastName="Breat",IndexNumber="s5234" }
            };
        }

        public IEnumerable<Student> GetStudents()
        {
            return _students;
        }
    }

}
