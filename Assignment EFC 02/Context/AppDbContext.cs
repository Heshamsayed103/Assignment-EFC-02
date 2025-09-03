using Assignment_EFC_02.Configurations;
using Assignment_EFC_02.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_EFC_02.Context
{
    internal class AppDbContext : DbContext
    {

        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Stud_Course> Stud_Courses { get; set; }
        public DbSet<Course_Inst> Course_Instructors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=HESHAM;Database=Assignment_EFC_02;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentConfig());
            modelBuilder.ApplyConfiguration(new DepartmentConfig());
            modelBuilder.ApplyConfiguration(new CourseConfig());
            modelBuilder.ApplyConfiguration(new InstructorConfig());
            modelBuilder.ApplyConfiguration(new TopicConfig());
            modelBuilder.ApplyConfiguration(new Stud_CourseConfig());
            modelBuilder.ApplyConfiguration(new Course_InstConfig());
        }
    }
}
