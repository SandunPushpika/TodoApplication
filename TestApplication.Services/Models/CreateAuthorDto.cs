using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication.Services.Models
{
    public class CreateAuthorDto {
        public int id { get; set; }
        public string name { get; set; }
        public string adressnb { get; set; }
        public string street { get; set; }
        public string city { get; set; }
    }
}
