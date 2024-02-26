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

        public async Task<bool> DeleteAsync(ImageGalleryDto tDto)
        {
            var imageGallery = _mapper.Map<ImageGallery>(tDto);
            var result = await _imageGalleryReposiyory.DeleteAsync(imageGallery);
            return result;
        }

        public Task<List<ImageGalleryDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<ImageGalleryDto> GetByIdAsync(int id)
        {
            var gallery = await _imageGalleryReposiyory.GetByIdAsync(id);
            var galleryDto = _mapper.Map<ImageGalleryDto>(gallery);
            return galleryDto;
        }

        public async Task<ImageGalleryDto> GetImageGalleryDto(int id)
        {
            var imageGallery = await _imageGalleryReposiyory.GetImageGallery(id);
            var imageGalleryDto = _mapper.Map<ImageGalleryDto>(imageGallery);
            return imageGalleryDto;
        }

        public async Task<List<ImageGalleryDto>> GetImageGalleryListDto()
        {
            var imageGalleryList = await _imageGalleryReposiyory.GetImageGalleryListDto();
            var imageGalleryListDto = _mapper.Map<List<ImageGalleryDto>>(imageGalleryList);
            return imageGalleryListDto;
        }

        public Task<List<ImageGalleryDto>> GetManyAsync(Expression<Func<ImageGalleryDto, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
