using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Notebook.Entities
{
    public class Record
    {
        public Record()
        {

        }

        public Record(int id)
        {
            Id = id;
        }
        [Key]
        public int Id { get; set; }
        public String Description { get; set; }
        public bool IsComplete { get; set; }
        public DateTime? CompleteDate { get; set; }
    }
}
