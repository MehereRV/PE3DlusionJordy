using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PE3.Dlusion.Entities
{
    public class DlusionDbContext : DbContext
    {
        public DlusionDbContext(DbContextOptions<DlusionDbContext> options) : base(options)
        {
        }
        public DbSet<User> User { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<QueueItem> PlayQueue { get; set; }
        public DbSet<QueueItem> PostPlayQueue { get; set; }
    }
}