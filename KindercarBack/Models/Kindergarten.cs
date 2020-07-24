using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KindercarBack.Models
{
    public class Kindergarten
    {
        [Key]
        public int KindergartenId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public float Cost { get; set; }
        public int Phone { get; set; }

        public DateTime DateCreation { get; set; }
        public string Logo { get; set; }
        public int NbrEmp { get; set; }
    }
}
