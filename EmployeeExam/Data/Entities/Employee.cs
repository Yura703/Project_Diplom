using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeExam.Data.Entities
{
    public class Employee
    {
        public Employee()
        {
            Storages = new HashSet<Storage>();
            WrongAnswers = new HashSet<WrongAnswer>();
        }

        [Key]
        public int Employee_id { get; set; }

        [Required]
        [Display(Name = "Табельный номер")]
        [StringLength(4, MinimumLength = 4)]
        [Range(0001, 9999, ErrorMessage = "Недопустимый табельный номер")]
        public int Tabel_id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "ФИО")]
        public string FIO { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Дата последней сдачи экзамена")]
        public DateTime? Date { get; set; }

        [Display(Name = "Примечание")]
        public string Notes { get; set; }

        public bool? passed { get; set; } = true;

        public bool? need_print { get; set; } = false;

        [Display(Name = "Подразделение")]
        [Required]
        public int dep_id { get; set; }

        [Display(Name = "Должность")]
        [Required]
        public int title_id { get; set; }

        [Display(Name = "Номер комиссии")]
        public int? NamberComission { get; set; }

        public virtual Department Department { get; set; }

        public virtual Title Title { get; set; }


        public virtual ICollection<Storage> Storages { get; set; }

        public virtual ICollection<WrongAnswer> WrongAnswers { get; set; }
    }

    public class TempEmployee
    {
        [Display(Name = "Табельный номер")]
        public int Tabel_id { get; set; }
        [Display(Name = "ФИО")]
        public string FIO { get; set; }
        [Display(Name = "Дата последней сдачи экзамена")]
        public DateTime? Date { get; set; }       
        [Display(Name = "Подразделение")]
        public string dep_id { get; set; }
        [Display(Name = "Должность")]
        public string title_id { get; set; } 
        [Display(Name = "Номер комиссии")]
        public int? NamberComission { get; set; }
        [Display(Name = "Примечание")]
        public string Notes { get; set; } = "";
    } 
}

