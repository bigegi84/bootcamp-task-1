using AutoMapper;

namespace SampleRESTAPI.Profiles
{
    public class CoursesProfile : Profile
    {
        public CoursesProfile()
        {
            CreateMap<Dtos.CourseDto,Models.Course>();
            CreateMap<Models.Course,Dtos.CourseDto>();

            CreateMap<Dtos.CourseForCreateDto,Models.Course>();
            CreateMap<Models.Course,Dtos.CourseForCreateDto>();
        }
    }
}
