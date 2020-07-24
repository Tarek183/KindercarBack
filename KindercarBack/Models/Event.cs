using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KindercarBack.Models
{
    public class Event
    {
        [Key]
        public int IdEvent { get; set; }
        public string Name { get; set; }
        public string imageE { get; set; }
        public string description { get; set; }
        [DataType(DataType.Date)]
        public DateTime dateD { get; set; }

        [DataType(DataType.Date)]
        public DateTime dateF { get; set; }

    }
}
