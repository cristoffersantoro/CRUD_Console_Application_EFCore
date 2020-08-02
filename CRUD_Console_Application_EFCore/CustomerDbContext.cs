using System;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Console_Application_EFCore
{
    public class CustomerDbContext: DbContext
    {
        public CustomerDbContext()
        {
        }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=ESHOP_CUSTOMER;;User Id=Eshop_Customer;password=!@EshopCustomer;Trusted_Connection=False;MultipleActiveResultSets=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .ToTable("TB_CUSTOMER");
                
        }
    }
}
