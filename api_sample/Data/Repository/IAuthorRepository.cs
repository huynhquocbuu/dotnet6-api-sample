using System;
using api_sample.Data.Entity;

namespace api_sample.Data.Repository
{
	public interface IAuthorRepository
	{
        public List<Author> GetAuthors();
    }
}

