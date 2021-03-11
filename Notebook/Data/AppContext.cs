using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notebook.Data
{
    namespace BookApp.Data
    {
        public class AplicationContext : DbContext
        {
            public AplicationContext() { }
            public AplicationContext(DbContextOptions<AplicationContext> options) : base(options)
            { }
        }
    }
}
