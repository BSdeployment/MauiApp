using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiShop.Data
{
    public class ShopingContext : DbContext

    {
        public ShopingContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<ShopingModel>? Shopings { get; set; }
    }
}
