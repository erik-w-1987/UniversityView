using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityData
{
    public class Course : IIdProvider, ICourse
    {
        public int Id { get; init; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    public interface ICourse
    {
        int Id { get; }
        string Name { get; }
    }

}
