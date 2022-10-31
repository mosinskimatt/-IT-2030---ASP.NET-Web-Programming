using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MattsSportsEmporium.Models;

namespace MattsSportsEmporium.Data
{
    public class MattsSportsEmporiumContext : DbContext
    {
        public MattsSportsEmporiumContext (DbContextOptions<MattsSportsEmporiumContext> options)
            : base(options)
        {
        }

        public DbSet<MattsSportsEmporium.Models.Products> Products { get; set; } = default!;
    }
}
