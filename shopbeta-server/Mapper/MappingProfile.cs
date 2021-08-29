using AutoMapper;
using shopbeta.Core.DTO;
using shopbeta.Core.DTO.Requests;
using shopbeta.Core.DTO.Response;
using shopbeta.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopbeta.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ProductsRequestDto, Product>();
            CreateMap<Product, ProductsResponseDto>();
            CreateMap<OrderCreationDto, Order>();
            CreateMap<OrderItemRequestDto, OrderItem>();

            CreateMap<BuyerRegistration, User>();
            CreateMap<SellerRegistration, User>();
           


        }

    }
}
