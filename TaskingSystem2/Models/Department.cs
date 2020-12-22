using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskingSystem2.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string DepartmentName { get; set; }

        [Required]
        public string SectionName { get; set; }
    }
}
