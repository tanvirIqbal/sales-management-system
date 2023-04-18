using Microsoft.EntityFrameworkCore;
using SMS.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.DAL.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
                : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }
    }
}
