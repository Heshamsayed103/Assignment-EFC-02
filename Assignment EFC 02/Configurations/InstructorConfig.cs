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
    internal class InstructorConfig : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.ToTable("Instructor");
            builder.HasKey(i => i.ID);
            builder.Property(i => i.Name).HasMaxLength(50).IsRequired();
            builder.Property(i => i.Salary).HasColumnType("decimal(18,2)");
            builder.Property(i => i.HourRate).HasColumnType("decimal(18,2)");
            builder.Property(i => i.Bouns).HasColumnType("decimal(18,2)");
            builder.HasOne(i => i.Department)
                   .WithMany(d => d.Instructors)
                   .HasForeignKey(i => i.Dept_ID);
        }
    }
}
