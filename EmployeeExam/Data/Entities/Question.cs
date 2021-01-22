using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeExam.Data.Entities
{
    public class Question
    {
        [Key]
        public int Questions_id { get; set; }

        [Required]
        [Display(Name = "Вопрос")]
        public string Quest { get; set; }//-----------------------------------

        [Required]
        [Display(Name = "Ответ №1")]
        public string Variant1 { get; set; }

        [Required]
        [Display(Name = "Ответ №2")]
        public string Variant2 { get; set; }

        [Required]
        [Display(Name = "Ответ №3")]
        public string Variant3 { get; set; }

        [Required]
        [Range(1, 3, ErrorMessage = "Недопустимый номер")]
        [Display(Name = "Номер верного ответа")]
        public byte Answer { get; set; }

        [Required]
        [Range(1, 50, ErrorMessage = "Недопустимый номер")]
        [Display(Name = "Номер варианта")]
        public int Var { get; set; }       
    }
}
