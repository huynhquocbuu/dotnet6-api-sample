using System;
using api_sample.Data.Entity;

namespace api_sample.Data.Model
{
	public class AuthorDto
	{
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<BookDto> Books { get; set; }
    }
}