using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PaymentReceipt
    {
        public int PaymentId { get; set; }
        public string PaymentDate { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; }
        public string ReferenceNumber { get; set; }

        public int StudentId { get; set; }
        public string LRN { get; set; }
        public string StudentName { get; set; }

        public decimal TotalAssessment { get; set; }
        public decimal PreviousBalance { get; set; }
        public decimal RemainingBalance { get; set; }
    }
}
