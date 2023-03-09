using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonelFinder.Entities
{
    public class Personel
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [StringLength(20)]
        public string name { get; set; }
        [StringLength(20)]
        public string surname { get; set; }
        public double salary { get; set; }
    }
}
