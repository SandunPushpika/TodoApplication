using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApplication.Models;

namespace TestApplication.DataAccess
{
    public class TodoContext : DbContext {
        public DbSet<Todo> Todos { get; set; }
        public DbSet<Author> authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            string connection_string = "Server=localhost; Database=tododb; persist security info=True; Integrated Security = SSPI; ";
            optionsBuilder.UseSqlServer(connection_string);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Author>().HasData(new Author[] {
                new Author { id = 1, name="sandun", adressnb="162/4",city="Ambalangoda",street="Athvalagoda"},
                new Author { id = 2, name="kashmir", adressnb="1678B",city="Los Angeles",street="Mension Street"},
                new Author { id = 3, name="jackob", adressnb="54",city="Okhlama",street="Denist Street"},
                new Author { id = 4, name="jenny", adressnb="162/4",city="Sillycan Valley",street="FB Street"}
            });
            modelBuilder.Entity<Todo>().HasData(new Todo[] {
                new Todo {
                    Id = 1,
                    title = "test",
                    description = " test descriptions",
                    created = DateTime.Now,
                    due = DateTime.Now.AddDays(2),
                    status = TodoStatus.Inprogress,
                    authorid = 1
                },
                new Todo {
                    Id = 2,
                    title = "learn dotnet",
                    description = " second attempt",
                    created = DateTime.Now,
                    due = DateTime.Now.AddDays(2),
                    status = TodoStatus.New,
                    authorid = 1
                },
                new Todo {
                    Id = 3,
                    title = "go home",
                    description = " This is to learn dotnet",
                    created = DateTime.Now,
                    due = DateTime.Now.AddDays(5),
                    status = TodoStatus.Completed,
                    authorid = 4
                }
            });
        }
    }
}
