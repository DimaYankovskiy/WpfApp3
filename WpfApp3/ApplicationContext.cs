using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WpfApp3
{
    class ApplicationContext : DbContext
    {
        public DbSet<Waiter> Waiters { get; set; }
        public DbSet<Table> Tables { get; set; }

        public ApplicationContext() : base("DefaultConnection") { }
    }
}
