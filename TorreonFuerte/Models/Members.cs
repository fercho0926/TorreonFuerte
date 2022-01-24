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

        [Required, StringLength(25), RegularExpression("([0-9]+)")]
        public string Identification { get; set; }

        [Required, StringLength(60), RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "Use letters only please")]
        public string Name { get; set; }
        [Required, StringLength(60), RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "Use letters only please")]
        public string LastName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public string DateBirth { get; set; }
        [Required]
        public EnumCities EnumCities { get; set; }
        [Required, StringLength(100)]
        public string Address { get; set; }
        [Required, StringLength(100)]
        public string Neighborhood { get; set; }

        [DataType(DataType.PhoneNumber), StringLength(25)]
        public string phone { get; set; }

        [DataType(DataType.EmailAddress), StringLength(100)]
        public string Mail { get; set; }
        public List<Networks> Network { get; set; } = new  List<Networks>();
        [Required]
        public EnumLevels EnumLevels { get; set; }
      

    }
}
