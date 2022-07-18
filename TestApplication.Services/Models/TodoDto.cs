using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApplication.Models;

namespace TestApplication.Services.Models
{
    public class TodoDto
    {
        public string title { get; set; }
        
        public string description { get; set; }
        public DateTime created { get; set; }
        public DateTime due { get; set; }
        public int status { get; set; }
    }
}
