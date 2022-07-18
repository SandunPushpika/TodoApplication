using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication.Models
{
    public class Author {
        public int id { get; set; }
        [Required]
        [MaxLength(20)]
        public string name { get; set; }
        [MaxLength(50)]
        public string adressnb { get; set; }
        [MaxLength(50)]
        public string street { get; set; }
        [Required]
        [MaxLength(50)]
        public string city { get; set; }

        public ICollection<Todo> todos {get; set;} = new List<Todo>();
    }
}
