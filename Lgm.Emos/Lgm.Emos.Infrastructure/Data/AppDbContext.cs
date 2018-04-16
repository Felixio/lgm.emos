using System;
using Lgm.Emos.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lgm.Emos.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }

        public DbSet<Tool> Tools { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ToolConfiguration());
		}
	}
}
