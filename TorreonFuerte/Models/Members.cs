using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorreonFuerte.Models
{
    public class Members
    {

        [Key]
        public int IdMenbers { get; set; }
        public string Identification { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DateBirth { get; set; }
        public int City { get; set; }
        public string Address { get; set; }
        public string Neighborhood { get; set; }
        public string phone { get; set; }
        public string Mail { get; set; }
        public Networks Networks { get; set; }
        public EnumLevels EnumLevels { get; set; }

    }
}
