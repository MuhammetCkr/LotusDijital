using LotusDijital.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotusDijital.Business.Abstract
{
    public interface IImageGalleryService : IService<ImageGalleryDto>
    {
        Task<bool> CreateAsync(AddImageGalleryDto addImageGalleryDto);
        Task<ImageGalleryDto> GetImageGalleryDto(int id);
        Task<List<ImageGalleryDto>> GetImageGalleryListDto();
    }
}
