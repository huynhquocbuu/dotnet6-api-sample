using System;
using api_sample.Data.Entity;
using api_sample.Data.Model;
using api_sample.Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_sample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorController(IAuthorRepository authorRepository)
		{
            _authorRepository = authorRepository;

        }

        [HttpGet]
        public ActionResult<List<AuthorDto>> Get()
        {
            var data = _authorRepository.GetAuthors();
            return Ok(Data.Converter.AuthorConverter.toAuthorDtos(data)) ;
        }
    }
}

