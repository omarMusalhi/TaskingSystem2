﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TaskingSystem2.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name ="Department Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name ="Directorate")]
        public int DirectorateId { get; set; }

        [ForeignKey("DirectorateId")]
        public virtual Directorate Directorate { get; set; }


    }
}
