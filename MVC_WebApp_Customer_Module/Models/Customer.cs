using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_WebApp_Customer_Module.Models
{
    public class Customer
    {
        public int ID { get; set; }

        [StringLength(50, MinimumLength = 1)]
        [Required]
        public string Name { get; set; }

        [StringLength(50, MinimumLength = 1)]
        [Required]
        public string Surname { get; set; }
        
        [Display(Name = "Mobile number")]
        [Required]
        public string Telephone_Number { get; set; }

        [StringLength(100, MinimumLength = 5)]
        [Required]
        public string Address { get; set; }
    }
}
