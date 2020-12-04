using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Text;

namespace EFDemo
{
    [DebuggerDisplay("{Name}")]
    [Table("Städer")]
    class City
    {
        public int Id { get; set; }

        [Column("Namn")]
        public string Name { get; set; }

        [Column("LandId")]
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}
