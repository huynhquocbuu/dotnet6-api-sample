using System;
using api_sample.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace api_sample.Data
{
	public class ApiDbContext:  DbContext
	{
        protected readonly IConfiguration Configuration;

        public ApiDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring
            (DbContextOptionsBuilder options)
        {
            // in memory database used for simplicity, change to a real db for production applications
            options.UseInMemoryDatabase("TestDb");
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}

