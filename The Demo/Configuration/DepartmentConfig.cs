using EF_02.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_02.Configuration
{
    internal class DepartmentConfig : IEntityTypeConfiguration<Department>

    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
         
            builder.HasKey(d => d.Id);
            builder.Property(d => d.Id).UseIdentityColumn(100,100);
            builder.Property(d => d.DeptName).HasColumnName("DepartmentName")
                .HasMaxLength(100);  
                

        }
    }
}
