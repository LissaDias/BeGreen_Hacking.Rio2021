﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeGreen.Models;
using BeGreen.Dtos.Parceiro;

namespace BeGreen.Profiles
{
    public class ParceiroProfile : Profile
    {
        public ParceiroProfile()
        {
            CreateMap<CreateParceiroDto, Parceiro>();
            CreateMap<Parceiro, ReadParceiroDto>();
            CreateMap<UpdateParceiroDto, Parceiro>();
        }
    }
}
