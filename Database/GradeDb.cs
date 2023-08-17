using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityData;

namespace Database
{

    public class GradeDb : IIdProvider
    {
        public int Id { get; set; }
        public GradeValue Value { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public Grade CreateGrade(Student student, Course course)
        {
            return new Grade
            {
                Id = this.Id,
                Value = this.Value,
                Student = student,
                Course = course
            };
        }
    }
}
