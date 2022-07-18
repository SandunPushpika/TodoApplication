using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication.Models
{
    public class Todo {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string title { get; set; }
        [MaxLength(100)]
        public string description { get; set; }
        public DateTime created { get; set; }
        public DateTime due { get; set; }
        public TodoStatus status { get; set; }
        public int authorid { get; set; }
        public Author author{ get; set; }
    }
}
