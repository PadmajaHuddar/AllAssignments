using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conn
{
    public class ConnContext: DbContext
    { 
            public DbSet<Emp> Emps { get; set; }

            //protected override void OnModelCreating(DbModelBuilder modelBuilder)
            //{
            //    modelBuilder.Entity<Emp>().Property(u => u.Name).HasColumnName("DeptName");
            //}
        
    }
}
