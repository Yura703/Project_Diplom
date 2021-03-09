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
        public string Quest { get; set; }

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

        [Required]
        [Display(Name = "Справка по вопросу")]
        public string Reference { get; set; }
    }

    public class TestQuest                              //вопрос из обучения
    {
        public int numberAnswer { get; set; } = 1; //порядковый номер вопроса
        public int allAnswer { get; set; } = 1;    //всего вопросов данного варианта
        public int posAnswer { get; set; } = 0;    //количество верных ответов    
        public string Quest { get; set; }
        public string Variant1 { get; set; }
        public string Variant2 { get; set; }
        public string Variant3 { get; set; }
        public byte Answer { get; set; }
        public int Var { get; set; }
        public string Reference { get; set; }
    }
}
