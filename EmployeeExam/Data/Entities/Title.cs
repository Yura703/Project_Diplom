using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeExam.Data.Entities
{
    public class Title
    {
        public Title()
        {
            Employees = new HashSet<Employee>();
        }

        [Key]
        public int title_id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Наименование")]
        public string title_name { get; set; }

        [Required]
        [Range(1, 100, ErrorMessage = "Недопустимый номер варианта")]
        [Display(Name = "Вариант")]
        public int var_id { get; set; }

        [Required]
        [Range(1, 5, ErrorMessage = "Недопустимая группа по эл. безопасности")]
        [Display(Name = "Группа по электробезопасности")]
        public int gr_security { get; set; }

        [Required]
        [Range(1, 3, ErrorMessage = "Недопустимая периодичность проверки")]
        [Display(Name = "Периодичность проверки")]
        public int interval { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
