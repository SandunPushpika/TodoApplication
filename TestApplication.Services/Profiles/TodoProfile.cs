using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApplication.Models;
using TestApplication.Services.Models;

namespace TestApplication.Services.Profiles
{
    public class TodoProfile : Profile {
        public TodoProfile() {
            CreateMap<TodoDto, Todo>();
        }
    }
}
