using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
        public class Section
        {
            public int SectionId { get; set; }
            public string SectionName { get; set; }
            public string GradeLevel { get; set; }
            public string SchoolYear { get; set; }
            public int Capacity { get; set; }
            public int IsActive { get; set; }
        }
}

