using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Student
    {

        public int StudentId { get; set; }
        public string LRN { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ContactNo { get; set; }
        public string GuardianName { get; set; }
        public string GuardianContact { get; set; }
        public string Address { get; set; }

        public string FullName =>
            $"{LastName}, {FirstName}" + (string.IsNullOrWhiteSpace(MiddleName) ? "" : " " + MiddleName);
    }
}

