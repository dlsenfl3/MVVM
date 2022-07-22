using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Basics.DataBase
{
    public class BasicDbContextFactory : IDesignTimeDbContextFactory<BasicDbContext>
    {
        private const string CONNECTION_STRING = ("Server=(localdb)\\MSSQLLocalDB;Database=BasicDb;Trusted_Connection=True;");
        public BasicDbContext CreateDbContext(string[] args = null)
        {
            var options = new DbContextOptionsBuilder<BasicDbContext>();
            options.UseSqlServer(CONNECTION_STRING);

            return new BasicDbContext(options.Options);
        }
    }
}
