using EF_02.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EF_02.Configuration
{
    internal class EmployeeConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {

           builder.HasKey(e => e.Id);
           builder.Property(e => e.Id).UseIdentityColumn(10, 10);
           builder.Property(e => e.Name)
                                           .HasColumnName("EmployeeName")
                                           .HasColumnType("varchar")
                                           .HasMaxLength(50)
                                           .IsRequired();

            builder.Property(e => e.Salary).HasColumnType("decimal(18,2)").IsRequired(false);
        }
    }
}
