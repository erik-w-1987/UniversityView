using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityData;

namespace Database
{
    public class CourseDb : IIdProvider
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public Course CreateCourse()
        {
            return new Course()
            {
                Id = this.Id,
                Name = this.Name,
            };
        }
    }
}
