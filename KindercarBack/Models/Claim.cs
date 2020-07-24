using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KindercarBack.Models
{
    public class Claim
    {
        public int ClaimId { get; set; }
        public string Description { get; set; }
        public string status { get; set; }
        public DateTime DateClaim { get; set; }
    }
}
