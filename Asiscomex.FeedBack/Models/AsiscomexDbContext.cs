using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Asiscomex.FeedBack.Models
{
    public class AsiscomexDbContext:DbContext
    {
        public AsiscomexDbContext(DbContextOptions<AsiscomexDbContext> options)
            : base(options)
        {
        }

        public DbSet<Task> Tasks { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
