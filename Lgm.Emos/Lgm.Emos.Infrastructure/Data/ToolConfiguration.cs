using System;
using Lgm.Emos.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lgm.Emos.Infrastructure.Data
{
    public class ToolConfiguration : IEntityTypeConfiguration<Tool>
    {
        public void Configure(EntityTypeBuilder<Tool> builder)
        {
            // Id Column
            builder.HasKey(t => t.Id);

            // Ref Column
            builder.Property(t => t.Ref)
                   .IsRequired();

            // Description Column
            builder.Property(t => t.Description)
                   .HasMaxLength(256);
        }
    }
}
