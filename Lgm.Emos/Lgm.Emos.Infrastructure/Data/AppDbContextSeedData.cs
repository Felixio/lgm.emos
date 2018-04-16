using Lgm.Emos.Core.Entities;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lgm.Emos.Infrastructure.Data
{
    public class AppDbContextSeedData
    {
        public static async Task SeedAsync(IServiceProvider services)
        {
            var context = services.GetRequiredService<AppDbContext>();

            await Task.CompletedTask;

            // Check if data should be seeded
            //if (!context.Tools.Any())
            //{
            //    var tools = new List<Tool>
            //    {
            //        new Tool { Ref= "Ref1", Description="This is a tool"},
            //        new Tool { Ref= "Ref2", Description="This is a tool"},
            //        new Tool { Ref= "Ref3", Description="This is a tool"},
            //        new Tool { Ref= "Ref4", Description="This is a tool"}
            //    };

            //    context.Tools.AddRange(tools);
            //    await context.SaveChangesAsync();   // Add data
            //}
        }
    }
}
