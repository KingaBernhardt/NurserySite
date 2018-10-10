using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationNursery.Models;

namespace WebApplicationNursery.Repositories
{
    public class NurseryContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }

        public NurseryContext(DbContextOptions<NurseryContext> options) : base(options)
        {

        }
    }
}
