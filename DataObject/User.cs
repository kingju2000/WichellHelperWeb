using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace API.DataObject {
    /// User class
    public class User  {

        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(100)]
        public string firstName { get; set; }

        public string salutation { get; set; }
       
        [MinLength(3)]
        [MaxLength(100)]
        String email {get; set;}


    }
}
