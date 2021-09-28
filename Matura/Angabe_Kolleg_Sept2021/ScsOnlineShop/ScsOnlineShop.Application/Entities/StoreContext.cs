﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScsOnlineShop.Application.Entities
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions opt) : base(opt) { }
        public DbSet<Store> Stores => Set<Store>();
        public DbSet<ActiveStore> ActiveStore => Set<ActiveStore>();
    }
}
