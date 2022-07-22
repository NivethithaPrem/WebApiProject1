using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiProject1.Data;
using WebApiProject1.Models;

namespace WebApiProject1.Helper
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            CreateMap<PortSlots, PortSlot>().ReverseMap();
            CreateMap<PortUsers, PortUser>().ReverseMap();
    }
    }
}
