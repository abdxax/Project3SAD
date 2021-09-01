using Microsoft.EntityFrameworkCore;
using ProjectSAD3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectSAD3.Data
{
    public class DContext:DbContext
    {
        public DContext()
        {

        }
        public DContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Computer> computers { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<User> users { get; set; }

       /* protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source= LAPTOP-7KTRGKH2\SQLEXPRESS; Integrated Security=true;Initial Catalog=computers; ");
            //base.OnConfiguring(optionsBuilder);
        }*/
    }
}
