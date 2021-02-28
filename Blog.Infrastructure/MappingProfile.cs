using AutoMapper;
using Blog.Domain.Models;
using Blog.Infrastructure.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Infrastructure
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Entity.Category, Domain.Models.Category>();
        }   
    }
}
