using AutoMapper;
using LotusDijital.Entity;
using LotusDijital.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotusDijital.Business.Mapping
{
    public class GeneralMappingProfile : Profile
    {
        public GeneralMappingProfile()
        {
            CreateMap<Category, CategoryDto>().ForMember(cdto => cdto.Products, opt => opt.MapFrom(p => p.ProductCategories.Select(pc => pc.Product))).ReverseMap();
            CreateMap<Color, ColorDto>().ReverseMap();
            CreateMap<VideoGallery, VideoGalleryDto>().ReverseMap();
            CreateMap<DocumentGallery, DocumentGalleryDto>().ReverseMap();
            CreateMap<Image, ImageDto>().ReverseMap();
            CreateMap<Settings, SettingsDto>().ReverseMap();

            CreateMap<ImageGallery, ImageGalleryDto>().ForMember(imgDto => imgDto.Images, opt => opt.MapFrom(src => src.Images)).ReverseMap();

            CreateMap<InnerPage, InnerPageDto>()
                .ForMember(inpDto => inpDto.ImageGalleries, opt => opt.MapFrom(src => src.ImageGalleries))
                .ForMember(inpDto => inpDto.VideoGalleries, opt => opt.MapFrom(src => src.VideoGalleries))
                .ForMember(inpDto => inpDto.DocumentGalleries, opt => opt.MapFrom(src => src.DocumentGalleries))
                .ReverseMap();

            CreateMap<Page, PageDto>().ForMember(dest => dest.InnerPages, opt => opt.MapFrom(src => src.InnerPages)).ReverseMap();

            CreateMap<Product, ProductDto>().ForMember(pdto => pdto.Categories, opt => opt.MapFrom(p => p.ProductCategories.Select(pc => pc.Category)))
            .ForMember(pdto => pdto.ImageGalleries, opt => opt.MapFrom(src => src.ImageGalleries))
            .ForMember(pdto => pdto.VideoGalleries, opt => opt.MapFrom(src => src.VideoGalleries))
            .ForMember(pdto => pdto.DocumentGalleries, opt => opt.MapFrom(src => src.DocumentGalleries)).ReverseMap();

            CreateMap<Product, AddProductDto>().ReverseMap();
            CreateMap<Category, AddCategoryDto>().ReverseMap();
            CreateMap<ImageGallery, AddImageGalleryDto>().ReverseMap();
            CreateMap<Page, AddPageDto>().ReverseMap();
            CreateMap<InnerPage, AddInnerPageDto>().ReverseMap();

            CreateMap<Category, UpdateCategoryDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
            CreateMap<Page, UpdatePageDto>().ReverseMap();

        }
    }
}
