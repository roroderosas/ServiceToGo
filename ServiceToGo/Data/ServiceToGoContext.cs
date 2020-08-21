using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ServiceToGo.Models;

namespace ServiceToGo.Data
{
    public class ServiceToGoContext : DbContext
    {
        public ServiceToGoContext (DbContextOptions<ServiceToGoContext> options)
            : base(options)
        {
        }

        public DbSet<ServiceToGo.Models.Vendors> Vendors { get; set; }

        public DbSet<ServiceToGo.Models.NewClients> NewClients { get; set; }
    }
}
