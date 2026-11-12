using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class StudentAccount
    {
        public int StudentId { get; set; }

        public string EnrollmentStatus { get; set; }

        public decimal TotalAssessment { get; set; }

        public decimal TotalPaid { get; set; }

        public decimal CurrentBalance { get; set; }
    }
}
