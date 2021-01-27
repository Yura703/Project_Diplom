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

        public int Questions_1 { get; set; }

        public int Questions_2 { get; set; }

        public int Questions_3 { get; set; }

        public int Questions_4 { get; set; }

        public int Variant { get; set; }

        public virtual Question Question { get; set; }

        public virtual Question Question1 { get; set; }

        public virtual Question Question2 { get; set; }

        public virtual Question Question3 { get; set; }

        public virtual ICollection<Storage> Storages { get; set; }
    }
}
