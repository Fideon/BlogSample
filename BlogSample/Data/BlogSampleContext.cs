using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlogSample.Models;

namespace BlogSample.Data
{
    public class BlogSampleContext : DbContext
    {
        public BlogSampleContext (DbContextOptions<BlogSampleContext> options)
            : base(options)
        {
        }

        public DbSet<BlogSample.Models.BlogPost> BlogPost { get; set; }
    }
}
