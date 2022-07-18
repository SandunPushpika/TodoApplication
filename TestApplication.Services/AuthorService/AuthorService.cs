using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApplication.DataAccess;
using TestApplication.Models;

namespace TestApplication.Services.AuthorService
{
    
    public class AuthorService : IAuthorRepository {
        private readonly TodoContext _context = new TodoContext();

        public Author CreateAuthor(Author author) {
            _context.authors.Add(author);

            return _context.authors.Find(author.id);
        }

        public List<Author> getAthors() {
            return _context.authors.ToList();
        }

        public Author getAuthor(int id) {
            return _context.authors.Find(id);
        }

        public List<Author> getAuthors(string name) {
            if (string.IsNullOrWhiteSpace(name)) {
                return getAthors();
            }
            name = name.Trim();
            return _context.authors.Where(table => table.name == name).ToList();
        }
    }
}
