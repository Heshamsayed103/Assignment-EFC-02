using EF_02.Configuration;
using EF_02.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EF_02.Context
{
    internal class AppDbContext : DbContext
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Employee>().HasKey("Id");

            //modelBuilder.Entity<Employee>().HasKey(e => e.Id);
            //modelBuilder.Entity<Employee>().HasKey(nameof(Employee.Id));

            //modelBuilder.Entity<Employee>().HasKey(e => e.Id);
            //modelBuilder.Entity<Employee>().Property(e => e.Id).UseIdentityColumn(10, 10);
            //modelBuilder.Entity<Employee>().Property(e => e.Name)
            //                               .HasColumnName("EmployeeName")
            //                               .HasColumnType("varchar")
            //                               .HasMaxLength(50)
            //                               .IsRequired();

            modelBuilder.ApplyConfiguration(new EmployeeConfig());
            modelBuilder.ApplyConfiguration(new DepartmentConfig());

            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


            base.OnModelCreating(modelBuilder);
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Code To Connect To DB
            optionsBuilder.UseSqlServer("Server = FARES\\SQLEXPRESS01; Database = AppDB02; Trusted_Connection = True; TrustServerCertificate = True;");
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<Course> courses { get; set; }



    }
}
