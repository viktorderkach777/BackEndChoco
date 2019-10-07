using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndChoco.Entities
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string Office { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }
    }
}
