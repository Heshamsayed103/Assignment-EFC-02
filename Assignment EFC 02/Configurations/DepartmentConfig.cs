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
    internal class DepartmentConfig : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("Department");
            builder.HasKey(d => d.ID);
            builder.Property(d => d.Name).HasMaxLength(50).IsRequired();
            builder.Property(d => d.HiringDate).HasColumnType("date");
        }
    }
}
