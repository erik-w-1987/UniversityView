using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityData
{
    public enum GradeValue
    {
        NoGrade = 0,
        VeryGood = 1,
        Good = 2,
        Satisfactory = 3,
        Sufficient = 4,
        Deficient = 5,
        Insufficient = 6
    }
    public class Grade : IIdProvider, IGrade
    {
        public int Id { get; init; }
        public GradeValue Value { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
    }

    public interface IGrade
    {
        int Id { get; }
        GradeValue Value { get; }
        Student Student { get; }
        Course Course { get; }
    }
}
