using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeExam.Data.Entities
{
    public class WrongAnswer
    {
        [Key]
        public int WrongAnswers_id { get; set; }

        public int Tabel_id { get; set; }

        public int Questions_id { get; set; }

        public short Question_number { get; set; }

        public DateTime Date_Test { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
