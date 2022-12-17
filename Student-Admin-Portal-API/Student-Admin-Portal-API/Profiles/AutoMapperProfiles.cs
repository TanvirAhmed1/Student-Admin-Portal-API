using AutoMapper;
using Student_Admin_Portal_API.Datamodels;
using Student_Admin_Portal_API.DomainModels;
using Student_Admin_Portal_API.Profiles.AfterMaps;

namespace Student_Admin_Portal_API.Profiles
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Student, StudentDto>().ReverseMap();
            CreateMap<Gender, GenderDto>().ReverseMap();
            CreateMap<Address, AddressDto>().ReverseMap();
            CreateMap<UpdateStudentRequestDto, Student>().AfterMap<UpdateStudentRequestAfretMap>();
            CreateMap<AddStudentRequestDto, Student>().AfterMap<AddStudentRequestAfterMap>();
        }
    }
}
