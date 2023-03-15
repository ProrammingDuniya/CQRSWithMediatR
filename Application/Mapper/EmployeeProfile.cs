using Application.Model;
using AutoMapper;
using Core;

namespace Application.Mapper
{
    public class EmployeeProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeProfile"/> class.
        /// </summary>
        public EmployeeProfile()
        {
            CreateMap<EmployeeReadModel, Employee>().ReverseMap();
            CreateMap<EmployeeCreateModel, Employee>().ReverseMap();
        }
    }


}
