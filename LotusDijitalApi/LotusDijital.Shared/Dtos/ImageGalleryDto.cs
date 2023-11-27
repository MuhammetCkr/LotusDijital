using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotusDijital.Shared.Dtos
{
    public class ImageGalleryDto : BaseDto
    {
        public int ProductId { get; set; }
        public ProductDto ProductDto { get; set; }
        //public int InnerPageId { get; set; }
        //public InnerPageDto InnerPageDto { get; set; }
        public List<ImageDto> ImageDtos { get; set; }

    }
}
