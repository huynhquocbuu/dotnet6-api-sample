using System;
using System.Linq;
using api_sample.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace api_sample.Data.Repository
{
	public class AuthorRepository : IAuthorRepository
    {
        private readonly ApiDbContext _dbContext;

        public AuthorRepository(ApiDbContext apiDbContext)
		{
            _dbContext = apiDbContext;
            dataInit(apiDbContext);

        }
        private void dataInit(ApiDbContext dbContext)
        {
            var authors = new List<Author>() {
                new Author
                {
                    FirstName ="Joydip",
                    LastName ="Kanjilal",
                       Books = new List<Book>()
                    {
                        new Book { Title = "Mastering C# 8.0"},
                        new Book { Title = "Entity Framework Tutorial"},
                        new Book { Title = "ASP.NET 4.0 Programming"}
                    }
                },
                new Author
                {
                    FirstName ="Yashavanth",
                    LastName ="Kanetkar",
                    Books = new List<Book>()
                    {
                        new Book { Title = "Let us C"},
                        new Book { Title = "Let us C++"},
                        new Book { Title = "Let us C#"}
                    }
                }
            };

            if (!dbContext.Authors.Any())
            {
                dbContext.Authors.AddRange(authors);
                dbContext.SaveChanges();
            }


            
        }
        public List<Author> GetAuthors()
        {
            var list = _dbContext.Authors
                    .Include(a => a.Books)
                    .ToList();
            return list;
        }

    }
}

