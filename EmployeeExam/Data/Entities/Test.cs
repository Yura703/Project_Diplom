using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeExam.Data.Entities
{
    public class Test
    {
        public Test()
        {
            Storages = new HashSet<Storage>();
        }

        [Key]
        public int Tests_id { get; set; }

        [Display(Name = "Вопрос №1")]
        public int Questions_1 { get; set; }

        [Display(Name = "Вопрос №2")]
        public int Questions_2 { get; set; }

        [Display(Name = "Вопрос №3")]
        public int Questions_3 { get; set; }

        [Display(Name = "Вопрос №4")]
        public int Questions_4 { get; set; }

        [Display(Name = "Вариант")]
        public int Variant { get; set; }

        [Display(Name = "Номер билета")]
        public int NumberTicket { get; set; }

        public virtual Question Question { get; set; }

        public virtual Question Question1 { get; set; }

        public virtual Question Question2 { get; set; }

        public virtual Question Question3 { get; set; }

        public virtual ICollection<Storage> Storages { get; set; }
    }
}
