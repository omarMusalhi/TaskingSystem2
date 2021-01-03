using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskingSystem2.Models
{
    public class Directorate
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name="Directorate Name")]
        public string Name { get; set; }

    }
}
