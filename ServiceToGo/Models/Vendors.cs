using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ServiceToGo.Models
{
    public class Vendors
    {
        public int ID { get; set; }
        public string CompanyName { get; set; }

        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
