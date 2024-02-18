using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Batman.Models;

namespace Batman.Data
{
    public class BatmanContext : DbContext
    {
        public BatmanContext (DbContextOptions<BatmanContext> options)
            : base(options)
        {
        }

        public DbSet<Batman.Models.Person> Person { get; set; } = default!;
    }
}
