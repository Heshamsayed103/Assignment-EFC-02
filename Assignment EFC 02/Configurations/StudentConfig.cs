using Assignment_EFC_02.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_EFC_02.Configurations
{
    internal class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Student");
            builder.HasKey(s => s.ID);
            builder.Property(s => s.FName).HasMaxLength(50).IsRequired();
            builder.Property(s => s.LName).HasMaxLength(50).IsRequired();
            builder.Property(s => s.Address).HasMaxLength(100);
            builder.Property(s => s.Age).IsRequired();
            builder.HasOne(s => s.Department)
                   .WithMany(d => d.Students)
                   .HasForeignKey(s => s.Dep_Id);
        }
    }
}
