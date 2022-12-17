using AutoMapper;
using Student_Admin_Portal_API.Datamodels;
using Student_Admin_Portal_API.DomainModels;
using System;

namespace Student_Admin_Portal_API.Profiles.AfterMaps
{
    public class AddStudentRequestAfterMap : IMappingAction<AddStudentRequestDto, Student>
    {
        public void Process(AddStudentRequestDto source, Student destination, ResolutionContext context)
        {
            destination.Id = Guid.NewGuid();
            destination.Address = new Address()
            {
                Id = Guid.NewGuid(),
                PhysicalAddress = source.PhysicalAddress,
                PostalAddress = source.PostalAddress
            };
        }
    }
}
