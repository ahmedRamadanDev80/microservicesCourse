﻿using AutoMapper;
using Micro.Services.CouponAPI.Models;
using Micro.Services.CouponAPI.Models.Dtos;

namespace Micro.Services.CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDto, Coupon>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
