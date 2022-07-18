using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApplication.Models;
using TestApplication.Services.Models;

namespace TestApplication.Services.Profiles {
    public class AuthorProfile : Profile{
        public AuthorProfile() {
            CreateMap<Author, AuthorsDto>()
                .ForMember(dest => dest.adress,opt => opt.MapFrom(src => $"{src.adressnb}, {src.street}, {src.city}"));
            CreateMap<CreateAuthorDto, Author>();
        }
    }
}
