using System;
namespace api_sample.Data.Entity
{
	public class Book
	{
        public int Id { get; set; }
        public string Title { get; set; }
        public Author Author { get; set; }
    }
}

