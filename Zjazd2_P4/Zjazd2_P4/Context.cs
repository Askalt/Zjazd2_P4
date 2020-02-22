using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Zjazd2_P4
{
   public class Context :DbContext
    {
        public DbSet<Zajecia> Zajecias { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Database=EFCE;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        //Fluent
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder
        //        .Entity<Zajecia>()
        //        .HasKey(x => x.Id);
        //    modelBuilder
        //        .Entity<Zajecia>()
        //        .Property(x => x.Nazwa)
        //            .IsRequired();
       
        //}
    }
}
