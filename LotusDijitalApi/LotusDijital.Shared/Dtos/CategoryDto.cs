﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotusDijital.Shared.Dtos
{
    public class CategoryDto : BaseDto
    {
        public string Image { get; set; }
        public string Details { get; set; }
        public List<ProductDto> Products { get; set; }

    }
}
