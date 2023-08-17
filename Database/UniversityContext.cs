using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class UniversityContext : DbContext
    {
        public DbSet<StudentDb> Students { get; set; }
        public DbSet<GradeDb> Grades { get; set; }

        public DbSet<CourseDb> Courses { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbPath = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "database.db");
            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }
    }
}
