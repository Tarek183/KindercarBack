using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KindercarBack.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
            
        }
        public DbSet<Kindergarten> Kindergartens { get; set; }
        public DbSet<Claim> Claims { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Program> Programs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Canteen> Canteens { get; set; }

    }
}
