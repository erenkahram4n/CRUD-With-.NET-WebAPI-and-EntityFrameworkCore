using Microsoft.EntityFrameworkCore;
using PersonelFinder.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonelFinder.DataAccess
{
    class PersonelDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Connection String");
        }
        public DbSet<Personel> Personeller { get; set; }
    }
}
