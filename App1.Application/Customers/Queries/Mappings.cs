﻿using App1.Application.Common;
using App1.Domain.Entities;
using AutoMapper;

namespace App1.Application.Customers.Queries
{
    public class Mappings : Profile
    {
        public Mappings()
        {
            CreateMap<Person, CustomerDto>();
        }
    }
}
