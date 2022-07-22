using Microsoft.EntityFrameworkCore;
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
        private const string Connection = (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Basic;Integrated Security=True;");

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //var builder = new ConfigurationB
            optionsBuilder.UseSqlServer(Connection);
        }
    }
}
