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
    internal class TopicConfig : IEntityTypeConfiguration<Topic>
    {
        public void Configure(EntityTypeBuilder<Topic> builder)
        {
            builder.ToTable("Topic");
            builder.HasKey(t => t.ID);
            builder.Property(t => t.Name).HasMaxLength(50).IsRequired();
        }
    }
}
