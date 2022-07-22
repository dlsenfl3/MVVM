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
        //private const string CONNECTION_STRING = (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Basic;Integrated Security=True;");
        IConfigurationRoot config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(CONNECTION_STRING);
            optionsBuilder.UseSqlServer(config.GetConnectionString("BasicDb"));
        }
    }
}
