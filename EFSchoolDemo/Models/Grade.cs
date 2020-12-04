using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Text;

namespace EFSchoolDemo
{
    [DebuggerDisplay("{Course.Name} - {Student.Name}: {Score}")]
    class Grade
    {
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public float Score { get; set; }
    }
}
