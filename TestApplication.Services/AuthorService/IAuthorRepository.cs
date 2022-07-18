using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApplication.Models;

namespace TestApplication.Services.AuthorService
{
    public interface IAuthorRepository
    {
        public List<Author> getAthors();
        public Author getAuthor(int id);
        public List<Author> getAuthors(string name);
        public Author CreateAuthor(Author author);
    }
}
