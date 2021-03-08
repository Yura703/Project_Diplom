using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeExam.Data.Entities
{
    public class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
        }

        [Key]
        public int dep_id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Наименование")]
        public string dep_name { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Аббревиатура")]
        public string dep_abvr { get; set; }

        [Display(Name = "Действует")]
        public bool Head { get; set; } = true;

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
