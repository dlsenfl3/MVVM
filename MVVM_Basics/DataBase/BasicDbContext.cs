using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MVVM_Basics.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Basics.DataBase
{
    public class BasicDbContext : DbContext
    {
        //IConfigurationRoot config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
        public DbSet<User> Users { get; set; }
        public BasicDbContext(DbContextOptions options) : base(options) { }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<User>().OwnsOne(a => a.UserName);

        //    base.OnModelCreating(modelBuilder);
        //}

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(config.GetConnectionString("BasicDb"));
        //}
    }
}
