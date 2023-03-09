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
            optionsBuilder.UseSqlServer("Data Source=sql.athena.domainhizmetleri.com;Initial Catalog=beetechy_staj;User ID=beetechy_staj;Password=beetechstaj;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        public DbSet<Personel> Personeller { get; set; }
    }
}
