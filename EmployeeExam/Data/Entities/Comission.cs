using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeExam.Data.Entities
{
    public class Comission
    {
        [Key]
        public int Comission_id { get; set; }

        [Display(Name = "Номер комиссии")]
        public int NamberComission { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "ФИО")]
        public string FIO { get; set; }

        [Display(Name = "Действующий")]
        public bool Head { get; set; }

        [Display(Name = "Роль")]
        public string Role { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Должность")]
        public string Description { get; set; }
    }

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }   
}
