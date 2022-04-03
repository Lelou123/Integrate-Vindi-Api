using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Api_Vindi.Models;

namespace Api_Vindi.Data
{
    public class Api_VindiContext : DbContext
    {
        public Api_VindiContext (DbContextOptions<Api_VindiContext> options)
            : base(options)
        {
        }

        public DbSet<Api_Vindi.Models.User> User { get; set; }
    }
}
