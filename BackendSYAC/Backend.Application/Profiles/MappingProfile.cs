using AutoMapper;
using Backend.Application.Features.Products.Queries.GetProductsList;
using Backend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Producto, ResponseGetProducsListQueryVm>().ReverseMap();
        }
    }
}
