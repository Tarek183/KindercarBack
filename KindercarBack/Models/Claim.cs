using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KindercarBack.Models
{
    public class Claim
    {
        [Key]
        public int ClaimId { get; set; }
        public string Description { get; set; }
        public string status { get; set; }
        public DateTime DateClaim { get; set; }
    }
}
