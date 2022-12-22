using AutoMapper;
using DmsTaskChallenge.Domain.DTOs;
using DmsTaskChallenge.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DmsTaskChallenge.Domain.MappingProfiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<ItemRequestDTO,Item>();
            CreateMap<UomRequestDTO, Uom>();
            CreateMap<Item, ItemResponseDTO>();
            CreateMap<Uom, UomResponseDTO>();
        }
    }
}
