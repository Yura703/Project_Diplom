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
        public string dep_name { get; set; }

        [Required]
        [StringLength(10)]
        public string dep_abvr { get; set; }

        public bool Head { get; set; } = true;

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
