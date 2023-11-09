using LotusDijital.Business.Abstract;
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
        public Task<bool> CreateAsync(ImageGalleryDto entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(ImageGalleryDto entity)
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

        public Task<bool> UpdateAsync(ImageGalleryDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
