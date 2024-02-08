using AutoMapper;
using LotusDijital.Business.Abstract;
using LotusDijital.Data.Abstract;
using LotusDijital.Entity;
using LotusDijital.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LotusDijital.Business.Concrete
{
    public class ImageGalleryManager : IImageGalleryService
    {
        private readonly IMapper _mapper;
        private readonly IImageGalleryReposiyory _imageGalleryReposiyory;
        private readonly IImageService _imageService;

        public ImageGalleryManager(IMapper mapper, IImageGalleryReposiyory imageGalleryReposiyory, IImageService imageService)
        {
            _mapper = mapper;
            _imageGalleryReposiyory = imageGalleryReposiyory;
            _imageService = imageService;
        }

        public async Task<bool> CreateAsync(AddImageGalleryDto addImageGalleryDto)
        {
            var imageGallery = _mapper.Map<ImageGallery>(addImageGalleryDto);
            var result = await _imageGalleryReposiyory.CreateAsync(imageGallery);
            
                foreach (var image in addImageGalleryDto.Images)
                {
                    image.ImageGalleryId = result.Id;
                    var r = _imageService.CreateAsync(image);
                }
            
            return result != null;
        }

        public Task<bool> DeleteAsync(ImageGalleryDto tDto)
        {
            throw new NotImplementedException();
        }

        public Task<List<ImageGalleryDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ImageGalleryDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ImageGalleryDto>> GetManyAsync(Expression<Func<ImageGalleryDto, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
