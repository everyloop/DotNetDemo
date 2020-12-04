using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Text;

namespace EFDemo
{
    [DebuggerDisplay("{Name}")]
    [Table("Länder")]
    class Country
    {
        public int Id { get; set; }
        [Column("Namn")]
        public string Name { get; set; }

        public ICollection<City> Cities { get; set; }
    }
}
