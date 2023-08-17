using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityData
{
    public class Student : IIdProvider, IStudent
    {
        public int Id { get; init; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int RegistrationNumber { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {RegistrationNumber}";
        }
    }

    public interface IStudent
    {
        int Id { get; init; }
        string FirstName { get; }
        string LastName { get; }
        int RegistrationNumber { get; }
    }

}
