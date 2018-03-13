using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace guardian.service.Models
{
    public class GuardianContext : DbContext
    {
        public GuardianContext(DbContextOptions<GuardianContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<System> Systems { get; set; }
        public DbSet<Module> Modules { get; set; }
    }
}
