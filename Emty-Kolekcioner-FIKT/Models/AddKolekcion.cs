using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Emty_Kolekcioner_FIKT.Models
{
    public class AddKolekcion
    {
        
      
        public int IdPhoto { get; set; }
        [Key]
        public int UserID { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        public int PhotoBr { get; set; }

       

    }
}