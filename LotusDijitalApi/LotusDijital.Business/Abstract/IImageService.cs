﻿using LotusDijital.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotusDijital.Business.Abstract
{
    public interface IImageService : IService<ImageDto>
    {
        Task<bool> CreateAsync(ImageDto imageDto);
    }
}
