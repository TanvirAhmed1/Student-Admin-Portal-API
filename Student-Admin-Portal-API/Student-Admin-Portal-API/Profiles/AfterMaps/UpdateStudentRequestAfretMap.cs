using AutoMapper;
using Student_Admin_Portal_API.Datamodels;
using Student_Admin_Portal_API.DomainModels;

namespace Student_Admin_Portal_API.Profiles.AfterMaps
{
    public class UpdateStudentRequestAfretMap : IMappingAction<UpdateStudentRequestDto, Student>
    {
        public void Process(UpdateStudentRequestDto source, Student destination, ResolutionContext context)
        {
            destination.Address = new Address()
            {
                PhysicalAddress = source.PhysicalAddress,
                PostalAddress = source.PostalAddress
            };
        }
    }
}
