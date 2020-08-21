using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ServiceToGo.Data;

namespace ServiceToGo.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            //using (var context = new ServiceToGoContext(
            //    serviceProvider.GetRequiredService<
            //        DbContextOptions<ServiceToGoContext>>()))
            //{
            //    if (context.Vendors.Any())
            //    {
            //        return;
            //    }

            //    context.Vendors.AddRange(
            //        new Vendors
            //        {
            //            CompanyName = "ABC",
            //            Email = "abc@gmail.com",
            //            Phone = "123456"
            //        },

            //        new Vendors
            //        {
            //            CompanyName = "DEF",
            //            Email = "def@gmail.com",
            //            Phone = "987654"
            //        }
            //        );
            //    context.SaveChanges();
            //}
        }
    }
}
