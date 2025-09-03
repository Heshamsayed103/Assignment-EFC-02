using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_EFC_02.Entities;

namespace Assignment_EFC_02.Configurations
{
    internal class CourseConfig : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("Course");
            builder.HasKey(c => c.ID);
            builder.Property(c => c.Name).HasMaxLength(50).IsRequired();
            builder.Property(c => c.Description).HasMaxLength(200);
            builder.HasOne(c => c.Topic)
                   .WithMany(t => t.Courses)
                   .HasForeignKey(c => c.Top_ID);
        }
    }
}
