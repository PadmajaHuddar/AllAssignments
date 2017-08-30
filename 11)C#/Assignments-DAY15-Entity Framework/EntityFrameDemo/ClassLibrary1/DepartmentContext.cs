using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class DepartmentContext : DbContext
    {
        public DbSet<DepartmentLib> Departments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DepartmentLib>().Property(u => u.Name).HasColumnName("DeptName");
        }
    }
}
