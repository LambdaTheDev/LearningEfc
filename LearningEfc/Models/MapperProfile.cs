using System;
using AutoMapper;

namespace LearningEfc.Models
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            Console.WriteLine("STARTED");

            CreateMap<Bar, BarDto>();
            CreateMap<Foo, FooDto>();
            CreateMap<Foo, FooTestDto>();
        }
    }
}