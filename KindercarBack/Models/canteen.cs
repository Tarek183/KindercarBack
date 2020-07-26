using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KindercarBack.Models
{
    public class Canteen
    {
        [Key]
        public int CanteenId { get; set; }
    }
}
