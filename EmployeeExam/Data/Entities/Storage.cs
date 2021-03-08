using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeExam.Data.Entities

{
    public class Storage
    {
        [Key]
        public int Storage_id { get; set; }

        public int Tests_id { get; set; }

        public int Tabel_id { get; set; }

        public DateTime Data_Quest { get; set; }

        public bool Result { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Test Test { get; set; }
    }
}
