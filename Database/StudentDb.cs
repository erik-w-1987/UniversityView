using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityData;

namespace Database
{
    public class StudentDb : IIdProvider
    {
        public static int StudentsDbCreated;
        public StudentDb() :base()
        {
            StudentsDbCreated++;
        }
        public int Id { get; set; }
        public int RegistrationNumber { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        public Student CreateStudent()
        {
            return new Student
            {
                Id = this.Id,
                FirstName = this.FirstName,
                LastName = this.LastName,
                RegistrationNumber = this.RegistrationNumber,
            };
        }
    }
}
