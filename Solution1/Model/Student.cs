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
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string LRN { get; set; }
        public string ContactInfo { get; set; }
        public string GuardianContactInfo { get; set; } 

        public bool isActive { get; set; }
    }
}
