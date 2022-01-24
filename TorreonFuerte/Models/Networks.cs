using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorreonFuerte.Models
{
    public class Networks
    {
        [Key]
        public int IdCell { get; set; }
        public int  NetworkCell { get; set; }
        public string NameCell { get; set; }
        public Members Members { get; set; }
    }
}
