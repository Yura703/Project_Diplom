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

        public int NamberComission { get; set; }

        [Required]
        [StringLength(50)]
        public string FIO { get; set; }

        public bool Head { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }
    }

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class TestQuest//вопрос из обучения
    {
        public int numberAnswer { get; set; } = 0; //порядковый номер вопроса
        public int allAnswer { get; set; } = 1;    //всего вопросов данного варианта
        public int posAnswer { get; set; } = 0;    //количество верных ответов  
        public int variant { get; set; } = 0;
       
    }
}
