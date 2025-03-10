using AutoMapper;
using StudentManagement.Data.Entities;

namespace StudentManagement.ViewModels.AutoMapper;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<StudentCreateRequest, Student>();
        CreateMap<Student, StudentViewModel>();
    }
}