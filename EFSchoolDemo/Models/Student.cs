using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Diagnostics;

namespace EFSchoolDemo
{
    [DebuggerDisplay("{Name}")]
    class Student
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime? Birthdate { get; set; }
        public float? AdmissionPoints { get; set; }
    }
}
