using AutoMapper;
using ECommerce.Models;
using ECommerce.Models.ViewModels.Products;

namespace ECommerce.Services.Mappers.AutoMapperProfile;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<ProductAddViewModel, Product>();
    }
}