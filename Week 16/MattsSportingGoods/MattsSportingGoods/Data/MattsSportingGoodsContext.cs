using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MattsSportingGoods.Models;

namespace MattsSportingGoods.Data
{
    public class MattsSportingGoodsContext : DbContext
    {
        public MattsSportingGoodsContext (DbContextOptions<MattsSportingGoodsContext> options)
            : base(options)
        {
        }

        public DbSet<MattsSportingGoods.Models.Products> Products { get; set; } = default!;
    }
}
