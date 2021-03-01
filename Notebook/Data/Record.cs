using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notebook.Data
{
    public class Record
    {
        public uint Id { get; set; }
        public String Description { get; set; }

        internal Record(uint id, String description)
        {
            Id = id;
            Description = description;
        }
    }
}
