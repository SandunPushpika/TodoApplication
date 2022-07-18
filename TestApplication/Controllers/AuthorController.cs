using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApplication.Models;
using TestApplication.Services.AuthorService;
using TestApplication.Services.Models;

namespace TestApplication.Controllers {
    [Route("api/authors")]
    [ApiController]
    public class AuthorController : ControllerBase{
        private readonly IAuthorRepository _repo;
        private readonly IMapper _mapper;

        public AuthorController(IAuthorRepository repo, IMapper mapper) {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult getAuthors([FromQuery] string name) {
            var authors = _repo.getAuthors(name);
            var mappedValues = _mapper.Map<ICollection<AuthorsDto>>(authors);

            return Ok(mappedValues);
        }

        [HttpGet("{id}",Name ="getAuthor")]
        public IActionResult getAuthor(int id) {
            var author = _repo.getAuthor(id);
            var mapped_author = _mapper.Map<AuthorsDto>(author);

            if (author == null) return NotFound();

            return Ok(mapped_author);
        }

        [HttpPost]
        public ActionResult<AuthorsDto> CreateAuthor(CreateAuthorDto au) {
            var author = _mapper.Map<Author>(au);

            var authorDto = _mapper.Map<AuthorsDto>(_repo.CreateAuthor(author));
            
            return CreatedAtRoute("getAuthor",new { id=authorDto.id},authorDto);
        }


    }
}
