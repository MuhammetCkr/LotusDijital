using LotusDijital.Business.Abstract;
using LotusDijital.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LotusDijital.Business.Concrete
{
    public class VideoGalleryManager : IVideoGalleryService
    {
        public Task<bool> DeleteAsync(VideoGalleryDto tDto)
        {
            throw new NotImplementedException();
        }

        public Task<List<VideoGalleryDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<VideoGalleryDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<VideoGalleryDto>> GetManyAsync(Expression<Func<VideoGalleryDto, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
