using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace EFSchoolDemo
{
    [DebuggerDisplay("{Name}")]
    class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Teacher { get; set; }
    }
}
