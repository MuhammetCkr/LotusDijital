﻿using LotusDijital.Business.Abstract;
using LotusDijital.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LotusDijital.Business.Concrete
{
    public class DocumentGalleryManager : IDocumentGalleryService
    {
        public Task<bool> DeleteAsync(DocumentGalleryDto tDto)
        {
            throw new NotImplementedException();
        }

        public Task<List<DocumentGalleryDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<DocumentGalleryDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<DocumentGalleryDto>> GetManyAsync(Expression<Func<DocumentGalleryDto, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
