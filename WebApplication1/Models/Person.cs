using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Person
    {
        [Key]
        public int PersonID { get; set; }
        [Required(ErrorMessage ="Dime tu nombre putita")]
        [Display(Name ="Tu puto nombre completo")]
        [StringLength(100,ErrorMessage ="Mas corto perra maximo 100")]
        public string Name { get; set; }
        [Display(Name ="CI pinche cabron")]
        public string Document { get; set; }
    }
}