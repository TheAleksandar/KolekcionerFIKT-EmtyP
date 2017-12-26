using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Emty_Kolekcioner_FIKT.Models
{
    public class AddKolekcion
    {

        [Key]
        public int IDphoto { get; set; }
        
        public int IdUser { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        public int PhotoBr { get; set; }

       

    }
}