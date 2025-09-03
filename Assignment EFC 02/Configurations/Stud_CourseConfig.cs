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
    internal class Stud_CourseConfig : IEntityTypeConfiguration<Stud_Course>
    {
        public void Configure(EntityTypeBuilder<Stud_Course> builder)
        {
            builder.ToTable("Stud_Course");
            builder.HasKey(sc => new { sc.stud_ID, sc.Course_ID });

            builder.HasOne(sc => sc.Student)
                   .WithMany(s => s.Stud_Courses)
                   .HasForeignKey(sc => sc.stud_ID);

            builder.HasOne(sc => sc.Course)
                   .WithMany(c => c.Stud_Courses)
                   .HasForeignKey(sc => sc.Course_ID);
        }
    }
}
