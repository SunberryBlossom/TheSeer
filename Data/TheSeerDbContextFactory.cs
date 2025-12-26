using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace TheSeer.Data
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<TheSeerDbContext>
    {
        public TheSeerDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true).AddUserSecrets<AppDbContextFactory>().Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            var optionsBuilder = new DbContextOptionsBuilder<TheSeerDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new TheSeerDbContext(optionsBuilder.Options);
        }
    }
}