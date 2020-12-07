using HelloWorld.Sqlite.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Sqlite.Data.Contexts
{
    public class MainDbContext : DbContext
    {
        public MainDbContext(DbContextOptions<MainDbContext> options) : base(options)
        {
            this.Database.SetCommandTimeout(120);
        }

        public DbSet<Building> Buildings { get; set; }
    }
}
