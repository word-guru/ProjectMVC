﻿using BookMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace BookMVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options)
            : base(options) { }

        public DbSet<Category> Categories { get; set; }

    }
}
