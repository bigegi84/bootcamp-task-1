using AutoMapper;

namespace SampleRESTAPI.Profiles
{
    public class AuthorsProfile : Profile
    {
        public AuthorsProfile()
        {
            CreateMap<Dtos.AuthorDto,Models.Author>();
            CreateMap<Models.Author,Dtos.AuthorDto>();

            CreateMap<Dtos.AuthorForCreateDto,Models.Author>();
            CreateMap<Models.Author,Dtos.AuthorForCreateDto>();
        }
    }
}
