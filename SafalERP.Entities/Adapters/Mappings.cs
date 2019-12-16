using AutoMapper;
using SafalERP.Entities.Dtos.InputDtos;
using SafalERP.Entities.Dtos.OutputDtos;
using SafalERP.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SafalERP.Entities.Adapters
{
    public class Mappings : Profile
    {
        public Mappings()
        {
            CreateMap<AddStudentInputDto, Student>().ReverseMap();
            CreateMap<StudentOutputDto, Student>().ReverseMap();
            CreateMap<UpdateStudentInputDto, Student>().ReverseMap();
            CreateMap<TestOutputDto, GetTest>().ReverseMap();
            CreateMap<List<TestOutputDto>, List<GetTest>>().ReverseMap();
        }
    }
}
