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
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Color, ColorDto>().ReverseMap();
            CreateMap<DocumentGallery, DocumentGalleryDto>().ReverseMap();
            CreateMap<ImageGallery, ImageGalleryDto>().ReverseMap();
            CreateMap<InnerPage, InnerPageDto>().ReverseMap();
            CreateMap<Page, PageDto>().ReverseMap();
            CreateMap<Product, ProductDto>().ForMember(pdto => pdto.Categories, opt => opt.MapFrom(p => p.ProductCategories.Select(pc => pc.Category))).ReverseMap();
            CreateMap<VideoGallery, VideoGalleryDto>().ReverseMap();
        }
    }
}
