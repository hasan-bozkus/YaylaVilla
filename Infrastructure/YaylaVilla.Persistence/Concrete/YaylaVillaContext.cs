using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Domain.Entites;

namespace YaylaVilla.Persistence.Concrete
{
    public class YaylaVillaContext : DbContext
    {
        public YaylaVillaContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<TagCloud> TagClouds { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<WorkFlow> WorkFlows { get; set; }
    }
}
