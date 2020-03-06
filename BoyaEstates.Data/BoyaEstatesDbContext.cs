using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoyaEstates.Data
{
    public class BoyaEstatesDbContext : DbContext
    {
        public BoyaEstatesDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Property> Properties { get; set; }
    }
}
