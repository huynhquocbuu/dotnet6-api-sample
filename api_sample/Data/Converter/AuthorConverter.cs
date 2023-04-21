using System;
using api_sample.Data.Entity;
using api_sample.Data.Model;

namespace api_sample.Data.Converter
{
	public static class AuthorConverter
    {
		public static AuthorDto toAuthorDto(Author author)
		{
			AuthorDto rt = new AuthorDto();
			if (author.Books.Any())
			{
				List<BookDto> books = new List<BookDto>();
				foreach (var item in author.Books)
				{
					books.Add(new BookDto()
					{
						Id = item.Id,
						Title = item.Title

					});
				}
				rt.Books = books;

            }
			return rt;
        }

        public static List<AuthorDto> toAuthorDtos(List<Author> authors)
		{
			List<AuthorDto> rt = new List<AuthorDto>();
			foreach (Author item in authors)
			{
				rt.Add(toAuthorDto(item));

            }
			return rt;
        }

    }
}

