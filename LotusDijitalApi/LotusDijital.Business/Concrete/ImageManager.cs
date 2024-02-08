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
    public class ImageManager : IImageService
    {
        private readonly IImageRespository _imageRespository;
        private readonly IMapper _mapper;

        public ImageManager(IImageRespository imageRespository, IMapper mapper)
        {
            _imageRespository = imageRespository;
            _mapper = mapper;
        }

        public async Task<bool> CreateAsync(ImageDto imageDto)
        {
            var image = _mapper.Map<Image>(imageDto);
            var result = await _imageRespository.CreateAsync(image);
            return result != null;
        }

        public Task<bool> DeleteAsync(ImageDto tDto)
        {
            throw new NotImplementedException();
        }

        public Task<List<ImageDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ImageDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ImageDto>> GetManyAsync(Expression<Func<ImageDto, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
